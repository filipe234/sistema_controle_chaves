using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sistema_Controle_Chave_Negocio.Persistencia;
using Sistema_Controle_Chave_Negocio.Negocio;

namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    public partial class Operador_Listar_TL : DevExpress.XtraEditors.XtraForm
    {
        public Operador_Listar_TL()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click( object sender, EventArgs e )
        {
            try
            {
                txt_CPF.Text = "";
                txt_Nome_Operador.Text = "";
                gc_Listar_Operador.DataSource = null;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gv_Listar_Operador_RowCellClick( object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e )
        {
            try
            {

            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Operador");
            }
        }

        private void btn_Pesquisar_Click( object sender, EventArgs e )
        {
            try
            {
                Operador_Filtro_BD oFiltro = new Operador_Filtro_BD();
                oFiltro.Nome_Operador = txt_Nome_Operador.Text;
                oFiltro.CPF = txt_CPF.Text;

                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    List<Operador_Grid_BD> oLista = SG_Cadastro_NG.Operador.Pesquisar_Grid(oBD, oFiltro);
                    gc_Listar_Operador.DataSource = oLista;

                    if ( oLista.Count == 0 )
                        MessageBox.Show("Nenhum registro encontrado!", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void brn_Inserir_Click( object sender, EventArgs e )
        {
            try
            {
                Operador_Manter_TL oTela = new Operador_Manter_TL();
                oTela.Funcionalidade = Codigo_Funcionalidade.Inserir;

                oTela.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}