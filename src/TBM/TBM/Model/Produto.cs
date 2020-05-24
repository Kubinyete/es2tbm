using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Produto
    {
        int _pro_id;
        string _pro_nome;
        int _pro_quantidade;
        int _pro_quantidade_minima;
        UnidadeMedida _unidademedida;
        Marca _marca;
        CategoriaProduto _categoriaProduto;

        public Produto()
        {
        }

        public Produto(int pro_id, string pro_nome,
            int pro_quantidade, int pro_quantidade_minima, 
            UnidadeMedida unidademedida, Marca marca, 
            CategoriaProduto categoriaProduto)
        {
            Pro_id = pro_id;
            Pro_nome = pro_nome;
            Pro_quantidade = pro_quantidade;
            Pro_quantidade_minima = pro_quantidade_minima;
            Unidademedida = unidademedida;
            Marca = marca;
            CategoriaProduto = categoriaProduto;
        }

        public int Pro_id { get => _pro_id; set => _pro_id = value; }
        public string Pro_nome { get => _pro_nome; set => _pro_nome = value; }
        public int Pro_quantidade { get => _pro_quantidade; set => _pro_quantidade = value; }
        public int Pro_quantidade_minima { get => _pro_quantidade_minima; set => _pro_quantidade_minima = value; }
        public UnidadeMedida Unidademedida { get => _unidademedida; set => _unidademedida = value; }
        public Marca Marca { get => _marca; set => _marca = value; }
        public CategoriaProduto CategoriaProduto { get => _categoriaProduto; set => _categoriaProduto = value; }

        public override string ToString()
        {
            return Pro_nome;
        }
    }
}
