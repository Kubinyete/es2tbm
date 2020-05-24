using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public class DALComanda : DALBase
    {
        public DALComanda(Persistencia p) : base(p)
        {

        }


        public static Model.Comanda mapearObjeto(DataRow dr)
        {
            return new Model.Comanda(
                Convert.ToInt32(dr["com_id"]),
                dr["com_apelido"].ToString(),
                dr["com_observacoes"].ToString(),
                Convert.ToDouble(dr["com_valor_total"]),
                DAL.DALFuncionario.mapearObjeto(dr, null, null),
                null,
                DAL.DALMesa.mapearObjeto(dr),
                Convert.ToDateTime(dr["com_data_abertura"].ToString())
            );
        }

        public void cadastrarComanda(Model.Comanda c)
        {
            string sql = "INSERT INTO `comanda` " +
                "(`com_apelido`, `com_valor_total`, `funcionario_pessoafisica_pes_cpf`" +
                ", `mesa_mes_id`)" +
                "VALUES (@comanda_apelido, @com_valor," +
                " @funcionario_cpf, @mesa_id);";

            var parametros = criarParametros();
            parametros.Add("@comanda_apelido", c.Com_apelido);
            parametros.Add("@com_valor", c.Com_valor_total);
            parametros.Add("@funcionario_cpf", c.Funcionario.Cpf);
            parametros.Add("@mesa_id", c.Mesa.Mes_id);

            try
            {
                int lc = Db.executarNonQuery(sql,parametros);
            }catch(MySqlException e)
            {
                if (e.Number == 1452)
                    throw new BL.Errors.BLValidationError("Mesa não existente");
                else
                    throw new BL.Errors.BLValidationError("Erro no banco de dados :" + e.Number);
            }

        }

        #region OBTER COMANDAS
//        public List<Model.Comanda> obterComandas(int numMesa, string garcomNome,
//            string args=null, string busca = null)
//        {
//            List<Model.Comanda> ret = new List<Model.Comanda>();

//            string sql = "select comanda.*, funcionario.*, pessoafisica.*," +
//                " endereco.*, bairro.*, mesa.*, cargo.*, cidade.*, estado.* "+
//"from comanda "+
//"inner join mesa on mesa.mes_id = comanda.mesa_mes_id "+
//"inner join funcionario on funcionario.pessoafisica_pes_cpf = comanda.funcionario_pessoafisica_pes_cpf "+
//"inner join cargo on cargo.car_id = funcionario.cargo_car_id "+
//"inner join pessoafisica on pessoafisica.pes_cpf = funcionario.pessoafisica_pes_cpf "+
//"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id "+
//"inner join bairro on bairro.bai_id = endereco.bairro_bai_id "+
//"inner join cidade on cidade.cid_id = bairro.bai_id " +
//"inner join estado on estado.est_uf = cidade.estado_est_uf "+
//"where mesa.mes_id = @mesid and pessoafisica.pes_nome = @nome";

//            var parametros = criarParametros();
//            parametros.Add("@mesid", numMesa);
//            parametros.Add("@nome", garcomNome);
//            if (args != null)
//            {
//                sql += args;
//                parametros.Add("busca", String.Format("%{0}%", busca.Replace("%", "%%")));
//            }

//            try
//            {
//                DataTable dt = Db.executarSelect(sql, parametros); 
//                foreach(DataRow row in dt.Rows)
//                {
//                    ret.Add(mapearObjeto(row));
//                }
//                return ret;
//            }catch(MySqlException err)
//            {
//                throw new BL.Errors.BLValidationError(
//                    "Erro no banco de dados : " + err.Number);
//            }
//        }

//    //caso eu queira buscar sem os filtros
//        public List<Model.Comanda> obterComandas(string args=null, string busca = null)
//        {
//            List<Model.Comanda> ret = new List<Model.Comanda>();

//            string sql = "select comanda.*, funcionario.*, pessoafisica.*," +
//                " endereco.*, bairro.*, mesa.*, cargo.*, cidade.*, estado.* " +
//"from comanda " +
//"inner join mesa on mesa.mes_id = comanda.mesa_mes_id " +
//"inner join funcionario on funcionario.pessoafisica_pes_cpf = comanda.funcionario_pessoafisica_pes_cpf " +
//"inner join cargo on cargo.car_id = funcionario.cargo_car_id " +
//"inner join pessoafisica on pessoafisica.pes_cpf = funcionario.pessoafisica_pes_cpf " +
//"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id " +
//"inner join bairro on bairro.bai_id = endereco.bairro_bai_id " +
//"inner join cidade on cidade.cid_id = bairro.bai_id " +
//"inner join estado on estado.est_uf = cidade.estado_est_uf ";

//            var parametros = criarParametros();

//            if (args!=null)
//            {
//                sql += args;
//                parametros.Add("busca", String.Format("%{0}%", busca.Replace("%", "%%")));
//            }

//            try
//            {
//                DataTable dt = Db.executarSelect(sql,parametros);
//                foreach (DataRow row in dt.Rows)
//                {
//                    ret.Add(mapearObjeto(row));
//                }
//                return ret;
//            }
//            catch (MySqlException err)
//            {
//                throw new BL.Errors.BLValidationError(
//                    "Erro no banco de dados : " + err.Number);
//            }
//        }

        #endregion

        public List<Model.Comanda> obterComandas(string args = null, 
            string busca = null, 
            string numMesa = null, 
            string nomeGarcom = null)
        {
            List<Model.Comanda> ret = new List<Model.Comanda>();

            string sql = "select comanda.*, funcionario.*, pessoafisica.*," +
                " endereco.*, bairro.*, mesa.*, cargo.*, cidade.*, estado.* " +
"from comanda " +
"inner join mesa on mesa.mes_id = comanda.mesa_mes_id " +
"inner join funcionario on funcionario.pessoafisica_pes_cpf = comanda.funcionario_pessoafisica_pes_cpf " +
"inner join cargo on cargo.car_id = funcionario.cargo_car_id " +
"inner join pessoafisica on pessoafisica.pes_cpf = funcionario.pessoafisica_pes_cpf " +
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id " +
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id " +
"inner join cidade on cidade.cid_id = bairro.bai_id " +
"inner join estado on estado.est_uf = cidade.estado_est_uf ";

            var parametros = criarParametros();

            if (args != null)
            {
                sql += args; 
                if(busca!=null) 
                    parametros.Add("busca", String.Format("%{0}%", busca.Replace("%", "%%")));
                if(numMesa!=null)
                    parametros.Add("@mesid", numMesa);
                if(nomeGarcom!=null)
                    parametros.Add("@nome", nomeGarcom);
            }

            try
            {
                DataTable dt = Db.executarSelect(sql, parametros);
                foreach (DataRow row in dt.Rows)
                {
                    ret.Add(mapearObjeto(row));
                }
                return ret;
            }
            catch (MySqlException err)
            {
                throw new BL.Errors.BLValidationError(
                    "Erro no banco de dados : " + err.Number);
            }
        }

        public void atualizarComanda(Model.Comanda c)
        {
            string sql = "UPDATE comanda SET " +
                "com_apelido = @com_apelido," +
                "com_observacoes = @com_observacoes," +
                "funcionario_pessoafisica_pes_cpf = @garcomcpf," +
                "mesa_mes_id = @mesa_id " +
                "where com_id = @comid;";

            var parametros = criarParametros();
            parametros.Add("@comid", c.Com_id);
            parametros.Add("@com_apelido", c.Com_apelido);
            parametros.Add("@com_observacoes", c.Com_observacoes);
            parametros.Add("@garcomcpf", c.Funcionario.Cpf);
            parametros.Add("@mesa_id", c.Mesa.Mes_id);

            try
            {
                Db.executarNonQuery(sql, parametros);
            }catch(MySqlException e)
            {
                if (e.Number == 1452)
                    throw new BL.Errors.BLValidationError("Mesa Inválida");
                else
                    throw new BL.Errors.
                        BLValidationError("Erro no banco de dados:"+e.Number);
            }
        }
    }
}
