using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    class DALItemCardapio : DALBase
    {
        public DALItemCardapio(Persistencia p) : base(p) 
        {
            
        }

        public static Model.ItemCardapio mapearObjeto(DataRow row)
        {
            return new Model.ItemCardapio(
                Convert.ToInt32(row["itc_id"]),
                row["itc_nome"].ToString(),
                Convert.ToDouble(row["itc_preco"]),
                row["itc_descricao"].ToString(),
                row["itc_disponivel"].ToString() == "1" ? true : false,
                DALCategoriaCardapio.mapearObjeto(row)
                );
        }

        public List<Model.ItemCardapio> obterItems(int cat_id)
        {
            List<Model.ItemCardapio> itens = new List<Model.ItemCardapio>();

            string sql = "select itemcardapio.*, categoriacardapio.*" +
"from itemcardapio " +
"inner join categoriacardapio on " +
"categoriacardapio.cac_id = itemcardapio.categoriacardapio_cac_id " +
"where cac_id = @id; ";

            var parametros = criarParametros();
            parametros.Add("@id", cat_id);

            try
            {
                DataTable dt = Db.executarSelect(sql, parametros);
                foreach(DataRow row in dt.Rows)
                {
                    itens.Add(mapearObjeto(row));
                }
                return itens;
            }
            catch(MySqlException e)
            {
                throw new BL.Errors.BLValidationError("Erro no banco " +
                    "de dados:" + e.Number);
            }
        }
    }
}
