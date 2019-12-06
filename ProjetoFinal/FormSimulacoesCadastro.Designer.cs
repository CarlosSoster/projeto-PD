namespace ProjetoFinal
{
    partial class FormSimulacoesCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label simulacaoIDLabel;
            System.Windows.Forms.Label empresaIDLabel;
            System.Windows.Forms.Label custoFixoTotalLabel;
            System.Windows.Forms.Label custoVarUnitLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.Label qtdeVendaInicialLabel;
            System.Windows.Forms.Label qtdeVendaFinalLabel;
            System.Windows.Forms.Label incrementoUnitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimulacoesCadastro));
            this.projetoFinalDataSet = new ProjetoFinal.ProjetoFinalDataSet();
            this.simulacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulacoesTableAdapter = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.SimulacoesTableAdapter();
            this.tableAdapterManager = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager();
            this.empresasTableAdapter = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.EmpresasTableAdapter();
            this.simulacoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.simulacoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.simulacaoIDTextBox = new System.Windows.Forms.TextBox();
            this.empresaIDComboBox = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custoFixoTotalTextBox = new System.Windows.Forms.TextBox();
            this.custoVarUnitTextBox = new System.Windows.Forms.TextBox();
            this.precoUnitTextBox = new System.Windows.Forms.TextBox();
            this.qtdeVendaInicialTextBox = new System.Windows.Forms.TextBox();
            this.qtdeVendaFinalTextBox = new System.Windows.Forms.TextBox();
            this.incrementoUnitTextBox = new System.Windows.Forms.TextBox();
            simulacaoIDLabel = new System.Windows.Forms.Label();
            empresaIDLabel = new System.Windows.Forms.Label();
            custoFixoTotalLabel = new System.Windows.Forms.Label();
            custoVarUnitLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            qtdeVendaInicialLabel = new System.Windows.Forms.Label();
            qtdeVendaFinalLabel = new System.Windows.Forms.Label();
            incrementoUnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).BeginInit();
            this.simulacoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simulacaoIDLabel
            // 
            simulacaoIDLabel.AutoSize = true;
            simulacaoIDLabel.Location = new System.Drawing.Point(21, 46);
            simulacaoIDLabel.Name = "simulacaoIDLabel";
            simulacaoIDLabel.Size = new System.Drawing.Size(73, 13);
            simulacaoIDLabel.TabIndex = 1;
            simulacaoIDLabel.Text = "Simulacao ID:";
            // 
            // empresaIDLabel
            // 
            empresaIDLabel.AutoSize = true;
            empresaIDLabel.Location = new System.Drawing.Point(21, 72);
            empresaIDLabel.Name = "empresaIDLabel";
            empresaIDLabel.Size = new System.Drawing.Size(51, 13);
            empresaIDLabel.TabIndex = 3;
            empresaIDLabel.Text = "Empresa:";
            // 
            // custoFixoTotalLabel
            // 
            custoFixoTotalLabel.AutoSize = true;
            custoFixoTotalLabel.Location = new System.Drawing.Point(21, 99);
            custoFixoTotalLabel.Name = "custoFixoTotalLabel";
            custoFixoTotalLabel.Size = new System.Drawing.Size(86, 13);
            custoFixoTotalLabel.TabIndex = 5;
            custoFixoTotalLabel.Text = "Custo Fixo Total:";
            // 
            // custoVarUnitLabel
            // 
            custoVarUnitLabel.AutoSize = true;
            custoVarUnitLabel.Location = new System.Drawing.Point(21, 125);
            custoVarUnitLabel.Name = "custoVarUnitLabel";
            custoVarUnitLabel.Size = new System.Drawing.Size(78, 13);
            custoVarUnitLabel.TabIndex = 7;
            custoVarUnitLabel.Text = "Custo Var Unit:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(21, 151);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(60, 13);
            precoUnitLabel.TabIndex = 9;
            precoUnitLabel.Text = "Preco Unit:";
            // 
            // qtdeVendaInicialLabel
            // 
            qtdeVendaInicialLabel.AutoSize = true;
            qtdeVendaInicialLabel.Location = new System.Drawing.Point(21, 177);
            qtdeVendaInicialLabel.Name = "qtdeVendaInicialLabel";
            qtdeVendaInicialLabel.Size = new System.Drawing.Size(97, 13);
            qtdeVendaInicialLabel.TabIndex = 11;
            qtdeVendaInicialLabel.Text = "Qtde Venda Inicial:";
            // 
            // qtdeVendaFinalLabel
            // 
            qtdeVendaFinalLabel.AutoSize = true;
            qtdeVendaFinalLabel.Location = new System.Drawing.Point(21, 203);
            qtdeVendaFinalLabel.Name = "qtdeVendaFinalLabel";
            qtdeVendaFinalLabel.Size = new System.Drawing.Size(92, 13);
            qtdeVendaFinalLabel.TabIndex = 13;
            qtdeVendaFinalLabel.Text = "Qtde Venda Final:";
            // 
            // incrementoUnitLabel
            // 
            incrementoUnitLabel.AutoSize = true;
            incrementoUnitLabel.Location = new System.Drawing.Point(21, 229);
            incrementoUnitLabel.Name = "incrementoUnitLabel";
            incrementoUnitLabel.Size = new System.Drawing.Size(85, 13);
            incrementoUnitLabel.TabIndex = 15;
            incrementoUnitLabel.Text = "Incremento Unit:";
            // 
            // projetoFinalDataSet
            // 
            this.projetoFinalDataSet.DataSetName = "ProjetoFinalDataSet";
            this.projetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simulacoesBindingSource
            // 
            this.simulacoesBindingSource.DataMember = "Simulacoes";
            this.simulacoesBindingSource.DataSource = this.projetoFinalDataSet;
            // 
            // simulacoesTableAdapter
            // 
            this.simulacoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.SimulacoesTableAdapter = this.simulacoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // simulacoesBindingNavigator
            // 
            this.simulacoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.simulacoesBindingNavigator.BindingSource = this.simulacoesBindingSource;
            this.simulacoesBindingNavigator.CountItem = null;
            this.simulacoesBindingNavigator.DeleteItem = null;
            this.simulacoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.simulacoesBindingNavigatorSaveItem});
            this.simulacoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.simulacoesBindingNavigator.MoveFirstItem = null;
            this.simulacoesBindingNavigator.MoveLastItem = null;
            this.simulacoesBindingNavigator.MoveNextItem = null;
            this.simulacoesBindingNavigator.MovePreviousItem = null;
            this.simulacoesBindingNavigator.Name = "simulacoesBindingNavigator";
            this.simulacoesBindingNavigator.PositionItem = null;
            this.simulacoesBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.simulacoesBindingNavigator.TabIndex = 0;
            this.simulacoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // simulacoesBindingNavigatorSaveItem
            // 
            this.simulacoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.simulacoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("simulacoesBindingNavigatorSaveItem.Image")));
            this.simulacoesBindingNavigatorSaveItem.Name = "simulacoesBindingNavigatorSaveItem";
            this.simulacoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.simulacoesBindingNavigatorSaveItem.Text = "Save Data";
            this.simulacoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.SimulacoesBindingNavigatorSaveItem_Click_1);
            // 
            // simulacaoIDTextBox
            // 
            this.simulacaoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "SimulacaoID", true));
            this.simulacaoIDTextBox.Enabled = false;
            this.simulacaoIDTextBox.Location = new System.Drawing.Point(124, 43);
            this.simulacaoIDTextBox.Name = "simulacaoIDTextBox";
            this.simulacaoIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.simulacaoIDTextBox.TabIndex = 2;
            // 
            // empresaIDComboBox
            // 
            this.empresaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simulacoesBindingSource, "EmpresaID", true));
            this.empresaIDComboBox.DataSource = this.empresasBindingSource;
            this.empresaIDComboBox.DisplayMember = "RazaoSocial";
            this.empresaIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaIDComboBox.FormattingEnabled = true;
            this.empresaIDComboBox.Location = new System.Drawing.Point(124, 69);
            this.empresaIDComboBox.Name = "empresaIDComboBox";
            this.empresaIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.empresaIDComboBox.TabIndex = 4;
            this.empresaIDComboBox.ValueMember = "EmpresaID";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.projetoFinalDataSet;
            // 
            // custoFixoTotalTextBox
            // 
            this.custoFixoTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "CustoFixoTotal", true));
            this.custoFixoTotalTextBox.Location = new System.Drawing.Point(124, 96);
            this.custoFixoTotalTextBox.Name = "custoFixoTotalTextBox";
            this.custoFixoTotalTextBox.Size = new System.Drawing.Size(121, 20);
            this.custoFixoTotalTextBox.TabIndex = 6;
            // 
            // custoVarUnitTextBox
            // 
            this.custoVarUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "CustoVarUnit", true));
            this.custoVarUnitTextBox.Location = new System.Drawing.Point(124, 122);
            this.custoVarUnitTextBox.Name = "custoVarUnitTextBox";
            this.custoVarUnitTextBox.Size = new System.Drawing.Size(121, 20);
            this.custoVarUnitTextBox.TabIndex = 8;
            // 
            // precoUnitTextBox
            // 
            this.precoUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "PrecoUnit", true));
            this.precoUnitTextBox.Location = new System.Drawing.Point(124, 148);
            this.precoUnitTextBox.Name = "precoUnitTextBox";
            this.precoUnitTextBox.Size = new System.Drawing.Size(121, 20);
            this.precoUnitTextBox.TabIndex = 10;
            // 
            // qtdeVendaInicialTextBox
            // 
            this.qtdeVendaInicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "QtdeVendaInicial", true));
            this.qtdeVendaInicialTextBox.Location = new System.Drawing.Point(124, 174);
            this.qtdeVendaInicialTextBox.Name = "qtdeVendaInicialTextBox";
            this.qtdeVendaInicialTextBox.Size = new System.Drawing.Size(121, 20);
            this.qtdeVendaInicialTextBox.TabIndex = 12;
            // 
            // qtdeVendaFinalTextBox
            // 
            this.qtdeVendaFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "QtdeVendaFinal", true));
            this.qtdeVendaFinalTextBox.Location = new System.Drawing.Point(124, 200);
            this.qtdeVendaFinalTextBox.Name = "qtdeVendaFinalTextBox";
            this.qtdeVendaFinalTextBox.Size = new System.Drawing.Size(121, 20);
            this.qtdeVendaFinalTextBox.TabIndex = 14;
            // 
            // incrementoUnitTextBox
            // 
            this.incrementoUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.simulacoesBindingSource, "IncrementoUnit", true));
            this.incrementoUnitTextBox.Location = new System.Drawing.Point(124, 226);
            this.incrementoUnitTextBox.Name = "incrementoUnitTextBox";
            this.incrementoUnitTextBox.Size = new System.Drawing.Size(121, 20);
            this.incrementoUnitTextBox.TabIndex = 16;
            // 
            // FormSimulacoesCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 274);
            this.Controls.Add(simulacaoIDLabel);
            this.Controls.Add(this.simulacaoIDTextBox);
            this.Controls.Add(empresaIDLabel);
            this.Controls.Add(this.empresaIDComboBox);
            this.Controls.Add(custoFixoTotalLabel);
            this.Controls.Add(this.custoFixoTotalTextBox);
            this.Controls.Add(custoVarUnitLabel);
            this.Controls.Add(this.custoVarUnitTextBox);
            this.Controls.Add(precoUnitLabel);
            this.Controls.Add(this.precoUnitTextBox);
            this.Controls.Add(qtdeVendaInicialLabel);
            this.Controls.Add(this.qtdeVendaInicialTextBox);
            this.Controls.Add(qtdeVendaFinalLabel);
            this.Controls.Add(this.qtdeVendaFinalTextBox);
            this.Controls.Add(incrementoUnitLabel);
            this.Controls.Add(this.incrementoUnitTextBox);
            this.Controls.Add(this.simulacoesBindingNavigator);
            this.Name = "FormSimulacoesCadastro";
            this.Text = "FormSimulacoesCadastro";
            this.Load += new System.EventHandler(this.FormSimulacoesCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).EndInit();
            this.simulacoesBindingNavigator.ResumeLayout(false);
            this.simulacoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjetoFinalDataSet projetoFinalDataSet;
        private System.Windows.Forms.BindingSource simulacoesBindingSource;
        private ProjetoFinalDataSetTableAdapters.SimulacoesTableAdapter simulacoesTableAdapter;
        private ProjetoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator simulacoesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton simulacoesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox simulacaoIDTextBox;
        private System.Windows.Forms.ComboBox empresaIDComboBox;
        private System.Windows.Forms.TextBox custoFixoTotalTextBox;
        private System.Windows.Forms.TextBox custoVarUnitTextBox;
        private System.Windows.Forms.TextBox precoUnitTextBox;
        private System.Windows.Forms.TextBox qtdeVendaInicialTextBox;
        private System.Windows.Forms.TextBox qtdeVendaFinalTextBox;
        private System.Windows.Forms.TextBox incrementoUnitTextBox;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private ProjetoFinalDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
    }
}