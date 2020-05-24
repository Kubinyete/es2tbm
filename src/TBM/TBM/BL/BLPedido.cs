using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.DAL;

namespace TBM.BL
{
    public class BLPedido : BLBase
    {
        public BLPedido(Persistencia p) : base(p)
        {

        }

        public void inserirPedido(Model.ItemPedido iped)
        {
            new DAL.DALPedido(Persistencia).inserirPedido(iped);
        }

        public void alterarEstadoPedido(Model.EstadoPedido e_ped,
            Model.Pedido pedido)
        {
            if (pedido.Pedido_estado.Esp_nome == "Pronto para envio")
            {
                throw new Exception("Não é possível cancelar " +
                    "um pedido pronto para envio");
            }

            else if (pedido.Pedido_estado.Esp_nome == "Com o cliente")
            {
                throw new Exception("Não é possível cancelar um pedido que " +
                    "já está com o cliente");
            }

            else if (pedido.Pedido_estado.Esp_nome == "Cancelado")
            {
                throw new Exception("Pedidos cancelados não podem " +
                    "ser cancelados novamente");
            }
            else
            {
                new DAL.DALPedido(Persistencia)
                    .alterarEstadoPedido(e_ped, pedido);
            }
        }
    }
}
