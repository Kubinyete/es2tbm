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
            if (tbUsername.Text != null && tbUsername.Text != "")
            {
                if(tbPassword.Text !=null && tbPassword.Text != "")
                {
                    Controller.LoginController con_log = 
                        new Controller.LoginController();
                    string msg = con_log.logar(tbUsername.Text, tbPassword.Text); 
                    if(msg.Equals("OK"))
                    {
                        MessageBox.Show(this, "Você logou no sistema!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show(this, msg, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show(this, "A senha deve ser informada", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show(this, "O usuário deve ser informado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
