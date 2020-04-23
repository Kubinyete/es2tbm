using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    class Funcionario : PessoaFisica
    {
        private double _salario_atual;
        private Cargo _cargo;

        public Funcionario(double salario_atual,Cargo cargo,string cpf, string rg, string nome,
            DateTime data_nascimento, Endereco endereco)
            : base(cpf, rg, nome, data_nascimento, endereco)
        {
            Salario_atual = salario_atual;
            Cargo = cargo;
        }

        public double Salario_atual { get => _salario_atual; set => _salario_atual = value; }
        internal Cargo Cargo { get => _cargo; set => _cargo = value; }
    }
}
