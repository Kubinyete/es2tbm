using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class ItemPedido
    {
        ItemCardapio _item_cardapio;
        Pedido _pedido;
        int _ipe_quantidade;
        double _ipe_valor_unitario; 
        double _ipe_valor_subtotal;

        public ItemPedido(ItemCardapio item_cardapio,
            Pedido pedido, int ipe_quantidade,
            double ipe_valor_unitario, double ipe_valor_subtotal)
        {
            Item_cardapio = item_cardapio;
            Pedido = pedido;
            Ipe_quantidade = ipe_quantidade;
            Ipe_valor_unitario = ipe_valor_unitario;
            Ipe_valor_subtotal = ipe_valor_subtotal;
        }

        public ItemCardapio Item_cardapio { get => _item_cardapio; set => _item_cardapio = value; }
        public Pedido Pedido { get => _pedido; set => _pedido = value; }    
        public int Ipe_quantidade { get => _ipe_quantidade; set => _ipe_quantidade = value; }
        public double Ipe_valor_unitario { get => _ipe_valor_unitario; set => _ipe_valor_unitario = value; }
        public double Ipe_valor_subtotal { get => _ipe_valor_subtotal; set => _ipe_valor_subtotal = value; }

        public override string ToString()
        {
            return Item_cardapio.ToString();
        }
    }
}
