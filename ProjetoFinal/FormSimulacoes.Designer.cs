namespace ProjetoFinal
{
    partial class FormSimulacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimulacoes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.projetoFinalDataSet = new ProjetoFinal.ProjetoFinalDataSet();
            this.simulacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulacoesTableAdapter = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.SimulacoesTableAdapter();
            this.tableAdapterManager = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager();
            this.simulacoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.simulacoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.viewSimulacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewSimulacoesTableAdapter = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.ViewSimulacoesTableAdapter();
            this.viewSimulacoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).BeginInit();
            this.simulacoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSimulacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSimulacoesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.SimulacoesTableAdapter = this.simulacoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // simulacoesBindingNavigator
            // 
            this.simulacoesBindingNavigator.AddNewItem = null;
            this.simulacoesBindingNavigator.BindingSource = this.simulacoesBindingSource;
            this.simulacoesBindingNavigator.CountItem = null;
            this.simulacoesBindingNavigator.DeleteItem = null;
            this.simulacoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.simulacoesBindingNavigatorSaveItem,
            this.toolStripButtonEditar});
            this.simulacoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.simulacoesBindingNavigator.MoveFirstItem = null;
            this.simulacoesBindingNavigator.MoveLastItem = null;
            this.simulacoesBindingNavigator.MoveNextItem = null;
            this.simulacoesBindingNavigator.MovePreviousItem = null;
            this.simulacoesBindingNavigator.Name = "simulacoesBindingNavigator";
            this.simulacoesBindingNavigator.PositionItem = null;
            this.simulacoesBindingNavigator.Size = new System.Drawing.Size(646, 25);
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // simulacoesBindingNavigatorSaveItem
            // 
            this.simulacoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.simulacoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("simulacoesBindingNavigatorSaveItem.Image")));
            this.simulacoesBindingNavigatorSaveItem.Name = "simulacoesBindingNavigatorSaveItem";
            this.simulacoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.simulacoesBindingNavigatorSaveItem.Text = "Save Data";
            this.simulacoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.SimulacoesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditar.Text = "toolStripButtonEditar";
            this.toolStripButtonEditar.ToolTipText = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.ToolStripButtonEditar_Click);
            // 
            // viewSimulacoesBindingSource
            // 
            this.viewSimulacoesBindingSource.DataMember = "ViewSimulacoes";
            this.viewSimulacoesBindingSource.DataSource = this.projetoFinalDataSet;
            // 
            // viewSimulacoesTableAdapter
            // 
            this.viewSimulacoesTableAdapter.ClearBeforeFill = true;
            // 
            // viewSimulacoesDataGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viewSimulacoesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewSimulacoesDataGridView.AutoGenerateColumns = false;
            this.viewSimulacoesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewSimulacoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSimulacoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.viewSimulacoesDataGridView.DataSource = this.viewSimulacoesBindingSource;
            this.viewSimulacoesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSimulacoesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.viewSimulacoesDataGridView.Name = "viewSimulacoesDataGridView";
            this.viewSimulacoesDataGridView.Size = new System.Drawing.Size(646, 425);
            this.viewSimulacoesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SimulacaoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SimulacaoID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 92;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpresaID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmpresaID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RazaoSocial";
            this.dataGridViewTextBoxColumn3.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 73;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustoFixoTotal";
            this.dataGridViewTextBoxColumn4.HeaderText = "CustoFixoTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CustoVarUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "CustoVarUnit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 94;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PrecoUnit";
            this.dataGridViewTextBoxColumn6.HeaderText = "PrecoUnit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 79;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QtdeVendaInicial";
            this.dataGridViewTextBoxColumn7.HeaderText = "QtdeVendaInicial";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 113;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "QtdeVendaFinal";
            this.dataGridViewTextBoxColumn8.HeaderText = "QtdeVendaFinal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 108;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IncrementoUnit";
            this.dataGridViewTextBoxColumn9.HeaderText = "IncrementoUnit";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 104;
            // 
            // FormSimulacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.viewSimulacoesDataGridView);
            this.Controls.Add(this.simulacoesBindingNavigator);
            this.Name = "FormSimulacoes";
            this.Text = "FormSimulacoes";
            this.Load += new System.EventHandler(this.FormSimulacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacoesBindingNavigator)).EndInit();
            this.simulacoesBindingNavigator.ResumeLayout(false);
            this.simulacoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSimulacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSimulacoesDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton simulacoesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource viewSimulacoesBindingSource;
        private ProjetoFinalDataSetTableAdapters.ViewSimulacoesTableAdapter viewSimulacoesTableAdapter;
        private System.Windows.Forms.DataGridView viewSimulacoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
    }
}