using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;
using TBM.BL.Errors;
using TBM.Uteis;
using TBM.DAL;

namespace TBM.BL
{
    public class BLItemPedido: BLBase
    {
        private void verificarConsistencia(Pedido p)
        {

        }

        public List<ItemPedido> obterItemsPedido(Comanda c)
        {
            List<ItemPedido> ret = new List<ItemPedido>();

            var di = new DALItemPedido(Persistencia);

            foreach (var p in new DALPedido(Persistencia).obterPedidos(c))
            {
                foreach (var i in di.obterItemsPedido(p))
                {
                    ret.Add(i);
                }
            }

            return ret;
        }
    }
}
