using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.Usuarios
{
    public partial class FrmCadastrarUsuario : Form
    {
        public static Model.Usuario usu_escolhido = null;
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
