using Sistema_Controle_Chave_Apresentacao.Telas.Util;
using Sistema_Controle_Chave_Negocio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Chave_Negocio.Negocio
{
    public class Operador_NG
    {
        #region Pesquisar


        public List<Operador_Grid_BD> Pesquisar_Grid( BD_SISTEMA_CONTROLE_CHAVE pBD, Operador_Filtro_BD pFiltro )
        {
            List<Operador_Grid_BD> oLista = ( from c in pBD.Operador_BDs

                                              where ( pFiltro.Nome_Operador.Length <= 0 ? true : pFiltro.Nome_Operador == c.Nome_Operador )
                                              && ( pFiltro.CPF.Length == 0 || pFiltro.CPF == null ? true : pFiltro.CPF == c.CPF )

                                              join u in pBD.Plantao_BDs
                                              on c.Codigo_Plantao equals u.Codigo

                                              join n in pBD.Nivel_Operador_BDs
                                             on c.Codigo_Nivel_Operador equals n.Codigo

                                              join s in pBD.Setor_BDs
                                              on c.Codigo_Setor equals s.Codigo

                                              select new Operador_Grid_BD
                                              {
                                                  Codigo = c.Codigo,
                                                  Nome_Operador = c.Nome_Operador,
                                                  CPF = c.CPF,
                                                  Nome_Login = c.Login,
                                                  RG = c.RG,
                                                  Nome_Setor = s.Nome,
                                                  Nome_Plantao = u.Nome,
                                                  Nome_Nivel_Operador = n.Nome,
                                              } ).ToList();

            foreach ( Operador_Grid_BD item in oLista )
                item.CPF = Formatacao.FormatCPF(item.CPF);

            return oLista;
        }

        private Operador_BD Pesquisar_pelo_Codigo( BD_SISTEMA_CONTROLE_CHAVE pBD, int pCodigo )
        {
            return pBD.Operador_BDs.Where(x => x.Codigo == pCodigo).FirstOrDefault();
        }


        #endregion


        #region Inserir


        public int Inserir( Operador_BD pOperador )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    Validar_Cadastro(pOperador);

                    oBD.Operador_BDs.Add(pOperador);

                    oBD.SaveChanges();

                    return pOperador.Codigo;
                }
            }
            catch ( Exception ex )
            {

                throw ex;
            }
        }


        #endregion


        #region Alterar


        public void Alterar( Operador_BD pOperador )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE pBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {

                    Operador_BD oOperador = Pesquisar_pelo_Codigo(pBD, pOperador.Codigo);
                    oOperador.Nome_Operador = pOperador.Nome_Operador;
                    oOperador.Login = pOperador.Login;
                    oOperador.RG = pOperador.RG;
                    oOperador.CPF = pOperador.CPF;
                    oOperador.Senha = pOperador.Senha;
                    oOperador.Codigo_Nivel_Operador = pOperador.Codigo_Nivel_Operador;
                    oOperador.Codigo_Plantao = pOperador.Codigo_Plantao;
                    oOperador.Codigo_Setor = pOperador.Codigo_Setor;

                    Validar_Cadastro(oOperador);

                    pBD.SaveChanges();
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
        }




        #endregion


        #region Excluir

        public void Excluir( int? pCodigo )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    Validar_Exclusao(oBD, pCodigo);
                    Operador_BD oOperador = Pesquisar_pelo_Codigo(oBD, (int)pCodigo);
                    oBD.Operador_BDs.Remove(oOperador);
                    oBD.SaveChanges();
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
        }

        #endregion


        #region Validações


        protected void Validar_Cadastro( Operador_BD pOperador )
        {
            if ( pOperador.Nome_Operador == null || pOperador.Nome_Operador == string.Empty )
                throw new Exception("O nome é obrigátorio!");
            if ( pOperador.CPF == null || pOperador.CPF == string.Empty || pOperador.CPF.Length>11)
                throw new Exception("O CPF é obrigátorio!");
            if ( pOperador.Login == null || pOperador.Login == string.Empty )
                throw new Exception("O Login é obrigátorio!");
            if ( pOperador.RG == null || pOperador.RG == string.Empty )
                throw new Exception("O RG é obrigátorio!");
            if ( pOperador.Codigo_Plantao <= 0 )
                throw new Exception("O plantão é obrigátorio!");
            if ( pOperador.Codigo_Nivel_Operador <= 0 )
                throw new Exception("O Nível é obrigátorio!");
            if ( pOperador.Codigo_Setor <= 0 )
                throw new Exception("O Setor é obrigátorio!");

        }

        protected void Validar_Exclusao( BD_SISTEMA_CONTROLE_CHAVE pBD, int? pCodigo )
        {
            if ( pBD.Saida_Chave_BDs.Where(w => w.Codigo_Operador == pCodigo).ToList().Count > 0 )
                throw new Exception("O Operador não pode ser excluído porque tem setor vinculado!");
        }


        #endregion
    }

    public class Operador_Grid_BD
    {
        public int Codigo { get; set; }
        public short Codigo_Plantao { get; set; }
        public short Codigo_Nivel_Operador { get; set; }
        public short Codigo_Setor { get; set; }
        public string Nome_Login { get; set; }
        public string Senha { get; set; }
        public string Nome_Operador { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Nome_Setor { get; internal set; }
        public string Nome_Plantao { get; internal set; }
        public string Nome_Nivel_Operador { get; internal set; }

    }
    public class Operador_Filtro_BD
    {
        public string Nome_Operador { get; set; }
        public string CPF { get; set; }
    }
}
