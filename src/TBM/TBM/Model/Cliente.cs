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

        public Cliente(string cpf, string rg, string nome, DateTime? data_nascimento, Endereco endereco, double divida_acumulada) : base(cpf, rg, nome, data_nascimento, endereco)
        {
            Divida_acumulada = divida_acumulada;
        }

        public Cliente() : base(String.Empty, String.Empty, String.Empty, null, null)
        {
            Divida_acumulada = 0;
        }

        public double Divida_acumulada { get => _divida_acumulada; set => _divida_acumulada = value; }

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
