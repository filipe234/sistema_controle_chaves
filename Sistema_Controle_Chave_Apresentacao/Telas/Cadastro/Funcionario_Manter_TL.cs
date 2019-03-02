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
using Sistema_Controle_Chave_Apresentacao.Telas.Carregar_Componentes;

namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    public partial class Funcionario_Manter_TL : DevExpress.XtraEditors.XtraForm
    {
        #region Atributos
        public Codigo_Funcionalidade Funcionalidade { get; set; }
        #endregion
        public Funcionario_Manter_TL()
        {
            InitializeComponent();
        }

        private void Funcionario_Manter_TL_Shown( object sender, DevExpress.XtraEditors.Controls.BeforeShowMenuEventArgs e )
        {
            try
            {
                using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
                {
                    Carregar_Componente.Setor(lue_Setor, oBD, 0);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Salvar_Click( object sender, EventArgs e )
        {
            try
            {
                Funcionario_BD oFuncionario = new Funcionario_BD();

                if ( lue_Setor.EditValue != "" && Convert.ToInt16(lue_Setor.EditValue) > 0 )
                    oFuncionario.Setor = Convert.ToInt16(lue_Setor.EditValue);
                oFuncionario.CPF = txt_CPF.Text;
                oFuncionario.Nome = txt_Nome_Funcionario.Text;
                oFuncionario.RG = txt_RG.Text;
               

                if ( Funcionalidade == Codigo_Funcionalidade.Inserir )
                {
                   SG_Cadastro_Funcinario_NG.Funcionario.Inserir(oFuncionario);
                    MessageBox.Show("Funcionário Cadastrado com seucesso!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
                else if ( Funcionalidade == Codigo_Funcionalidade.Alterar )
                {
                    SG_Cadastro_Funcinario_NG.Funcionario.Alterar(oFuncionario);
                    MessageBox.Show("Funcionário Alterado com seucesso!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Cancelar_Click( object sender, EventArgs e )
        {
            try
            {
                Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}