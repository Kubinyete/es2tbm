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
        List<Model.Usuario> usuarios = new List<Model.Usuario>();
        public PesquisarUsuario()
        {
            InitializeComponent();
        }

        private void PesquisarUsuario_Load(object sender, EventArgs e)
        {
            usuarios = bl_usr.carregarUsuarios();
            dgvUsuarios.Rows.Clear();
            control.carregarDgv(usuarios, dgvUsuarios);
            cbFiltros.SelectedIndex = 0;
        }

        private void tbSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPequisa_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            control.carregarDgv(bl_usr.carregarUsuarios(cbFiltros.Text,
                tbSrc.Text), dgvUsuarios);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int index = dgvUsuarios.SelectedRows[0].Index;
            FrmCadastrarUsuario.usu_escolhido = usuarios[index];
            new FrmCadastrarUsuario().ShowDialog();
            FrmCadastrarUsuario.usu_escolhido = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmCadastrarUsuario().ShowDialog();
        }
    }
}
