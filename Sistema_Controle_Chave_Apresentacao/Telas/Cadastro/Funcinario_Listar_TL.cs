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
using Sistema_Controle_Chave_Negocio.Negocio;
using Sistema_Controle_Chave_Negocio.Persistencia;

namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    public partial class Funcinario_Listar_TL : DevExpress.XtraEditors.XtraForm
    {
        public Funcinario_Listar_TL()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click( object sender, EventArgs e )
        {
            try
            {
                txt_CPF.Text = "";
                txt_Nome_Funcionario.Text = "";
                gc_Listar_Funcionario.DataSource = null;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gv_Listar_Funcionario_RowCellClick( object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e )
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
                Funcionario_Filtro_BD oFiltro = new Funcionario_Filtro_BD();
                oFiltro.Nome_Funcionario = txt_Nome_Funcionario.Text;
                oFiltro.CPF = txt_CPF.Text;

                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    List<Funcionario_Grid_BD> oLista = SG_Cadastro_Funcinario_NG.Funcionario.Pesquisar_Grid(oBD, oFiltro);
                    gc_Listar_Funcionario.DataSource = oLista;

                    if ( oLista.Count == 0 )
                        MessageBox.Show("Nenhum registro encontrado!", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Inserir_Click( object sender, EventArgs e )
        {
            try
            {
               Funcionario_Manter_TL oTela = new Funcionario_Manter_TL();
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