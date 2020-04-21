using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    class Endereco
    {
        private int _id;
        private string _logradouro;
        private string _observacoes;

        private Bairro _bairro;

        public Endereco(int id, string logradouro, string observacoes, Bairro bairro)
        {
            Id = id;
            Logradouro = logradouro;
            Observacoes = observacoes;
            Bairro = bairro;
        }

        public int Id { get => _id; set => _id = value; }
        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Observacoes { get => _observacoes; set => _observacoes = value; }
        public Bairro Bairro { get => _bairro; set => _bairro = value; }
    }
}
