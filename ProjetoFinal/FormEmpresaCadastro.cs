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
    public partial class FormEmpresaCadastro : Form
    {
        public FormEmpresaCadastro()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'projetoFinalDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.projetoFinalDataSet.Empresas);
        }

        public void Editar(int id)
        {
            empresasBindingSource.Position = empresasBindingSource.Find("EmpresaID", id);
        }

        private void EmpresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoFinalDataSet);

        }

        private void FormEmpresaCadastro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
