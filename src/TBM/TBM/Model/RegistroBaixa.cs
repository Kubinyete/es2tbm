using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class RegistroBaixa
    {
        int _reg_id;
        string _reg_descricao;
        int _reg_quantidade;
        DateTime _data_efetuada;
        Produto _produto;

        public RegistroBaixa(int reg_id,
            string reg_descricao,
            int reg_quantidade,
            DateTime data_efetuada
            , Produto produto)
        {
            Reg_id = reg_id;
            Reg_descricao = reg_descricao;
            Reg_quantidade = reg_quantidade;
            Produto = produto;
            Data_efetuada = data_efetuada;
        }

        public int Reg_id { get => _reg_id; set => _reg_id = value; }
        public string Reg_descricao { get => _reg_descricao; set => _reg_descricao = value; }
        public int Reg_quantidade { get => _reg_quantidade; set => _reg_quantidade = value; }
        public Produto Produto { get => _produto; set => _produto = value; }
        public DateTime Data_efetuada { get => _data_efetuada; set => _data_efetuada = value; }

        public string ProdutoMarca{
            get { return Produto.Marca.Marca_nome; }
        }

        public string ProdutoCategoria{
            get { return Produto.CategoriaProduto.Cap_nome; }
        }

        public string QuantidadeFormatada{
            get { return Reg_quantidade + " " + Produto.Unidademedida.Uni_nome;  }
        }
    }

    public class dataSpan
    {
        DateTime dataInicial;
        DateTime datafinal;

        public dataSpan(DateTime dataInicial, DateTime datafinal)
        {
            this.DataInicial = dataInicial;
            this.Datafinal = datafinal;
        }

        public DateTime DataInicial { get => dataInicial; set => dataInicial = value; }
        public DateTime Datafinal { get => datafinal; set => datafinal = value; }
    }
}
