using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Pedido
    {
        int _ped_id;
        DateTime _ped_data_efetuado;
        double _ped_valor_total;
        Comanda _pedido_comanda;
        EstadoPedido _pedido_estado;
        int _ped_quantidade;
        ItemPedido _item_pedido;

        public Pedido() { }

        public Pedido(int ped_id, DateTime 
            ped_data_efetuado, double ped_valor_total, 
            Comanda pedido_comanda, EstadoPedido pedido_estado,
            int ped_quantidade, ItemPedido item_pedido)
        {
            _ped_id = ped_id;
            _ped_data_efetuado = ped_data_efetuado;
            _ped_valor_total = ped_valor_total;
            _pedido_comanda = pedido_comanda;
            _pedido_estado = pedido_estado;
            _ped_quantidade = ped_quantidade;
            _item_pedido = item_pedido;
        }

        public int Ped_id { get => _ped_id; set => _ped_id = value; }
        public DateTime Ped_data_efetuado { get => _ped_data_efetuado; set => _ped_data_efetuado = value; }
        public double Ped_valor_total { get => _ped_valor_total; set => _ped_valor_total = value; }
        public Comanda Pedido_comanda { get => _pedido_comanda; set => _pedido_comanda = value; }
        public EstadoPedido Pedido_estado { get => _pedido_estado; set => _pedido_estado = value; }
        public int Ped_quantidade { get => _ped_quantidade; set => _ped_quantidade = value; }
        public ItemPedido Item_pedido { get => _item_pedido; set => _item_pedido = value; }

        public string PedidoPrecoFormatado{
            get { return "R$ " + Ped_valor_total.ToString("N2"); }
        }
    }
}
