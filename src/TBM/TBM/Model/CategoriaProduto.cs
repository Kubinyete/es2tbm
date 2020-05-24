using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class CategoriaProduto
    {
        int _cap_id;
        string _cap_nome;

        public CategoriaProduto()
        {
        }

        public CategoriaProduto(int cap_id, string cap_nome)
        {
            Cap_id = cap_id;
            Cap_nome = cap_nome;
        }

        public int Cap_id { get => _cap_id; set => _cap_id = value; }
        public string Cap_nome { get => _cap_nome; set => _cap_nome = value; }

        public override string ToString()
        {
            return Cap_nome;
        }
    }
}
