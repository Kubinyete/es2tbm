using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class PessoaFisica
    {
        private string _cpf;
        private string _rg;
        private string _nome;
        private DateTime _data_nascimento;
        private Endereco _endereco;

        public PessoaFisica(string cpf, string rg, string nome, DateTime data_nascimento, Endereco endereco)
        {
            Cpf = cpf;
            Rg = rg;
            Nome = nome;
            Data_nascimento = data_nascimento;
            Endereco = endereco;
        }

        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public DateTime Data_nascimento { get => _data_nascimento; set => _data_nascimento = value; }
        public Endereco Endereco { get => _endereco; set => _endereco = value; }
    }
}
