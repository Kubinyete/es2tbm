using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALRegistroBaixa : DALBase
    {
        public DALRegistroBaixa(Persistencia p) : base(p)
        {

        }

        public Model.RegistroBaixa mapearObjeto(DataRow row)
        {
            return new Model.RegistroBaixa(
                Convert.ToInt32(row["reg_id"]),
                row["reg_descricao"].ToString(),
                Convert.ToInt32(row["reg_quantidade"]),
                Convert.ToDateTime(row["reg_data_efetuado"]),
                DAL.DALProduto.mapearObjeto(row)
                );
        }

        public void inserirBaixa(Model.RegistroBaixa rb)
        {
            string sql = "insert into registrobaixa(reg_descricao, reg_quantidade," +
                " produto_pro_id, reg_data_efetuado)" +
                "values(@regDescricao,@regQuantidade,@proId,@proDataEfetuado);";
            var parametros = criarParametros();
            parametros.Add("@regDescricao", rb.Reg_descricao);
            parametros.Add("@regQuantidade", rb.Reg_quantidade);
            parametros.Add("@proId", rb.Produto.Pro_id);
            parametros.Add("@proDataEfetuado", rb.Data_efetuada);

            try
            {
                Db.executarNonQuery(sql, parametros); 
            }catch(MySqlException erro)
            {
                throw new Exception("Erro no banco de dados : "+erro.Number);
            }
        }

        public List<Model.RegistroBaixa> obterRegistroBaixas(string args = null, 
            string marca = null, 
            string categoria = null, 
            Model.dataSpan dataSpan = null,
            string busca = null)
        {
            List<Model.RegistroBaixa> ret = new List<Model.RegistroBaixa>();

            string sql = "select registrobaixa.*,produto.*, " +
                "categoriaproduto.*, marca.*," +
"unidademedida.* " +
" from registrobaixa " +
"inner join produto on produto.pro_id = produto_pro_id " +
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

                if (busca != null)
                    parametros.Add("busca", String.Format("%{0}%", busca.Replace("%", "%%")));

                if (dataSpan != null)
                {
                    parametros.Add("@data_ini", dataSpan.DataInicial);
                    parametros.Add("@data_fim", dataSpan.Datafinal);
                }
            }

            try
            {
                DataTable dt = Db.executarSelect(sql, parametros);
                foreach(DataRow rows in dt.Rows)
                {
                    ret.Add(mapearObjeto(rows)); 
                }
                return ret;
            }catch(MySqlException error)
            {
                throw new Exception("Erro no banco de dados : " + error.Number);
            }
        }

        public void removerBaixa(Model.RegistroBaixa regBaixa)
        {
            string sql = "DELETE from registrobaixa where reg_id=@id";

            var parametros = criarParametros();
            parametros.Add("@id", regBaixa.Reg_id);

            try
            {
                Db.executarNonQuery(sql, parametros);
            }
            catch (MySqlException error)
            {
                throw new Exception("Erro no banco de dados : " + error.Number);
            }
        }

    }
}
