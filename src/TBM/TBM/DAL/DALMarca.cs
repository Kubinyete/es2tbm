using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALMarca : DALBase
    {
        public DALMarca(Persistencia p) : base(p)
        {

        }

        public static Model.Marca mapearObjeto(DataRow row)
        {
            return new Model.Marca(
                Convert.ToInt32(row["mar_id"]),
                row["mar_nome"].ToString()
                );
        }

        public List<Model.Marca> obterMarcas()
        {
            List<Model.Marca> marcas =
                new List<Model.Marca>();
            string sql = "select * from marca";
            try
            {
                DataTable dt = Db.executarSelect(sql);
                foreach (DataRow row in dt.Rows)
                {
                    marcas.Add(mapearObjeto(row));
                }
                return marcas;
            }
            catch (MySqlException error)
            {
                throw new Exception("Erro no banco de dados:"
                    + error.Number);
            }

        }
    }
}
