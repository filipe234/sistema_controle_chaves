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
        public short Codigo { get; internal set; }
        public Funcionario_Listar_TL Tela_Origem { get; internal set; }

        #endregion
        public Funcionario_Manter_TL()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click( object sender, EventArgs e )
        {
            try
            {
                Funcionario_BD oFuncionario = new Funcionario_BD();
                oFuncionario.Codigo = Codigo;
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
                    MessageBox.Show("Funcionário Alterado com sucesso!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Funcionario_Manter_TL_Shown( object sender, EventArgs e )
        {

            try
            {
                if ( Funcionalidade == Codigo_Funcionalidade.Alterar )
                    Carregar_Tela(Codigo);

                else if ( Funcionalidade == Codigo_Funcionalidade.Visualizar )
                {
                    Carregar_Tela(Codigo);
                    Habilitar_Tela();
                }
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
        private void Habilitar_Tela()
        {
            txt_CPF.Enabled = false;

            txt_Nome_Funcionario.Enabled = false; ;
            txt_RG.Enabled = false;
            lue_Setor.Enabled = false;

            btn_Salvar.Visible = false;

            btn_Cancelar.Location = new Point(280, 2);
        }

        void Carregar_Tela( int pCodigo )
        {
            using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
            {
                Funcionario_BD oFuncionario_BD = SG_Cadastro_Funcinario_NG.Funcionario.Pesquisar_pelo_Codigo(oBD, pCodigo);
              
                txt_CPF.Text = oFuncionario_BD.CPF;
                txt_Nome_Funcionario.Text = oFuncionario_BD.Nome;
                txt_RG.Text = oFuncionario_BD.RG;
                Carregar_Componente.Setor(lue_Setor, oBD, oFuncionario_BD.Setor);
            }
        }
    }
}