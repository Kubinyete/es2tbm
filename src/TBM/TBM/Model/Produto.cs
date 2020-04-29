using System;

namespace TBM.Model
{
    public class Produto
    {
        //Atributos
        private int _id;
        private String _nome;
        private int _qtde;
        private int _qtdeMinima;
        private Marca _marca;
        private CategoriaProduto _catProd;
        private UnidadeMedida _uniMedida;

        //Construtores
        public Produto()
        {
            _id = 0;
            _nome = "";
            _qtde = 0;
            _qtdeMinima = 0;
            _marca = null;
            _catProd = null;
            _uniMedida = null;
        }

        public Produto(int id, String nome, int qtde, int qtdeMinima, Marca marca, CategoriaProduto catProd, UnidadeMedida unidadeMedida)
        {
            _id = id;
            _nome = nome;
            _qtde = qtde;
            _qtdeMinima = qtdeMinima;
            _marca = marca;
            _catProd = catProd;
            _uniMedida = unidadeMedida;
        }

        //Get's e Set's
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Qtde { get => _qtde; set => _qtde = value; }
        public int QtdeMinima { get => _qtdeMinima; set => _qtdeMinima = value; }
        public Marca Marca { get => _marca; set => _marca = value; }
        public CategoriaProduto CatProd { get => _catProd; set => _catProd = value; }
        public UnidadeMedida UniMedida { get => _uniMedida; set => _uniMedida = value; }
    }
}