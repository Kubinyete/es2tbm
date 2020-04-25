using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Estado
    {
        private string _uf;
        private string _nome;

        public Estado(string uf, string nome)
        {
            Uf = uf;
            Nome = nome;
        }

        public string Uf { get => _uf; set => _uf = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public override string ToString()
        {
            return Uf;
        }
    }
}
