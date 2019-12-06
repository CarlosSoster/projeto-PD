namespace ProjetoFinal
{
    partial class Resultados
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
            this.projetoFinalDataSet = new ProjetoFinal.ProjetoFinalDataSet();
            this.resultadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustoFixo = new System.Windows.Forms.TextBox();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.txtCustoVariacel = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.simulacoesTableAdapter1 = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.SimulacoesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSimulacao = new System.Windows.Forms.ComboBox();
            this.viewSimulacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.viewSimulacoesTableAdapter = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.ViewSimulacoesTableAdapter();
            this.empresasTableAdapter = new ProjetoFinal.ProjetoFinalDataSetTableAdapters.EmpresasTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReceitaEquilibrio = new System.Windows.Forms.TextBox();
            this.txtCustoEquilibrio = new System.Windows.Forms.TextBox();
            this.txtEquilibrio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSimulacoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projetoFinalDataSet
            // 
            this.projetoFinalDataSet.DataSetName = "ProjetoFinalDataSet";
            this.projetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultadosBindingSource
            // 
            this.resultadosBindingSource.DataMember = "Resultados";
            this.resultadosBindingSource.DataSource = this.projetoFinalDataSet;
            // 
            // resultadosDataGridView
            // 
            this.resultadosDataGridView.AutoGenerateColumns = false;
            this.resultadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.resultadosDataGridView.DataSource = this.resultadosBindingSource;
            this.resultadosDataGridView.Location = new System.Drawing.Point(2, 74);
            this.resultadosDataGridView.Name = "resultadosDataGridView";
            this.resultadosDataGridView.Size = new System.Drawing.Size(613, 243);
            this.resultadosDataGridView.TabIndex = 1;
            this.resultadosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ResultadosDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Qtde";
            this.dataGridViewTextBoxColumn1.HeaderText = "Qtde";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustoTotal";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustoTotal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TotalVendas";
            this.dataGridViewTextBoxColumn3.HeaderText = "TotalVendas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GanhoPerda";
            this.dataGridViewTextBoxColumn4.HeaderText = "GanhoPerda";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CustoUnit";
            this.dataGridViewTextBoxColumn5.HeaderText = "CustoUnit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // txtCustoFixo
            // 
            this.txtCustoFixo.Location = new System.Drawing.Point(205, 341);
            this.txtCustoFixo.Name = "txtCustoFixo";
            this.txtCustoFixo.Size = new System.Drawing.Size(100, 20);
            this.txtCustoFixo.TabIndex = 2;
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Location = new System.Drawing.Point(205, 393);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUnit.TabIndex = 3;
            // 
            // txtCustoVariacel
            // 
            this.txtCustoVariacel.Location = new System.Drawing.Point(205, 367);
            this.txtCustoVariacel.Name = "txtCustoVariacel";
            this.txtCustoVariacel.Size = new System.Drawing.Size(100, 20);
            this.txtCustoVariacel.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(496, 495);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(98, 41);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // simulacoesTableAdapter1
            // 
            this.simulacoesTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(550, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 28);
            this.panel1.TabIndex = 6;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empresasBindingSource, "EmpresaID", true));
            this.cmbEmpresa.DataSource = this.empresasBindingSource;
            this.cmbEmpresa.DisplayMember = "RazaoSocial";
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(12, 33);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(166, 21);
            this.cmbEmpresa.TabIndex = 7;
            this.cmbEmpresa.ValueMember = "EmpresaID";
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.CmbEmpresa_SelectedIndexChanged);
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.projetoFinalDataSet;
            // 
            // cmbSimulacao
            // 
            this.cmbSimulacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viewSimulacoesBindingSource, "SimulacaoID", true));
            this.cmbSimulacao.DataSource = this.viewSimulacoesBindingSource;
            this.cmbSimulacao.DisplayMember = "SimulacaoID";
            this.cmbSimulacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSimulacao.FormattingEnabled = true;
            this.cmbSimulacao.Location = new System.Drawing.Point(202, 33);
            this.cmbSimulacao.Name = "cmbSimulacao";
            this.cmbSimulacao.Size = new System.Drawing.Size(163, 21);
            this.cmbSimulacao.TabIndex = 8;
            this.cmbSimulacao.ValueMember = "SimulacaoID";
            // 
            // viewSimulacoesBindingSource
            // 
            this.viewSimulacoesBindingSource.DataMember = "ViewSimulacoes";
            this.viewSimulacoesBindingSource.DataSource = this.projetoFinalDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione a empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione o código da simulação:";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(515, 14);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 40);
            this.btnVisualizar.TabIndex = 11;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Legenda: linha de ponto de equilibrio ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Custo fixo total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Custo variável por unidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Preco de venda por unidade";
            // 
            // viewSimulacoesTableAdapter
            // 
            this.viewSimulacoesTableAdapter.ClearBeforeFill = true;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Custo do equilibrio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Receita do equilibrio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Equilibrio:";
            // 
            // txtReceitaEquilibrio
            // 
            this.txtReceitaEquilibrio.Location = new System.Drawing.Point(205, 452);
            this.txtReceitaEquilibrio.Name = "txtReceitaEquilibrio";
            this.txtReceitaEquilibrio.Size = new System.Drawing.Size(100, 20);
            this.txtReceitaEquilibrio.TabIndex = 18;
            // 
            // txtCustoEquilibrio
            // 
            this.txtCustoEquilibrio.Location = new System.Drawing.Point(205, 478);
            this.txtCustoEquilibrio.Name = "txtCustoEquilibrio";
            this.txtCustoEquilibrio.Size = new System.Drawing.Size(100, 20);
            this.txtCustoEquilibrio.TabIndex = 17;
            // 
            // txtEquilibrio
            // 
            this.txtEquilibrio.Location = new System.Drawing.Point(205, 426);
            this.txtEquilibrio.Name = "txtEquilibrio";
            this.txtEquilibrio.Size = new System.Drawing.Size(100, 20);
            this.txtEquilibrio.TabIndex = 16;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 549);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtReceitaEquilibrio);
            this.Controls.Add(this.txtCustoEquilibrio);
            this.Controls.Add(this.txtEquilibrio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSimulacao);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtCustoVariacel);
            this.Controls.Add(this.txtPrecoUnit);
            this.Controls.Add(this.txtCustoFixo);
            this.Controls.Add(this.resultadosDataGridView);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSimulacoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjetoFinalDataSet projetoFinalDataSet;
        private System.Windows.Forms.BindingSource resultadosBindingSource;
        private System.Windows.Forms.DataGridView resultadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtCustoFixo;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.TextBox txtCustoVariacel;
        private System.Windows.Forms.Button btnFechar;
        private ProjetoFinalDataSetTableAdapters.SimulacoesTableAdapter simulacoesTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.ComboBox cmbSimulacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource viewSimulacoesBindingSource;
        private ProjetoFinalDataSetTableAdapters.ViewSimulacoesTableAdapter viewSimulacoesTableAdapter;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private ProjetoFinalDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReceitaEquilibrio;
        private System.Windows.Forms.TextBox txtCustoEquilibrio;
        private System.Windows.Forms.TextBox txtEquilibrio;
    }
}