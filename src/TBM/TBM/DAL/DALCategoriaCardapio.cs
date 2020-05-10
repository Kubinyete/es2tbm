using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    class DALCategoriaCardapio : DALBase
    {
        public DALCategoriaCardapio(Persistencia p) : base(p)
        {

        }

        public static Model.CategoriaCardapio mapearObjeto(DataRow row)
        {
            return new Model.CategoriaCardapio(
                Convert.ToInt32(row["cac_id"]),
                row["cac_nome"].ToString()
                );
        }

        public List<Model.CategoriaCardapio> obtercategorias()
        {
            List<Model.CategoriaCardapio> ret = new List<Model.CategoriaCardapio>();
            string sql = "select * from categoriacardapio";

            try
            {
                DataTable dt = Db.executarSelect(sql);
                foreach(DataRow rows in dt.Rows)
                {
                    ret.Add(mapearObjeto(rows));
                }
                return ret;
            }catch(MySqlException err)
            {
                throw new BL.Errors.BLValidationError(
                    "Erro no banco de dados:" + err.Number);
            }
        }

    }
}
