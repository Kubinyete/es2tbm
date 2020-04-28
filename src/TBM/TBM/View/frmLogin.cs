using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View
{
    public partial class frmLogin : Form
    {
        private Controller.LoginController ctr_login = new Controller.LoginController();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string msg = ctr_login.validarDados(tbPassword.Text, tbUsername.Text);
            if(msg == "OK")
            {
                msg = ctr_login.logar(tbUsername.Text, tbPassword.Text); 
                if(msg == "OK")
                {
                    this.Close();
                    Model.Usuario u = ctr_login.obterUsuario(tbUsername.Text);
                    ctr_login.redirectUser(u);

                }else
                    ctr_login.exibirMessageBoxAsterisk(msg, "Aviso");
            }
            else
            {
                ctr_login.exibirMessageBoxAsterisk(msg, "Aviso");
            }
        }
    }
}
