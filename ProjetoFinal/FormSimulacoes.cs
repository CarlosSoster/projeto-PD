using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class FormSimulacoes : Form
    {
        public FormSimulacoes()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // TODO: This line of code loads data into the 'projetoFinalDataSet.ViewSimulacoes' table. You can move, or remove it, as needed.
            this.viewSimulacoesTableAdapter.Fill(this.projetoFinalDataSet.ViewSimulacoes);
            // TODO: This line of code loads data into the 'projetoFinalDataSet.Simulacoes' table. You can move, or remove it, as needed.
            this.simulacoesTableAdapter.Fill(this.projetoFinalDataSet.Simulacoes);
        }

        private void SimulacoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.simulacoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoFinalDataSet);

        }

        private void FormSimulacoes_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new FormSimulacoesCadastro();
            form.ShowDialog();
            AtualizaGrid();
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            var form = new FormSimulacoesCadastro();
            var simulacao = projetoFinalDataSet.Simulacoes[viewSimulacoesBindingSource.Position];
            form.Editar(simulacao.SimulacaoID);
            form.ShowDialog();
            AtualizaGrid();
        }
    }
}
