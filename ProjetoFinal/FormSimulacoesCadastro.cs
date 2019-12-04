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
    public partial class FormSimulacoesCadastro : Form
    {
        public FormSimulacoesCadastro()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'projetoFinalDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.projetoFinalDataSet.Empresas);
            // TODO: This line of code loads data into the 'projetoFinalDataSet.Simulacoes' table. You can move, or remove it, as needed.
            this.simulacoesTableAdapter.Fill(this.projetoFinalDataSet.Simulacoes);
        }

        public void Editar(int id)
        {
            simulacoesBindingSource.Position = simulacoesBindingSource.Find("SimulacaoID", id);
        }

        private void SimulacoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.simulacoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoFinalDataSet);

        }

        private void SimulacoesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.simulacoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoFinalDataSet);

        }

        private void FormSimulacoesCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
