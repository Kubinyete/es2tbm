using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Marca
    {
        int _marca_id;
        string _marca_nome;

        public Marca()
        {
        }

        public Marca(int marca_id, string marca_nome)
        {
            Marca_id = marca_id;
            Marca_nome = marca_nome;
        }

        public string Marca_nome { get => _marca_nome; set => _marca_nome = value; }
        public int Marca_id { get => _marca_id; set => _marca_id = value; }

        public override string ToString()
        {
            return Marca_nome;
        }
    }
}
