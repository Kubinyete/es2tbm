using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Funcionario : PessoaFisica
    {
        private double _salario_atual;
        private Cargo _cargo;
        private string _email;
        private string _telefone;

        public Funcionario(double salario_atual,Cargo cargo,string email,string telefone,string cpf, string rg, string nome,
            DateTime data_nascimento, Endereco endereco)
            : base(cpf, rg, nome, data_nascimento, endereco)
        {
            Salario_atual = salario_atual;
            Email = email;
            Telefone = telefone;
            Cargo = cargo;
        }

        public double Salario_atual { get => _salario_atual; set => _salario_atual = value; }
        public Cargo Cargo { get => _cargo; set => _cargo = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
