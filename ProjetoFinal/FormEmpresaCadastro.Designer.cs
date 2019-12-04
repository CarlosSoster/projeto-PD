namespace ProjetoFinal
{
    partial class FormEmpresaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresaCadastro));
            System.Windows.Forms.Label empresaIDLabel;
            System.Windows.Forms.Label razaoSocialLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label foneLabel;
            this.projetoFinalDataSet = new ProjetoFinal.ProjetoFinalDataSet();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.EmpresasTableAdapter();
            this.tableAdapterManager = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager();
            this.empresasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.empresasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empresaIDTextBox = new System.Windows.Forms.TextBox();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.cNPJTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            empresaIDLabel = new System.Windows.Forms.Label();
            razaoSocialLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingNavigator)).BeginInit();
            this.empresasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // projetoFinalDataSet
            // 
            this.projetoFinalDataSet.DataSetName = "ProjetoFinalDataSet";
            this.projetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.projetoFinalDataSet;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.SimulacoesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empresasBindingNavigator
            // 
            this.empresasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empresasBindingNavigator.BindingSource = this.empresasBindingSource;
            this.empresasBindingNavigator.CountItem = null;
            this.empresasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empresasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.empresasBindingNavigatorSaveItem});
            this.empresasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empresasBindingNavigator.MoveFirstItem = null;
            this.empresasBindingNavigator.MoveLastItem = null;
            this.empresasBindingNavigator.MoveNextItem = null;
            this.empresasBindingNavigator.MovePreviousItem = null;
            this.empresasBindingNavigator.Name = "empresasBindingNavigator";
            this.empresasBindingNavigator.PositionItem = null;
            this.empresasBindingNavigator.Size = new System.Drawing.Size(271, 25);
            this.empresasBindingNavigator.TabIndex = 0;
            this.empresasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // empresasBindingNavigatorSaveItem
            // 
            this.empresasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empresasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empresasBindingNavigatorSaveItem.Image")));
            this.empresasBindingNavigatorSaveItem.Name = "empresasBindingNavigatorSaveItem";
            this.empresasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.empresasBindingNavigatorSaveItem.Text = "Save Data";
            this.empresasBindingNavigatorSaveItem.Click += new System.EventHandler(this.EmpresasBindingNavigatorSaveItem_Click);
            // 
            // empresaIDLabel
            // 
            empresaIDLabel.AutoSize = true;
            empresaIDLabel.Location = new System.Drawing.Point(28, 44);
            empresaIDLabel.Name = "empresaIDLabel";
            empresaIDLabel.Size = new System.Drawing.Size(65, 13);
            empresaIDLabel.TabIndex = 1;
            empresaIDLabel.Text = "Empresa ID:";
            // 
            // empresaIDTextBox
            // 
            this.empresaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "EmpresaID", true));
            this.empresaIDTextBox.Location = new System.Drawing.Point(107, 41);
            this.empresaIDTextBox.Name = "empresaIDTextBox";
            this.empresaIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.empresaIDTextBox.TabIndex = 2;
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Location = new System.Drawing.Point(28, 70);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(73, 13);
            razaoSocialLabel.TabIndex = 3;
            razaoSocialLabel.Text = "Razao Social:";
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "RazaoSocial", true));
            this.razaoSocialTextBox.Location = new System.Drawing.Point(107, 67);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(100, 20);
            this.razaoSocialTextBox.TabIndex = 4;
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(28, 96);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(37, 13);
            cNPJLabel.TabIndex = 5;
            cNPJLabel.Text = "CNPJ:";
            // 
            // cNPJTextBox
            // 
            this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "CNPJ", true));
            this.cNPJTextBox.Location = new System.Drawing.Point(107, 93);
            this.cNPJTextBox.Name = "cNPJTextBox";
            this.cNPJTextBox.Size = new System.Drawing.Size(100, 20);
            this.cNPJTextBox.TabIndex = 6;
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(28, 122);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(34, 13);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Fone:";
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(107, 119);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(100, 20);
            this.foneTextBox.TabIndex = 8;
            // 
            // FormEmpresaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 172);
            this.Controls.Add(empresaIDLabel);
            this.Controls.Add(this.empresaIDTextBox);
            this.Controls.Add(razaoSocialLabel);
            this.Controls.Add(this.razaoSocialTextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(this.empresasBindingNavigator);
            this.Name = "FormEmpresaCadastro";
            this.Text = "FormEmpresaCadastro";
            this.Load += new System.EventHandler(this.FormEmpresaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingNavigator)).EndInit();
            this.empresasBindingNavigator.ResumeLayout(false);
            this.empresasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjetoFinalDataSet projetoFinalDataSet;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private ProjetoFinalDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private ProjetoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empresasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton empresasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox empresaIDTextBox;
        private System.Windows.Forms.TextBox razaoSocialTextBox;
        private System.Windows.Forms.TextBox cNPJTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
    }
}