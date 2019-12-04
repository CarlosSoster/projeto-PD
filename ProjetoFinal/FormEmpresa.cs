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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // TODO: This line of code loads data into the 'projetoFinalDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.projetoFinalDataSet.Empresas);
        }

        private void EmpresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoFinalDataSet);

        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void EmpresasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new FormEmpresaCadastro();
            form.ShowDialog();
            AtualizaGrid();
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            var form = new FormEmpresaCadastro();
            var empresa = projetoFinalDataSet.Empresas[empresasBindingSource.Position];
            form.Editar(empresa.EmpresaID);
            form.ShowDialog();
            AtualizaGrid();
        }
    }
}
