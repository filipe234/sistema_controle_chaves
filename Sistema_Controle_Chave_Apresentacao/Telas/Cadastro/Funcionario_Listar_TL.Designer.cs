﻿namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    partial class Funcionario_Listar_TL
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario_Listar_TL));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Listar_Funcionario = new DevExpress.XtraGrid.GridControl();
            this.gv_Listar_Funcionario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Excluir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_Visualizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_Alterar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_Codigo_Funcionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nome_Funcionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_RG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Setor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.brn_Inserir = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Limprar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Pesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.txt_CPF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Nome_Funcionario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Listar_Funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Listar_Funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Funcionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panelControl7);
            this.panelControl5.Controls.Add(this.panelControl6);
            this.panelControl5.Controls.Add(this.groupControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(0, 5);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(973, 440);
            this.panelControl5.TabIndex = 7;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.gc_Listar_Funcionario);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl7.Location = new System.Drawing.Point(2, 196);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(969, 242);
            this.panelControl7.TabIndex = 2;
            // 
            // gc_Listar_Funcionario
            // 
            this.gc_Listar_Funcionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Listar_Funcionario.Location = new System.Drawing.Point(2, 2);
            this.gc_Listar_Funcionario.MainView = this.gv_Listar_Funcionario;
            this.gc_Listar_Funcionario.Name = "gc_Listar_Funcionario";
            this.gc_Listar_Funcionario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemButtonEdit3});
            this.gc_Listar_Funcionario.Size = new System.Drawing.Size(965, 238);
            this.gc_Listar_Funcionario.TabIndex = 0;
            this.gc_Listar_Funcionario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Listar_Funcionario});
            // 
            // gv_Listar_Funcionario
            // 
            this.gv_Listar_Funcionario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Excluir,
            this.col_Visualizar,
            this.col_Alterar,
            this.col_Codigo_Funcionario,
            this.col_Nome_Funcionario,
            this.col_CPF,
            this.col_RG,
            this.col_Setor});
            this.gv_Listar_Funcionario.GridControl = this.gc_Listar_Funcionario;
            this.gv_Listar_Funcionario.Name = "gv_Listar_Funcionario";
            this.gv_Listar_Funcionario.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_Listar_Funcionario_RowCellClick);
            // 
            // col_Excluir
            // 
            this.col_Excluir.Caption = "E";
            this.col_Excluir.ColumnEdit = this.repositoryItemButtonEdit1;
            this.col_Excluir.Name = "col_Excluir";
            this.col_Excluir.OptionsColumn.AllowEdit = false;
            this.col_Excluir.OptionsColumn.FixedWidth = true;
            this.col_Excluir.Visible = true;
            this.col_Excluir.VisibleIndex = 0;
            this.col_Excluir.Width = 22;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // col_Visualizar
            // 
            this.col_Visualizar.Caption = "V";
            this.col_Visualizar.ColumnEdit = this.repositoryItemButtonEdit2;
            this.col_Visualizar.Name = "col_Visualizar";
            this.col_Visualizar.OptionsColumn.AllowEdit = false;
            this.col_Visualizar.OptionsColumn.AllowMove = false;
            this.col_Visualizar.OptionsColumn.FixedWidth = true;
            this.col_Visualizar.Visible = true;
            this.col_Visualizar.VisibleIndex = 1;
            this.col_Visualizar.Width = 22;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // col_Alterar
            // 
            this.col_Alterar.Caption = "A";
            this.col_Alterar.ColumnEdit = this.repositoryItemButtonEdit3;
            this.col_Alterar.Name = "col_Alterar";
            this.col_Alterar.OptionsColumn.AllowEdit = false;
            this.col_Alterar.OptionsColumn.AllowMove = false;
            this.col_Alterar.OptionsColumn.FixedWidth = true;
            this.col_Alterar.Visible = true;
            this.col_Alterar.VisibleIndex = 2;
            this.col_Alterar.Width = 22;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // col_Codigo_Funcionario
            // 
            this.col_Codigo_Funcionario.Caption = "Codigo";
            this.col_Codigo_Funcionario.FieldName = "Codigo_Funcionario";
            this.col_Codigo_Funcionario.Name = "col_Codigo_Funcionario";
            this.col_Codigo_Funcionario.Visible = true;
            this.col_Codigo_Funcionario.VisibleIndex = 7;
            this.col_Codigo_Funcionario.Width = 71;
            // 
            // col_Nome_Funcionario
            // 
            this.col_Nome_Funcionario.Caption = "Nome Funcionario";
            this.col_Nome_Funcionario.FieldName = "Nome_Funcionario";
            this.col_Nome_Funcionario.Name = "col_Nome_Funcionario";
            this.col_Nome_Funcionario.Visible = true;
            this.col_Nome_Funcionario.VisibleIndex = 3;
            this.col_Nome_Funcionario.Width = 241;
            // 
            // col_CPF
            // 
            this.col_CPF.Caption = "CPF";
            this.col_CPF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_CPF.FieldName = "CPF";
            this.col_CPF.Name = "col_CPF";
            this.col_CPF.Visible = true;
            this.col_CPF.VisibleIndex = 4;
            this.col_CPF.Width = 104;
            // 
            // col_RG
            // 
            this.col_RG.Caption = "RG";
            this.col_RG.FieldName = "RG";
            this.col_RG.Name = "col_RG";
            this.col_RG.Visible = true;
            this.col_RG.VisibleIndex = 5;
            this.col_RG.Width = 74;
            // 
            // col_Setor
            // 
            this.col_Setor.Caption = "Setor";
            this.col_Setor.FieldName = "Nome_Setor";
            this.col_Setor.Name = "col_Setor";
            this.col_Setor.Visible = true;
            this.col_Setor.VisibleIndex = 6;
            this.col_Setor.Width = 173;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.brn_Inserir);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl6.Location = new System.Drawing.Point(2, 150);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(969, 46);
            this.panelControl6.TabIndex = 1;
            // 
            // brn_Inserir
            // 
            this.brn_Inserir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brn_Inserir.ImageOptions.Image")));
            this.brn_Inserir.Location = new System.Drawing.Point(115, 6);
            this.brn_Inserir.Name = "brn_Inserir";
            this.brn_Inserir.Size = new System.Drawing.Size(134, 36);
            this.brn_Inserir.TabIndex = 14;
            this.brn_Inserir.Text = "Inserir (F5)";
            this.brn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.btn_Limprar);
            this.groupControl1.Controls.Add(this.btn_Pesquisar);
            this.groupControl1.Controls.Add(this.txt_CPF);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_Nome_Funcionario);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(969, 148);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Filtro";
            // 
            // btn_Limprar
            // 
            this.btn_Limprar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limprar.ImageOptions.Image")));
            this.btn_Limprar.Location = new System.Drawing.Point(255, 87);
            this.btn_Limprar.Name = "btn_Limprar";
            this.btn_Limprar.Size = new System.Drawing.Size(134, 36);
            this.btn_Limprar.TabIndex = 14;
            this.btn_Limprar.Text = "Limpar (F3)";
            this.btn_Limprar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.ImageOptions.Image")));
            this.btn_Pesquisar.Location = new System.Drawing.Point(115, 87);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(134, 36);
            this.btn_Pesquisar.TabIndex = 13;
            this.btn_Pesquisar.Text = "Pesquisar (F2)";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(124, 61);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(155, 20);
            this.txt_CPF.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(95, 64);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "CPF:";
            // 
            // txt_Nome_Funcionario
            // 
            this.txt_Nome_Funcionario.Location = new System.Drawing.Point(124, 35);
            this.txt_Nome_Funcionario.Name = "txt_Nome_Funcionario";
            this.txt_Nome_Funcionario.Size = new System.Drawing.Size(155, 20);
            this.txt_Nome_Funcionario.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Nome do Funcionário:\r\n";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 445);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(973, 5);
            this.panelControl2.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(973, 5);
            this.panelControl1.TabIndex = 5;
            // 
            // Funcionario_Listar_TL
            // 
            this.AllowDrop = true;
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Funcionario_Listar_TL";
            this.Text = "Pesquisar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Listar_Funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Listar_Funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Funcionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton brn_Inserir;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Limprar;
        private DevExpress.XtraEditors.SimpleButton btn_Pesquisar;
        private DevExpress.XtraEditors.TextEdit txt_CPF;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Nome_Funcionario;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_Listar_Funcionario;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Listar_Funcionario;
        private DevExpress.XtraGrid.Columns.GridColumn col_Excluir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Visualizar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn col_Alterar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn col_Codigo_Funcionario;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nome_Funcionario;
        private DevExpress.XtraGrid.Columns.GridColumn col_CPF;
        private DevExpress.XtraGrid.Columns.GridColumn col_RG;
        private DevExpress.XtraGrid.Columns.GridColumn col_Setor;
    }
}