using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBM.DAL;
using TBM.Model;

namespace TBM.View
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void parametrizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmParametrizacao().ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Funcionario.PesquisarFuncionario().ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGerenciarClientes().ShowDialog();
        }
    }
}
