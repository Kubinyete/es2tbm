using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALEstadoPedido : DALBase
    {
        public DALEstadoPedido(Persistencia p) : base(p)
        {

        }

        public static EstadoPedido mapearObjeto(DataRow dr)
        {
            return new EstadoPedido(
                (int)dr["esp_id"],
                (string)dr["esp_nome"]
            );
        }

        public List<EstadoPedido> obterEstadosPedido()
        {
            List<EstadoPedido> ret = new List<EstadoPedido>();

            Db.abrir();

            DataTable dt = Db.executarSelect("SELECT * FROM estadopedido");

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr)
                );
            }

            Db.fechar();

            return ret;
        }
    }
}
