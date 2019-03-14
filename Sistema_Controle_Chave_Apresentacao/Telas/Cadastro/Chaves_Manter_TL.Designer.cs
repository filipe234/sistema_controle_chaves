namespace Sistema_Controle_Chave_Apresentacao.Telas.Cadastro
{
    partial class Chaves_Manter_TL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chaves_Manter_TL));
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lue_Situacao = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lue_Setor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_Numero = new DevExpress.XtraEditors.TextEdit();
            this.txt_Nome_Chave = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Situacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Setor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Numero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Chave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.groupControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(0, 5);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(538, 164);
            this.panelControl5.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lue_Situacao);
            this.groupControl1.Controls.Add(this.lue_Setor);
            this.groupControl1.Controls.Add(this.txt_Numero);
            this.groupControl1.Controls.Add(this.txt_Nome_Chave);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(534, 160);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cadastro de Chave";
            // 
            // lue_Situacao
            // 
            this.lue_Situacao.EditValue = "";
            this.lue_Situacao.Location = new System.Drawing.Point(133, 105);
            this.lue_Situacao.Name = "lue_Situacao";
            this.lue_Situacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_Situacao.Properties.NullText = "";
            this.lue_Situacao.Properties.View = this.gridView1;
            this.lue_Situacao.Size = new System.Drawing.Size(155, 20);
            this.lue_Situacao.TabIndex = 16;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lue_Setor
            // 
            this.lue_Setor.EditValue = "";
            this.lue_Setor.Location = new System.Drawing.Point(133, 79);
            this.lue_Setor.Name = "lue_Setor";
            this.lue_Setor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_Setor.Properties.NullText = "";
            this.lue_Setor.Properties.View = this.searchLookUpEdit1View;
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
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(133, 49);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(155, 20);
            this.txt_Numero.TabIndex = 9;
            // 
            // txt_Nome_Chave
            // 
            this.txt_Nome_Chave.Location = new System.Drawing.Point(133, 23);
            this.txt_Nome_Chave.Name = "txt_Nome_Chave";
            this.txt_Nome_Chave.Size = new System.Drawing.Size(369, 20);
            this.txt_Nome_Chave.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(86, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Número:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(47, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Nome da Chave:\r\n";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Situação:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(97, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Setor:";
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSize = true;
            this.panelControl2.Controls.Add(this.btn_Cancelar);
            this.panelControl2.Controls.Add(this.btn_Salvar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 169);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(538, 43);
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
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.ImageOptions.Image")));
            this.btn_Salvar.Location = new System.Drawing.Point(216, 0);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(134, 36);
            this.btn_Salvar.TabIndex = 0;
            this.btn_Salvar.Text = "Salvar (F11)";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(538, 5);
            this.panelControl1.TabIndex = 10;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome";
            this.gridColumn2.FieldName = "Nome";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
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
            // Chaves_Manter_TL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 212);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Chaves_Manter_TL";
            this.Text = "Chaves_Manter_TL";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Situacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Setor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Numero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Chave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit lue_Situacao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SearchLookUpEdit lue_Setor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn col_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nome;
        private DevExpress.XtraEditors.TextEdit txt_Numero;
        private DevExpress.XtraEditors.TextEdit txt_Nome_Chave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Cancelar;
        private DevExpress.XtraEditors.SimpleButton btn_Salvar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}