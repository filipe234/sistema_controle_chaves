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
    public partial class Chaves_Listar_TL : DevExpress.XtraEditors.XtraForm
    {
        public Chaves_Listar_TL()
        {
            InitializeComponent();
        }

        private void btn_Limprar_Click( object sender, EventArgs e )
        {
            try
            {
                txt_Chave.Text = "";
                txt_Nome_Chave.Text = "";
                gc_Listar_Chave.DataSource = null;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Chave", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gv_Listar_Chave_RowCellClick( object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e )
        {
            try
            {
                if ( e.RowHandle > -1 )
                {
                    short oCodigo = Convert.ToInt16(gv_Listar_Chave.GetRowCellValue(e.RowHandle, Codigo_Chave));
                    string oNome = Convert.ToString(gv_Listar_Chave.GetRowCellValue(e.RowHandle, col_Nome_Chave));

                    if ( e.Column.AbsoluteIndex == col_Alterar.AbsoluteIndex )
                    {
                        Chaves_Manter_TL oTela_Manter = new Chaves_Manter_TL();
                        oTela_Manter.Funcionalidade = Codigo_Funcionalidade.Alterar;
                        oTela_Manter.Text = "Alterar Bandeira Cartão - " + oNome;
                        oTela_Manter.Codigo = oCodigo;

                        oTela_Manter.MdiParent = this.MdiParent;
                        oTela_Manter.Tela_Origem = this;
                        oTela_Manter.Show();
                    }
                    else if ( e.Column.AbsoluteIndex == col_Visualizar.AbsoluteIndex )
                    {
                        Chaves_Manter_TL oTela_Manter = new Chaves_Manter_TL();
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
                            SG_Cadastro_Chave_NG.Chave.Excluir(oCodigo);
                            btn_Pesquisar_Click(sender, e);
                            MessageBox.Show("A chave excluida com sucesso!", "Operador");
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
                Chave_Filtro_BD oFiltro = new Chave_Filtro_BD();
                oFiltro.Nome_Chave = txt_Nome_Chave.Text;
                oFiltro.Numero_Chave = txt_Chave.Text;

                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    List<Chave_Grid_BD> oLista = SG_Cadastro_Chave_NG.Chave.Pesquisar_Grid(oBD, oFiltro);
                    gc_Listar_Chave.DataSource = oLista;

                    if ( oLista.Count == 0 )
                        MessageBox.Show("Nenhum registro encontrado!", "Chave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Chave", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void brn_Inserir_Click( object sender, EventArgs e )
        {
            try
            {
                Chaves_Manter_TL oTela = new Chaves_Manter_TL();
                oTela.Funcionalidade = Codigo_Funcionalidade.Inserir;

                oTela.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Tela", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}