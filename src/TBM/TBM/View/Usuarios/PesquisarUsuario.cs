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
    public partial class PesquisarUsuario : Form
    {
        Controller.UsuarioController control = new Controller.UsuarioController();
        BL.BLUsuario bl_usr = new BL.BLUsuario(null);
        public PesquisarUsuario()
        {
            InitializeComponent();
        }

        private void PesquisarUsuario_Load(object sender, EventArgs e)
        {
            control.carregarDgv(bl_usr.carregarUsuarios(), dgvUsuarios);
        }

        private void tbSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPequisa_Click(object sender, EventArgs e)
        {
            if (bl_usr.validarSrc(tbSrc.Text.Length))
            {
                dgvUsuarios.Rows.Clear();
                control.carregarDgv(bl_usr.carregarUsuarios(cbFiltros.SelectedIndex.ToString(),
                    tbSrc.Text), dgvUsuarios);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
