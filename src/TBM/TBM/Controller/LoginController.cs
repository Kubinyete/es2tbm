using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    public class LoginController
    {
        public static Form ret = null;
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
            switch (u.Funcionario.Cargo.Nome) 
            {
                case "ADMSYS":
                    ret = new View.PrincipalViewUsuario.Administrador.PrincipalAdministrador();
                break;
                case "DEVSYS":
                    ret = new View.PrincipalViewUsuario.Desenvolvimento.desenvolvedor();
                break;
                case "TBM":
                    ret = new View.UserAdm.principal();
                break;
                case "Administrador":
                    ret = new View.PrincipalViewUsuario.Administrador.PrincipalAdministrador();
                break;
                default:
                    ret = new View.PrincipalViewUsuario.Outros.Outros();
                break;
            }
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
