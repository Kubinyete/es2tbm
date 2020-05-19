using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALEstadoPedido : DALBase
    {

        public DALEstadoPedido(Persistencia p) : base(p)
        {

        }

        public static Model.EstadoPedido mapearObjeto(DataRow row)
        {
            return new Model.EstadoPedido(
                Convert.ToInt32(row["esp_id"]),
                row["esp_nome"].ToString()
                );
        }

    }
}
