using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.UserAdm
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.Usuarios.FrmCadastrarUsuario().Show();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}
