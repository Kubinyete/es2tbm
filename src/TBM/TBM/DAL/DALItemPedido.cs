using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALItemPedido : DALBase
    {
        public DALItemPedido(Persistencia p) : base(p)
        {

        }

        public static ItemPedido mapearObjeto(DataRow dr, Pedido p, ItemCardapio i = null)
        {
            if (p == null)
                throw new NotImplementedException();

            return new ItemPedido(
                (int)dr["ipe_quantidade"],
                (double)dr["ipe_valor_unitario"],
                (double)dr["ipe_valor_subtotal"],
                i != null ? i : DALItemCardapio.mapearObjeto(dr),
                p
            );
        }

        public List<ItemPedido> obterItemsPedido(Pedido e)
        {
            List<ItemPedido> ret = new List<ItemPedido>();

            Db.abrir();

            var param = criarParametros();
            param.Add("pid", e.Id);

            DataTable dt = Db.executarSelect("SELECT * FROM itempedido INNER JOIN itemcardapio ON itempedido.itemcardapio_itc_id = itemcardapio.itc_id INNER JOIN categoriacardapio ON itemcardapio.categoriacardapio_cac_id = categoriacardapio.cac_id WHERE itempedido.pedido_ped_id = @pid", param);

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
