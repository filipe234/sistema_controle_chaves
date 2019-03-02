using DevExpress.XtraEditors;
using Sistema_Controle_Chave_Negocio.Negocio;
using Sistema_Controle_Chave_Negocio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Chave_Apresentacao.Telas.Carregar_Componentes
{
    public class Carregar_Componente
    {
        public static void Setor( SearchLookUpEdit pLue, BD_SISTEMA_CONTROLE_CHAVE pBD, int pCodigo )
        {
            List<Setor_Grid_BD> oLista = ( from a in pBD.Setor_BDs
                                           select new Setor_Grid_BD
                                           {
                                               Codigo = a.Codigo,
                                               Nome = a.Nome
                                           } ).ToList();

            oLista.Add(new Setor_Grid_BD { Codigo = 0, Nome = "" });
            oLista.OrderBy(w => w.Codigo);

            pLue.Properties.DataSource = oLista;
            pLue.Properties.ValueMember = "Codigo";
            pLue.Properties.DisplayMember = "Nome";

            if ( pCodigo > 0 )
                pLue.EditValue = pCodigo;
        }
        public static void Nivel( SearchLookUpEdit pLue, BD_SISTEMA_CONTROLE_CHAVE pBD, int pCodigo )
        {
            List<Nivel_Operador_Grid_BD> oLista = ( from a in pBD.Nivel_Operador_BDs
                                                    select new Nivel_Operador_Grid_BD
                                                    {
                                                        Codigo = a.Codigo,
                                                        Nome = a.Nome
                                                    } ).ToList();

            oLista.Add(new Nivel_Operador_Grid_BD { Codigo = 0, Nome = "" });
            oLista.OrderBy(w => w.Codigo);

            pLue.Properties.DataSource = oLista;
            pLue.Properties.ValueMember = "Codigo";
            pLue.Properties.DisplayMember = "Nome";

            if ( pCodigo > 0 )
                pLue.EditValue = pCodigo;
        }
        public static void Plantao( SearchLookUpEdit pLue, BD_SISTEMA_CONTROLE_CHAVE pBD, int pCodigo )
        {
            List<Plantao_Operador_Grid_BD> oLista = ( from a in pBD.Plantao_BDs
                                                      select new Plantao_Operador_Grid_BD
                                                      {
                                                          Codigo = a.Codigo,
                                                          Nome = a.Nome
                                                      } ).ToList();

            oLista.Add(new Plantao_Operador_Grid_BD { Codigo = 0, Nome = "" });
            oLista.OrderBy(w => w.Codigo);

            pLue.Properties.DataSource = oLista;
            pLue.Properties.ValueMember = "Codigo";
            pLue.Properties.DisplayMember = "Nome";

            if ( pCodigo > 0 )
                pLue.EditValue = pCodigo;
        }
    }
}
