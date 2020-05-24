using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALPedido : DALBase
    {
        public DALPedido(Persistencia p) : base(p)
        {

        }

        public static Pedido mapearObjeto(DataRow dr, Comanda c, EstadoPedido ep = null)
        {
            if (c == null)
                throw new NotImplementedException();

            return new Pedido(
                (int)dr["ped_id"],
                (DateTime)dr["ped_data_efetuado"],
                (double)dr["ped_valor_total"],
                c,
                ep != null ? ep : DALEstadoPedido.mapearObjeto(dr)
            );
        }

        public List<Pedido> obterPedidos(Comanda e)
        {
            List<Pedido> ret = new List<Pedido>();

            Db.abrir();

            var param = criarParametros();
            param.Add("cid", e.Com_id);

            DataTable dt = Db.executarSelect("SELECT * FROM pedido INNER JOIN estadopedido ON pedido.estadopedido_esp_id = estadopedido.esp_id WHERE pedido.comanda_com_id = @cid", param);

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr, e)
                );
            }

            Db.fechar();

            return ret;
        }
    }
}
