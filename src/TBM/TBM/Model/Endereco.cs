using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Endereco
    {
        private int _id;
        private string _logradouro;
        private int _numero;
        private string _observacoes;

        private Bairro _bairro;

        public Endereco(int id, int numero, string logradouro, string observacoes, Bairro bairro)
        {
            Id = id;
            Numero = numero;
            Logradouro = logradouro;
            Observacoes = observacoes;
            Bairro = bairro;
        }

        public Endereco()
        {
            Id = 0;
            Numero = 0;
            Logradouro = String.Empty;
            Observacoes = String.Empty;
            Bairro = null;
        }
        //fiz essa sobrecarga pra facilitar meu insert
        public Endereco(int id)
        {
            Id = id;
            Numero = 0;
            Logradouro = String.Empty;
            Observacoes = String.Empty;
            Bairro = null;
        }

        public int Id { get => _id; set => _id = value; }
        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Observacoes { get => _observacoes; set => _observacoes = value; }
        public Bairro Bairro { get => _bairro; set => _bairro = value; }
        public int Numero { get => _numero; set => _numero = value; }

        public override string ToString()
        {
            return String.Format("{0}, n° {1} - {2} - {3} - {4}", Logradouro, Numero, Bairro.Nome, Bairro.Cidade.Nome, Bairro.Cidade.Estado.Uf);
        }

        public bool Equals(Endereco obj)
        {
            return Id == obj.Id;
        }
    }
}
