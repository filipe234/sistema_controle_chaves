using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    public partial class Principal_TL : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Principal_TL()
        {
            InitializeComponent();
        }

        private void bbi_Operador_ItemClick( object sender, ItemClickEventArgs e )
        {
            try
            {
                Operador_Listar_TL oTela = new Operador_Listar_TL();
                 oTela.MdiParent = this;
                oTela.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void bbi_Funcionario_ItemClick( object sender, ItemClickEventArgs e )
        {
            try
            {
                Funcionario_Listar_TL oTela = new Funcionario_Listar_TL();
                oTela.MdiParent = this;
                oTela.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }
    }
}