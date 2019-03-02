using Sistema_Controle_Chave_Apresentacao.Telas.Util;
using Sistema_Controle_Chave_Negocio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Chave_Negocio.Negocio
{
    public class Funcionario_NG
    {

        #region Pesquisar

        public List<Funcionario_Grid_BD> Pesquisar_Grid( BD_SISTEMA_CONTROLE_CHAVE pBD, Funcionario_Filtro_BD pFiltro )
        {
            List<Funcionario_Grid_BD> oLista = ( from c in pBD.Funcionario_BDs

                                                 where ( pFiltro.Nome_Funcionario.Length <= 0 ? true : pFiltro.Nome_Funcionario == c.Nome )
                                                 && ( pFiltro.CPF.Length == 0 || pFiltro.CPF == null ? true : pFiltro.CPF == c.CPF )

                                                 join s in pBD.Setor_BDs
                                                 on c.Setor equals s.Codigo

                                                 select new Funcionario_Grid_BD
                                                 {
                                                     Código_Funcionario = c.Codigo,
                                                     Nome_Funcionario = c.Nome,
                                                     Numero_Cpf = c.CPF,
                                                     Numero_Rg = c.RG,
                                                     Codigo_Setor= s.Codigo,
                                                 } ).ToList();

            foreach ( Funcionario_Grid_BD item in oLista )
                item.Numero_Cpf = Formatacao.FormatCPF(item.Numero_Cpf);

            return oLista;
        }
        private Funcionario_BD Pesquisar_pelo_Codigo( BD_SISTEMA_CONTROLE_CHAVE pBD, int pCodigo )
        {
            return pBD.Funcionario_BDs.Where(x => x.Codigo == pCodigo).FirstOrDefault();
        }
        #endregion


        #region Inserir
        public int Inserir( Funcionario_BD pFuncionario )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    Validar_Cadastro(pFuncionario);

                    oBD.Funcionario_BDs.Add(pFuncionario);

                    oBD.SaveChanges();

                    return pFuncionario.Codigo;
                }
            }
            catch ( Exception ex )
            {

                throw ex;
            }
        }



        #endregion


        #region Alterar
        public void Alterar( Funcionario_BD pFuncionario )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE pBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {

                    Funcionario_BD oFuncionario = Pesquisar_pelo_Codigo(pBD, pFuncionario.Codigo);
                    oFuncionario.Nome = oFuncionario.Nome;
                    oFuncionario.RG = oFuncionario.RG;
                    oFuncionario.CPF = oFuncionario.CPF;
                    oFuncionario.Setor = oFuncionario.Setor;
                    Validar_Cadastro(pFuncionario);

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
                   Funcionario_BD oFuncionario = Pesquisar_pelo_Codigo(oBD, (int)pCodigo);
                    oBD.Funcionario_BDs.Remove(oFuncionario);
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

        protected void Validar_Cadastro( Funcionario_BD pFuncionario )
        {
            if ( pFuncionario.Nome == null || pFuncionario.Nome == string.Empty )
                throw new Exception("O nome é obrigátorio!");
            if ( pFuncionario.CPF == null || pFuncionario.CPF == string.Empty || pFuncionario.CPF.Length > 11 )
                throw new Exception("O CPF é obrigátorio!");
            if ( pFuncionario.RG == null || pFuncionario.RG == string.Empty )
                throw new Exception("O RG é obrigátorio!");
            if ( pFuncionario.Setor <= 0 )
                throw new Exception("O Setor é obrigátorio!");

        }

        protected void Validar_Exclusao( BD_SISTEMA_CONTROLE_CHAVE pBD, int? pCodigo )
        {
            if ( pBD.Saida_Chave_BDs.Where(w => w.Codigo_Funcionario == pCodigo).ToList().Count > 0 )
                throw new Exception("O Funcionario não poder excluído porque tem setor vinculado!");
        }

        #endregion
    }
    public class Funcionario_Grid_BD
    {
        public int Código_Funcionario { get; set; }
        public short Codigo_Setor { get; set; }
        public string Nome_Funcionario { get; set; }
        public string Numero_Cpf { get; set; }
        public string Numero_Rg { get; set; }
        public byte [] Foto { get; set; }
        public string Nome_Setor { get; internal set; }
    }
    public class Funcionario_Filtro_BD
    {
        public string Nome_Funcionario { get; set; }
        public string CPF { get; set; }
    }
}