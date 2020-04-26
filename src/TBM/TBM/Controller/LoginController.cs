using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Controller
{
    class LoginController
    {
        public LoginController() { }

        public string logar(string username, string senha)
        {
            string ret = "";
            DAL.DALUsuario dal_usr = new DAL.DALUsuario(
                DAL.PersistenciaFactory.criarConexaoPersistencia());
            return ret = dal_usr.Logar(username, senha);
        }
    }
}
