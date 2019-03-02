namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    partial class Funcionario_Manter_TL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario_Manter_TL));
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lue_Setor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_RG = new DevExpress.XtraEditors.TextEdit();
            this.txt_CPF = new DevExpress.XtraEditors.TextEdit();
            this.txt_Nome_Funcionario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Setor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Funcionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.groupControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(5, 5);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(687, 139);
            this.panelControl5.TabIndex = 14;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lue_Setor);
            this.groupControl1.Controls.Add(this.txt_RG);
            this.groupControl1.Controls.Add(this.txt_CPF);
            this.groupControl1.Controls.Add(this.txt_Nome_Funcionario);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(683, 135);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cadastro de Funcionário";
            // 
            // lue_Setor
            // 
            this.lue_Setor.EditValue = "";
            this.lue_Setor.Location = new System.Drawing.Point(133, 101);
            this.lue_Setor.Name = "lue_Setor";
            this.lue_Setor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_Setor.Properties.NullText = "";
            this.lue_Setor.Properties.ShowNullValuePromptWhenFocused = true;
            this.lue_Setor.Properties.View = this.searchLookUpEdit1View;
            this.lue_Setor.Properties.BeforeShowMenu += new DevExpress.XtraEditors.Controls.BeforeShowMenuEventHandler(this.Funcionario_Manter_TL_Shown);
            this.lue_Setor.Size = new System.Drawing.Size(155, 20);
            this.lue_Setor.TabIndex = 15;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Codigo,
            this.col_Nome});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_Nome, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // col_Codigo
            // 
            this.col_Codigo.Caption = "Codigo";
            this.col_Codigo.FieldName = "Codigo";
            this.col_Codigo.Name = "col_Codigo";
            // 
            // col_Nome
            // 
            this.col_Nome.Caption = "Nome";
            this.col_Nome.FieldName = "Nome";
            this.col_Nome.Name = "col_Nome";
            this.col_Nome.Visible = true;
            this.col_Nome.VisibleIndex = 0;
            // 
            // txt_RG
            // 
            this.txt_RG.Location = new System.Drawing.Point(133, 75);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(155, 20);
            this.txt_RG.TabIndex = 10;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(133, 49);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(155, 20);
            this.txt_CPF.TabIndex = 9;
            // 
            // txt_Nome_Funcionario
            // 
            this.txt_Nome_Funcionario.Location = new System.Drawing.Point(133, 23);
            this.txt_Nome_Funcionario.Name = "txt_Nome_Funcionario";
            this.txt_Nome_Funcionario.Size = new System.Drawing.Size(369, 20);
            this.txt_Nome_Funcionario.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(109, 78);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "RG:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(104, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "CPF:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Nome do Funcioário:\r\n";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(97, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Setor:";
            // 
            // panelControl4
            // 
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.Location = new System.Drawing.Point(0, 5);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(5, 139);
            this.panelControl4.TabIndex = 13;
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(692, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(5, 139);
            this.panelControl3.TabIndex = 12;
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSize = true;
            this.panelControl2.Controls.Add(this.btn_Cancelar);
            this.panelControl2.Controls.Add(this.btn_Salvar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 144);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(697, 43);
            this.panelControl2.TabIndex = 11;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.ImageOptions.Image")));
            this.btn_Cancelar.Location = new System.Drawing.Point(356, 0);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(134, 36);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar (F12)";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.ImageOptions.Image")));
            this.btn_Salvar.Location = new System.Drawing.Point(216, 0);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(134, 36);
            this.btn_Salvar.TabIndex = 0;
            this.btn_Salvar.Text = "Salvar (F11)";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(697, 5);
            this.panelControl1.TabIndex = 10;
            // 
            // Funcionario_Manter_TL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 187);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Funcionario_Manter_TL";
            this.Text = "Funcionario_Manter_TL";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Setor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Funcionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit lue_Setor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn col_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nome;
        private DevExpress.XtraEditors.TextEdit txt_RG;
        private DevExpress.XtraEditors.TextEdit txt_CPF;
        private DevExpress.XtraEditors.TextEdit txt_Nome_Funcionario;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Cancelar;
        private DevExpress.XtraEditors.SimpleButton btn_Salvar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}