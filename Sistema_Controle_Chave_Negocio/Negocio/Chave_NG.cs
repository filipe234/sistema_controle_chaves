using Sistema_Controle_Chave_Negocio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Chave_Negocio.Negocio
{
    public class Chave_NG
    {
        #region Pesquisar

        public List<Chave_Grid_BD> Pesquisar_Grid( BD_SISTEMA_CONTROLE_CHAVE pBD, Chave_Filtro_BD pFiltro )
        {
            List<Chave_Grid_BD> oLista = ( from c in pBD.Chave_BDs

                                           where ( pFiltro.Nome_Chave.Length <= 0 ? true : pFiltro.Nome_Chave == c.Nome )
                                           && ( pFiltro.Numero_Chave.Length == 0 || pFiltro.Numero_Chave == null ? true : pFiltro.Numero_Chave == c.Numero )

                                           join i in pBD.Situacao_Chave_BDs
                                           on c.Codigo equals i.Codigo

                                           join s in pBD.Setor_BDs
                                          on c.Codigo equals s.Codigo

                                           select new Chave_Grid_BD
                                           {
                                               Codigo = c.Codigo,
                                               Nome = c.Nome,
                                               E_Chave_Restrita = c.E_Chave_Restrita,
                                               Numero = c.Numero,
                                               Situacao = i.Codigo,
                                               Setor = s.Codigo,
                                           } ).ToList();

            return oLista;
        }

        public Chave_BD Pesquisar_pelo_Codigo( BD_SISTEMA_CONTROLE_CHAVE pBD, int pCodigo )
        {
            return pBD.Chave_BDs.Where(x => x.Codigo == pCodigo).FirstOrDefault();
        }



        #endregion


        #region Inserir


        public int Inserir( Chave_BD pChave )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    Validar_Cadastro(pChave);

                    oBD.Chave_BDs.Add(pChave);

                    oBD.SaveChanges();

                    return pChave.Codigo;
                }
            }
            catch ( Exception ex )
            {

                throw ex;
            }
        }


        #endregion


        #region Alterar


        public void Alterar( Chave_BD pChave )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE pBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {

                    Chave_BD oChave = Pesquisar_pelo_Codigo(pBD, pChave.Codigo);
                    oChave.Nome = pChave.Nome;
                    oChave.Numero = pChave.Numero;
                    oChave.Situacao = pChave.Situacao;
                    oChave.Setor = pChave.Setor;
                    Validar_Cadastro(oChave);

                    pBD.SaveChanges();
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
        }


        #endregion


        #region Escluir


        public void Excluir( int? pCodigo )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    Validar_Exclusao(oBD, pCodigo);
                    Chave_BD oChave = Pesquisar_pelo_Codigo(oBD, (int)pCodigo);
                    oBD.Chave_BDs.Remove(oChave);
                    oBD.SaveChanges();
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }
        }


        protected void Validar_Exclusao( BD_SISTEMA_CONTROLE_CHAVE pBD, int? pCodigo )
        {
            if ( pBD.Saida_Chave_BDs.Where(w => w.Codigo == pCodigo).ToList().Count > 0 )
                throw new Exception("A chave não pode ser excluído porque tem setor vinculado!");
        }

        #endregion


        #region Validações


        protected void Validar_Cadastro( Chave_BD pChave )
        {
            if ( pChave.Nome == null || pChave.Nome == string.Empty )
                throw new Exception("O nome da chave é obrigátorio!");
            if ( pChave.Numero == null || pChave.Numero == string.Empty || pChave.Numero.Length > 11 )
                throw new Exception("O CPF é obrigátorio!");
            if ( pChave.Situacao == 0 || pChave.Situacao == null )
                throw new Exception("A situação é obrigátorio!");
            if ( pChave.Setor <= 0 )
                throw new Exception("O Setor é obrigátorio!");

        }


        #endregion
    }
    public class Chave_Grid_BD
    {
        public int Codigo { get; set; }
        public short Setor { get; set; }
        public short Situacao { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public Nullable<bool> E_Chave_Restrita { get; set; }

        public virtual Setor_BD TB_CAD_SETOR { get; set; }
        public virtual Situacao_Chave_BD TB_CAD_SITUACAO_CHAVE { get; set; }
    }
    public class Chave_Filtro_BD
    {
        public string Nome_Chave { get; set; }
        public string Numero_Chave { get; set; }
    }
}
