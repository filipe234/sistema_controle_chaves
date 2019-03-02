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
using Sistema_Controle_Chave_Apresentacao.Telas.Carregar_Componentes;
using Sistema_Controle_Chave_Negocio.Persistencia;
using Sistema_Controle_Chave_Negocio.Util;
using Sistema_Controle_Chave_Negocio.Negocio;

namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    public partial class Operador_Manter_TL : DevExpress.XtraEditors.XtraForm
    {
        #region Atributos


        public Codigo_Funcionalidade Funcionalidade { get; set; }
        public short Codigo { get; internal set; }
        public Operador_Listar_TL Tela_Origem { get; internal set; }


        #endregion


        public Operador_Manter_TL()
        {
            InitializeComponent();
        }

        private void Operador_Manter_TL_Shown( object sender, EventArgs e )
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
                    Carregar_Componente.Nivel(lue_Nivel_Operador, oBD, 0);
                    Carregar_Componente.Plantao(lue_Plantao, oBD, 0);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Habilitar_Tela()
        {
            txt_CPF.Enabled = false;
            txt_Login.Enabled = false;
            txt_Nome_Operador.Enabled = false; ;
            txt_RG.Enabled = false;
            lue_Nivel_Operador.Enabled = false;
            lue_Plantao.Enabled = false;
            lue_Setor.Enabled = false;

            btn_Salvar.Visible = false;

            btn_Cancelar.Location = new Point(280, 2);
        }

        void Carregar_Tela( int pCodigo )
        {
            using ( BD_SISTEMA_CONTROLE_CHAVE oBD = new BD_SISTEMA_CONTROLE_CHAVE() )
            {
                Operador_BD oOperador_BD = SG_Cadastro_NG.Operador.Pesquisar_pelo_Codigo(oBD, pCodigo);

                txt_CPF.Text = oOperador_BD.CPF;
                txt_Login.Text = oOperador_BD.Login;
                txt_Nome_Operador.Text = oOperador_BD.Nome_Operador;
                txt_RG.Text = oOperador_BD.RG;

                Carregar_Componente.Setor(lue_Setor, oBD, oOperador_BD.Codigo_Setor);
                Carregar_Componente.Nivel(lue_Nivel_Operador, oBD, oOperador_BD.Codigo_Nivel_Operador);
                Carregar_Componente.Plantao(lue_Plantao, oBD, oOperador_BD.Codigo_Plantao);
            }
        }

        private void btn_Salvar_Click( object sender, EventArgs e )
        {
            try
            {
                Operador_BD oOperador = new Operador_BD();
                oOperador.Codigo = Codigo;
                if ( lue_Nivel_Operador.EditValue != "" && Convert.ToInt16(lue_Nivel_Operador.EditValue) > 0 )
                    oOperador.Codigo_Nivel_Operador = Convert.ToInt16(lue_Nivel_Operador.EditValue);
                if ( lue_Plantao.EditValue != "" && Convert.ToInt16(lue_Plantao.EditValue) > 0 )
                    oOperador.Codigo_Plantao = Convert.ToInt16(lue_Plantao.EditValue);
                if ( lue_Setor.EditValue != "" && Convert.ToInt16(lue_Setor.EditValue) > 0 )
                    oOperador.Codigo_Setor = Convert.ToInt16(lue_Setor.EditValue);
                oOperador.CPF = txt_CPF.Text;
                oOperador.Login = txt_Login.Text;
                oOperador.Nome_Operador = txt_Nome_Operador.Text;
                oOperador.RG = txt_RG.Text;
                oOperador.Senha = Cripty.md5encrypt(txt_Senha.Text);

                if ( Funcionalidade == Codigo_Funcionalidade.Inserir )
                {
                    SG_Cadastro_NG.Operador.Inserir(oOperador);
                    MessageBox.Show("Operador Cadastrado com seucesso!", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if ( Funcionalidade == Codigo_Funcionalidade.Alterar )
                {
                    SG_Cadastro_NG.Operador.Alterar(oOperador);
                    MessageBox.Show("Operador Alterado com sucesso!", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show(ex.Message, "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}