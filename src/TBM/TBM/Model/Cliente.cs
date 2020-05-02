using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Cliente : PessoaFisica
    {
        private double _divida_acumulada;
        private bool _ativado;
        private string _email;
        private string _telefone;

        public Cliente(string cpf, string rg, string nome, DateTime? data_nascimento, Endereco endereco, double divida_acumulada, bool ativado, string email, string telefone) : base(cpf, rg, nome, data_nascimento, endereco)
        {
            Divida_acumulada = divida_acumulada;
            Ativado = ativado;
            Email = email;
            Telefone = telefone;
        }

        public Cliente() : base(String.Empty, String.Empty, String.Empty, null, null)
        {
            Divida_acumulada = 0;
            Ativado = true;
            Email = String.Empty;
            Telefone = String.Empty;
        }

        public double Divida_acumulada { get => _divida_acumulada; set => _divida_acumulada = value; }
        public bool Ativado { get => _ativado; set => _ativado = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }

        public override string ToString()
        {
            return Nome;
        }

        public bool Equals(Cliente obj)
        {
            return Cpf == obj.Cpf;
        }
    }
}
