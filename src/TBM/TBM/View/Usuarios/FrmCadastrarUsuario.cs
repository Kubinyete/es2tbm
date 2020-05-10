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
       private BL.BLCadastrarAlterarUsuario bl_cadalt = new BL.BLCadastrarAlterarUsuario(null);
        private Controller.CadastroAlteracaoUsuarioController cadalt_usr =
            new Controller.CadastroAlteracaoUsuarioController();
        private List<Model.Funcionario> f = new List<Model.Funcionario>();

        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            f = bl_cadalt.obterFuncionariosSemUser();
            cadalt_usr.carregarCbFuncionarios(f, cbFuncionario);
            if(usu_escolhido == null)
            {
                lblTitulo.Text = "Cadastro de Usuário";
                this.Text = "Cadastro de Usuários";
                if(f.Count > 0)
                    cbFuncionario.SelectedIndex = 0;
                else
                    cbFuncionario.SelectedIndex = -1;
                this.Text = "Cadastrar Usuário";
            }
            else
            {
                lblTitulo.Text = "Atualizar Usuário";
                tbUsername.Text = usu_escolhido.Username;
                tbUsername.Enabled = false;
                cbFuncionario.Items.Add(usu_escolhido.Funcionario.Nome);
                f.Add(usu_escolhido.Funcionario);
                cbFuncionario.SelectedIndex = 0;
                cbFuncionario.Enabled = false;
                this.Text = "Atualizar Usuário";
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string msg = cadalt_usr.validarDados(tbUsername.Text, tbPassword.Text, tbConfirmarPassword.Text,
                cbFuncionario.Text);
            if (msg == "OK")
            {
                if (cadalt_usr.match_Passwords(tbPassword.Text, tbConfirmarPassword.Text))
                {
                    Model.Usuario usr = new Model.Usuario(
                        tbUsername.Text.Trim().ToUpper(),
                        tbPassword.Text.Trim().ToLower(),
                        true,
                        f[cbFuncionario.SelectedIndex]
                    );
                    if (usu_escolhido == null)
                        msg = bl_cadalt.cadastrarUsuario(usr);
                    else
                        msg = bl_cadalt.alterarUsuario(usr);
                    if(msg == "OK")
                    {
                        cadalt_usr.showInfoMessageBox(msg, "Aviso");
                    }
                    this.Close();
                }
                else
                {
                    cadalt_usr.showInfoMessageBox("As senhas não batem!", "Aviso");
                }
            }
            else
                cadalt_usr.showInfoMessageBox(msg, "Aviso");
        }
    }
}
