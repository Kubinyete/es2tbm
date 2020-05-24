using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALProduto : DALBase
    {
        public DALProduto(Persistencia p) : base(p)
        {

        }

        public static Model.Produto mapearObjeto(DataRow row)
        {
            return new Model.Produto(
                Convert.ToInt32(row["pro_id"]),
                row["pro_nome"].ToString(),
                Convert.ToInt32(row["pro_quantidade"]),
                Convert.ToInt32(row["pro_quantidade_minima"]),
                DAL.DALUnidadeMedida.mapearObjeto(row),
                DAL.DALMarca.mapearObjeto(row),
                DAL.DALCategoriaProduto.mapearObjeto(row)
                );
        }

        public List<Model.Produto> obterProdutos(string args = null, 
            string marca = null, 
            string categoria = null, 
            string busca = null)
        {
            List<Model.Produto> produtos = new List<Model.Produto>();
            string sql = "select produto.*, categoriaproduto.*, marca.*," +
"unidademedida.*" +
" from produto " +
"inner join categoriaproduto on categoriaproduto.cap_id = categoriaproduto_cap_id " +
"inner join marca on marca.mar_id = marca_mar_id " +
"inner join unidademedida on unidademedida.uni_id = unidademedida_uni_id ";
            var parametros = criarParametros();

            if (args != null)
            {
                sql += args;
                if (marca != null)
                    parametros.Add("@marca", marca);
                if (categoria != null)
                    parametros.Add("@categoria", categoria);
                if(busca!=null)
                    parametros.Add("busca", String.Format("%{0}%", busca.Replace("%", "%%")));
            }

            try
            {
                DataTable dt = Db.executarSelect(sql, parametros);
                foreach(DataRow row in dt.Rows)
                {
                    produtos.Add(mapearObjeto(row));
                }
                return produtos;
            }catch(MySqlException error)
            {
                throw new Exception("Erro no banco de dados : " + error.Number);
            }
        }
    }
}
