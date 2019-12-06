using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Resultados : Form
    {
        private ProjetoFinalDataSet.SimulacoesRow simulacao;
        private Decimal equilibrio;
        private Double receitaEquilibrio;
        private Double custoEquilibrio;

        public Resultados()
        {
            InitializeComponent();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetoFinalDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.projetoFinalDataSet.Empresas);
            // TODO: This line of code loads data into the 'projetoFinalDataSet.ViewSimulacoes' table. You can move, or remove it, as needed.
            this.viewSimulacoesTableAdapter.Fill(this.projetoFinalDataSet.ViewSimulacoes);
            this.simulacoesTableAdapter1.Fill(this.projetoFinalDataSet.Simulacoes);
            cmbSimulacao.DataSource = projetoFinalDataSet.Simulacoes;
        }
        
        private void CmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSimulacao.DataSource = viewSimulacoesTableAdapter.GetDataByEmpresa(cmbEmpresa.SelectedIndex);
        }

        private void carregaGrid()
        {
            simulacao = projetoFinalDataSet.Simulacoes.FindBySimulacaoID(Convert.ToInt32(cmbSimulacao.SelectedValue));

            int inicio = Convert.ToInt32(simulacao.QtdeVendaInicial);
            int fim = Convert.ToInt32(simulacao.QtdeVendaFinal);
            int incremento = Convert.ToInt32(simulacao.IncrementoUnit);

            for (int i = inicio; i <= fim; i = i + incremento)
            {
                ProjetoFinalDataSet.ResultadosRow dr = projetoFinalDataSet.Resultados.NewResultadosRow();

                dr.Qtde = i;
                dr.CustoTotal = simulacao.CustoFixoTotal + (simulacao.CustoVarUnit * dr.Qtde);
                dr.TotalVendas = simulacao.PrecoUnit * dr.Qtde;
                dr.CustoUnit = dr.CustoTotal / dr.Qtde;
                dr.GanhoPerda = dr.TotalVendas - dr.CustoTotal;

                projetoFinalDataSet.Resultados.AddResultadosRow(dr);
            }
            resultadosDataGridView.DataSource = projetoFinalDataSet.Resultados;
            calculaTotalizadores();
            formataCampos();
        }

        private void calculaTotalizadores()
        {
            txtCustoFixo.Text = Convert.ToString(simulacao.CustoFixoTotal);
            txtCustoVariacel.Text = Convert.ToString(simulacao.CustoVarUnit);
            txtPrecoUnit.Text = Convert.ToString(simulacao.PrecoUnit);

            equilibrio = Convert.ToInt32(simulacao.CustoFixoTotal / (simulacao.PrecoUnit - simulacao.CustoVarUnit));
            custoEquilibrio = Convert.ToDouble(simulacao.CustoFixoTotal + (simulacao.CustoVarUnit * equilibrio));
            receitaEquilibrio = Convert.ToDouble(simulacao.PrecoUnit * equilibrio);
        }

        private void ResultadosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals(Convert.ToInt32(equilibrio)))
            {
                resultadosDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            if(cmbSimulacao.SelectedIndex != -1)
            {
                carregaGrid();
            }
            else
            {
                MessageBox.Show("Selecione a simulação!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formataCampos()
        {
            resultadosDataGridView.Columns[1].DefaultCellStyle.Format = "C2";
            resultadosDataGridView.Columns[2].DefaultCellStyle.Format = "C2";
            resultadosDataGridView.Columns[3].DefaultCellStyle.Format = "C2";
            resultadosDataGridView.Columns[4].DefaultCellStyle.Format = "C2";
            txtCustoFixo.Text = Convert.ToDouble(txtCustoFixo.Text).ToString("C2");
            txtCustoVariacel.Text = Convert.ToDouble(txtCustoVariacel.Text).ToString("C2");
            txtPrecoUnit.Text = Convert.ToDouble(txtPrecoUnit.Text).ToString("C2");
            txtEquilibrio.Text = Convert.ToInt32(equilibrio).ToString();
            txtReceitaEquilibrio.Text = Convert.ToDouble(receitaEquilibrio).ToString("C2");
            txtCustoEquilibrio.Text = Convert.ToDouble(custoEquilibrio).ToString("C2");
        }
    }
}
