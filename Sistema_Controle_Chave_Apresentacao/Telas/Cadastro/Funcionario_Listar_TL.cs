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
    public partial class Funcionario_Listar_TL : DevExpress.XtraEditors.XtraForm
    {
        public Funcionario_Listar_TL()
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

                if ( e.RowHandle > -1 )
                {
                   
                    string oNome = Convert.ToString(gv_Listar_Funcionario.GetRowCellValue(e.RowHandle, col_Nome_Funcionario));
                    short oCodigo = Convert.ToInt16(gv_Listar_Funcionario.GetRowCellValue(e.RowHandle, col_Codigo_Funcionario));

                    if ( e.Column.AbsoluteIndex == col_Alterar.AbsoluteIndex )
                    {
                        Funcionario_Manter_TL oTela_Manter = new Funcionario_Manter_TL();
                        oTela_Manter.Funcionalidade = Codigo_Funcionalidade.Alterar;
                        oTela_Manter.Text = "Alterar Nome do funcionario - " + oNome;
                        oTela_Manter.Codigo = oCodigo;

                        oTela_Manter.MdiParent = this.MdiParent;
                        oTela_Manter.Tela_Origem = this;
                        oTela_Manter.Show();
                    }
                    else if ( e.Column.AbsoluteIndex == col_Visualizar.AbsoluteIndex )
                    {
                        Funcionario_Manter_TL oTela_Manter = new Funcionario_Manter_TL();
                        oTela_Manter.Funcionalidade = Codigo_Funcionalidade.Visualizar;
                        oTela_Manter.Text = "Visualizar Funcionário - " + oNome;
                        oTela_Manter.Codigo = oCodigo;
                        oTela_Manter.MdiParent = this.MdiParent;
                        oTela_Manter.Tela_Origem = this;
                        oTela_Manter.Show();
                    }
                    else if ( e.Column.AbsoluteIndex == col_Excluir.AbsoluteIndex )
                    {
                        if ( MessageBox.Show("Deseja excluir o funcionário\"" + oNome + "\"?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
                        {
                            SG_Cadastro_Funcinario_NG.Funcionario.Excluir(oCodigo);
                            btn_Pesquisar_Click(sender, e);
                            MessageBox.Show("Funcionário excluido com sucesso!", "Funcionário");
                        }
                    }
                }

            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Funcionário");
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
                        MessageBox.Show("Nenhum registro encontrado!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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