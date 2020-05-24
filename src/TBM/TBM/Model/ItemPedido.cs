using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class ItemPedido
    {
        private int _quantidade;
        private double _valor_unitario;
        private double _valor_subtotal;
        private ItemCardapio _itemCardapio;
        private Pedido _pedido;

        public ItemPedido(int quantidade, double valor_unitario, double valor_subtotal, ItemCardapio itemCardapio, Pedido pedido)
        {
            Quantidade = quantidade;
            Valor_unitario = valor_unitario;
            Valor_subtotal = valor_subtotal;
            ItemCardapio = itemCardapio;
            Pedido = pedido;
        }

        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public double Valor_unitario { get => _valor_unitario; set => _valor_unitario = value; }
        public double Valor_subtotal { get => _valor_subtotal; set => _valor_subtotal = value; }
        public ItemCardapio ItemCardapio { get => _itemCardapio; set => _itemCardapio = value; }
        public Pedido Pedido { get => _pedido; set => _pedido = value; }
    }
}
