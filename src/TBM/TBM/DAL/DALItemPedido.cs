using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.BL;

namespace TBM.DAL
{
    public class DALItemPedido : BLBase
    {

        public DALItemPedido(Persistencia p) : base(p)
        {

        }

        public static Model.ItemPedido mapearObjeto(DataRow row)
        {
            return new Model.ItemPedido(
                DAL.DALItemCardapio.mapearObjeto(row),
                null,
                Convert.ToInt32(row["ipe_quantidade"]),
                Convert.ToDouble(row["ipe_valor_unitario"]),
                Convert.ToDouble(row["ipe_valor_subtotal"])
                );
        }

    }
}
