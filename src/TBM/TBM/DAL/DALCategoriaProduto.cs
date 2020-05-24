using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALCategoriaProduto : DALBase
    {
        public DALCategoriaProduto(Persistencia p) : base(p)
        {

        }

        public static Model.CategoriaProduto mapearObjeto(DataRow row)
        {
            return new Model.CategoriaProduto(
                Convert.ToInt32(row["cap_id"]),
                row["cap_nome"].ToString()
                );
        }

        public List<Model.CategoriaProduto> obterCategoriasDeProduto()
        {
            List<Model.CategoriaProduto> categoriasProduto =
                new List<Model.CategoriaProduto>();
            string sql = "select * from categoriaproduto";
            try
            {
                DataTable dt = Db.executarSelect(sql);
                foreach(DataRow row in dt.Rows)
                {
                    categoriasProduto.Add(mapearObjeto(row));
                }
                return categoriasProduto;
            }catch(MySqlException error)
            {
                throw new Exception("Erro no banco de dados:" 
                    + error.Number);
            }

        }

    }
}
