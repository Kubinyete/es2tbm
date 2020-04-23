using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    class Usuario
    {
        private string _username;
        private string _password;
        private bool _ativado;
        private Funcionario _funcionario;

        public Usuario(string username, string password, bool ativado, Funcionario funcionario)
        {
            Username = username;
            Password = password;
            Ativado = ativado;
            Funcionario = funcionario;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public bool Ativado { get => _ativado; set => _ativado = value; }
        internal Funcionario Funcionario { get => _funcionario; set => _funcionario = value; }
    }
}
