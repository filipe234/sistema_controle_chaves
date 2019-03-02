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
                if ( e.RowHandle > -1 )
                {
                    short oCodigo = Convert.ToInt16(gv_Listar_Operador.GetRowCellValue(e.RowHandle, col_Codigo));
                    string oNome = Convert.ToString(gv_Listar_Operador.GetRowCellValue(e.RowHandle, col_Nome_Operador));

                    if ( e.Column.AbsoluteIndex == col_Alterar.AbsoluteIndex )
                    {
                        Operador_Manter_TL oTela_Manter = new Operador_Manter_TL();
                        oTela_Manter.Funcionalidade = Codigo_Funcionalidade.Alterar;
                        oTela_Manter.Text = "Alterar Bandeira Cartão - " + oNome;
                        oTela_Manter.Codigo = oCodigo;

                        oTela_Manter.MdiParent = this.MdiParent;
                        oTela_Manter.Tela_Origem = this;
                        oTela_Manter.Show();
                    }
                    else if ( e.Column.AbsoluteIndex == col_Visualizar.AbsoluteIndex )
                    {
                        Operador_Manter_TL oTela_Manter = new Operador_Manter_TL();
                        oTela_Manter.Funcionalidade = Codigo_Funcionalidade.Visualizar;
                        oTela_Manter.Text = "Visualizar Bandeira Cartão - " + oNome;
                        oTela_Manter.Codigo = oCodigo;
                        oTela_Manter.MdiParent = this.MdiParent;
                        oTela_Manter.Tela_Origem = this;
                        oTela_Manter.Show();
                    }
                    else if ( e.Column.AbsoluteIndex == col_Excluir.AbsoluteIndex )
                    {
                        if ( MessageBox.Show("Deseja excluir o operador cartão\"" + oNome + "\"?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
                        {
                            SG_Cadastro_NG.Operador.Excluir(oCodigo);
                            btn_Pesquisar_Click(sender, e);
                            MessageBox.Show("Operador excluido com sucesso!", "Operador");
                        }
                    }
                }
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