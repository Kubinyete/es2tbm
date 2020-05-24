using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class EstadoPedido
    {
        private int _id;
        private string _nome;

        public EstadoPedido(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public override string ToString()
        {
            return Nome;
        }
    }
}