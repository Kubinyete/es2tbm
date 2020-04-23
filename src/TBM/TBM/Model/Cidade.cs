using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Cidade
    {
        private int _id;
        private string _nome;

        private Estado _estado;

        public Cidade(int id, string nome, Estado estado)
        {
            Id = id;
            Nome = nome;
            Estado = estado;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal Estado Estado { get => _estado; set => _estado = value; }
    }
}
