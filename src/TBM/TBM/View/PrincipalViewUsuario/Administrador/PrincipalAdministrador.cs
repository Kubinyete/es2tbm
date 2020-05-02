using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.PrincipalViewUsuario.Administrador
{
    public partial class PrincipalAdministrador : Form
    {
        public PrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.Usuarios.PesquisarUsuario().Show();
        }

        private void parametrizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmParametrizacao().Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.Funcionario.PesquisarFuncionario().Show();
        }
    }
}
