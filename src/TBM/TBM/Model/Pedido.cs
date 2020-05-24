using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Pedido
    {
        private int _id;
        private DateTime _data_efetuado;
        private double _valor_total;
        private Comanda _comanda;
        private EstadoPedido _estadoPedido;

        public Pedido(int id, DateTime data_efetuado, double valor_total, Comanda comanda, EstadoPedido estadoPedido)
        {
            Id = id;
            Data_efetuado = data_efetuado;
            Valor_total = valor_total;
            Comanda = comanda;
            EstadoPedido = estadoPedido;
        }

        public int Id { get => _id; set => _id = value; }
        public DateTime Data_efetuado { get => _data_efetuado; set => _data_efetuado = value; }
        public double Valor_total { get => _valor_total; set => _valor_total = value; }
        public Comanda Comanda { get => _comanda; set => _comanda = value; }
        public EstadoPedido EstadoPedido { get => _estadoPedido; set => _estadoPedido = value; }
    }
}