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


        #endregion
        public Operador_Manter_TL()
        {
            InitializeComponent();
        }

        private void Operador_Manter_TL_Shown( object sender, EventArgs e )
        {
            try
            {
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

        private void btn_Salvar_Click( object sender, EventArgs e )
        {
            try
            {
                Operador_BD oOperador = new Operador_BD();
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
                    MessageBox.Show("Operador Cadastrado com seucesso!", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
                else if ( Funcionalidade == Codigo_Funcionalidade.Alterar )
                {
                    SG_Cadastro_NG.Operador.Alterar(oOperador);
                    MessageBox.Show("Operador Alterado com seucesso!", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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