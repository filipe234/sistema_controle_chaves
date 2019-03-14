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

namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    public partial class Chaves_Manter_TL : DevExpress.XtraEditors.XtraForm
    {


        #region Atributos

        public Codigo_Funcionalidade Funcionalidade { get; set; }
        public short Codigo { get; internal set; }
        public Chaves_Listar_TL Tela_Origem { get; internal set; }
        #endregion
               

        public Chaves_Manter_TL()
        {
            InitializeComponent();
        }
        


       
    }


}