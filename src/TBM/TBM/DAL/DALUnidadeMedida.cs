using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALUnidadeMedida : DALBase
    {
        public DALUnidadeMedida(Persistencia p) : base(p)
        {

        }

        public static Model.UnidadeMedida mapearObjeto(DataRow row)
        {
            return new Model.UnidadeMedida(
                Convert.ToInt32(row["uni_id"]),
                row["uni_nome"].ToString(),
                row["uni_nome"].ToString()
                );
        }
    }
}
