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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void MenusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEmpresa().Show();
        }

        private void DadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSimulacoes().ShowDialog();
        }
    }
}
