using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALMesa:DALBase
    {
        public DALMesa(Persistencia p) : base(p) 
        {
        
        }

        public static Model.Mesa mapearObjeto(DataRow dr)
        {
            return new Model.Mesa(
                dr["mes_id"].ToString(),
                dr["mes_observacoes"].ToString(),
                Convert.ToInt32(dr["mes_capacidade"].ToString()),
                dr["mes_disponivel"].ToString() == "1" ? true : false
                );
        }

        public List<Model.Mesa> obterMesas()
        {
            List<Model.Mesa> ret = new List<Model.Mesa>();

            string sql = "select * from mesa";

            DataTable dt = Db.executarSelect(sql);

            foreach(DataRow row in dt.Rows)
            {
                ret.Add(mapearObjeto(row));
            }

            return ret;
        }
    }
}
