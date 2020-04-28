using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    class LoginController
    {
        public LoginController() { }

        public string logar(string username, string senha)
        {
            DAL.DALUsuario dal_usr = new DAL.DALUsuario(
                DAL.PersistenciaFactory.criarConexaoPersistencia());
            return dal_usr.Logar(username, senha);
        }

        public Model.Usuario obterUsuario(string username)
        {
            return new DAL.DALUsuario(DAL.PersistenciaFactory.criarConexaoPersistencia()).obterUsuario(username, null);
        }

        public string validarDados(string username, string password)
        {
            if (username != null && username != "")
            {
                if (password != null && password != "")
                {
                    return "OK";
                }
                else
                {
                    return "A senha deve ser informada!"; 
                }
            }
            else
            {
                return "O usuário deve ser informado";
            }
        }

        public void redirectUser(Model.Usuario u)
        {
            if (u.Funcionario.Cargo.Nome.Equals("Administrador"))
            {
                if (u.Username == "ADMUSER")
                {
                    new View.UserAdm.principal().ShowDialog();
                    string msg = excluirUsuarioAdm();
                    if (msg == "OK")
                        exibirMessageBoxAsterisk("Feito!", "Aviso");
                    else
                        exibirMessageBoxError("erro!", "Aviso");
                }else
                    new View.PrincipalViewUsuario.Administrador.PrincipalAdministrador().Show();
            }
            if (u.Funcionario.Cargo.Nome.Equals("SYSADM"))
            {
                new View.PrincipalViewUsuario.Administrador.PrincipalAdministrador().Show();
            }
            else
                new View.PrincipalViewUsuario.Outros.Outros().Show();
        }

        public string excluirUsuarioAdm()
        {
            return new DAL.DALUsuario(DAL.PersistenciaFactory.criarConexaoPersistencia()).deletarAdmUser();
        }

        public void exibirMessageBoxAsterisk(string msg, string sub)
        {
            MessageBox.Show(msg, sub,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void exibirMessageBoxError(string msg, string sub)
        {
            MessageBox.Show(msg, sub,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
