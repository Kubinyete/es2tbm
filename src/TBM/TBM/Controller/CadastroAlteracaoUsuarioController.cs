using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    class CadastroAlteracaoUsuarioController
    {
        public CadastroAlteracaoUsuarioController()
        {

        }

        public void carregarCbFuncionarios(List<Model.Funcionario> funcs, ComboBox cb)
        {
            foreach(Model.Funcionario f in funcs)
            {
                cb.Items.Add(f.Nome);
            }
        }

        public string validarDados(string username,string password,string conf_password,string func)
        {
            if(username!=""&&new BL.BLCadastrarAlterarUsuario(null).validarUsername(username))
            {
                if (password != "" && new BL.BLCadastrarAlterarUsuario(null).validarPassword(password))
                {
                    if (conf_password != "")
                    {
                        if(func == "")
                        {
                            return "Deve-se atribuir a um funcionário!";
                        }
                    }
                    else
                        return "Confirme a senha!";
                }
                else
                {
                    return "Senha muito pequena! a senha deve possuir no mínimo 4 caracteres!";
                }
            }
            else
            {
                return "Username pequeno demais, deve possui no mínimo 3 caracteres!";
            }
            return "OK";
        }

        public bool match_Passwords(string str1,string str2)
        {
            return str1.Equals(str2);
        }

        public void showInfoMessageBox(string sub, string msg)
        {
            MessageBox.Show(sub, msg,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
