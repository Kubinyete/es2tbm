using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class CategoriaCardapio
    {
        int _cac_id;
        string _cac_nome;

        public CategoriaCardapio(int cac_id, string cac_nome)
        {
            Cac_id = cac_id;
            Cac_nome = cac_nome;
        }

        public string Cac_nome { get => _cac_nome; set => _cac_nome = value; }
        public int Cac_id { get => _cac_id; set => _cac_id = value; }

        public override string ToString()
        {
            return Cac_nome;
        }
    }
}
