using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.DAL;

namespace TBM.BL
{
    class BLCadastrarAlterarUsuario : BLBase
    {
        public BLCadastrarAlterarUsuario(Persistencia p) : base(p){}
        
        public List<Model.Funcionario> obterFuncionariosSemUser()
        {
            return new DAL.DALFuncionario(Persistencia).obterFuncionariosSemUsuario();
        }

        public bool validarUsername(string username)
        {
            return username.Length > 3;
        }

        public bool validarPassword(string password)
        {
            return password.Length > 4;
        }

        public string cadastrarUsuario(Model.Usuario user)
        {
            return new DALUsuario(Persistencia).cadastrarUsuario(user);
        }

        public string alterarUsuario(Model.Usuario user)
        {
            return new DALUsuario(Persistencia).alterarSenha(user);
        }

        public string excluirUsuario(Model.Usuario user)
        {
            return new DAL.DALUsuario(Persistencia).atualizarEstadoUsuario(user, 0);

        }
    }
}
