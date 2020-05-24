using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class ItemCardapio
    {
        int _itc_id;
        string _itc_nome;
        double _itc_preco;
        string _itc_descricao;
        bool _itc_disponivel;
        CategoriaCardapio _cac;

        public ItemCardapio()
        {
        }

        public ItemCardapio(int itc_id, string itc_nome, double itc_preco, string itc_descricao, bool itc_disponivel, CategoriaCardapio cac)
        {
            Itc_id = itc_id;
            Itc_nome = itc_nome;
            Itc_preco = itc_preco;
            Itc_descricao = itc_descricao;
            Itc_disponivel = itc_disponivel;
            Cac = cac;
        }

        public int Itc_id { get => _itc_id; set => _itc_id = value; }
        public string Itc_nome { get => _itc_nome; set => _itc_nome = value; }
        public double Itc_preco { get => _itc_preco; set => _itc_preco = value; }
        public string Itc_descricao { get => _itc_descricao; set => _itc_descricao = value; }
        public bool Itc_disponivel { get => _itc_disponivel; set => _itc_disponivel = value; }
        public CategoriaCardapio Cac { get => _cac; set => _cac = value; }

        public override string ToString()
        {
            return Itc_nome;
        }
    }
}
