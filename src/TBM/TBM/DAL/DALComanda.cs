using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;
using TBM.Uteis;

namespace TBM.DAL
{
    public class DALComanda : DALBase
    {
        public DALComanda(Persistencia p, bool isSub = false) : base(p, isSub)
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
                Convert.ToDateTime(dr["com_data_abertura"].ToString()),
                dr["com_data_abertura"] is DBNull ? null : (DateTime?)(dr["com_data_fechamento"])
            );
        }

        public static Model.Comanda mapearObjetov2(DataRow dr)
        {
            return new Model.Comanda(
                (int)dr["com_id"],
                (string)dr["com_apelido"],
                (string)dr["com_observacoes"],
                (double)dr["com_valor_total"],
                DALFuncionario.mapearObjetov2(dr, "a_"),
                dr["b_pes_cpf"] is DBNull ? null : DALCliente.mapearObjetov2(dr, "b_"),
                DALMesa.mapearObjeto(dr),
                (DateTime)dr["com_data_abertura"],
                dr["com_data_fechamento"] is DBNull ? (DateTime?)null : (DateTime)dr["com_data_fechamento"]
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

        public List<Model.Comanda> obterComandas(int numMesa, string garcomNome)
        {
            List<Model.Comanda> ret = new List<Model.Comanda>();

            string sql = "select comanda.*, funcionario.*, pessoafisica.*," +
                " endereco.*, bairro.*, mesa.*, cargo.*, cidade.*, estado.* "+
"from comanda "+
"inner join mesa on mesa.mes_id = comanda.mesa_mes_id "+
"inner join funcionario on funcionario.pessoafisica_pes_cpf = comanda.funcionario_pessoafisica_pes_cpf "+
"inner join cargo on cargo.car_id = funcionario.cargo_car_id "+
"inner join pessoafisica on pessoafisica.pes_cpf = funcionario.pessoafisica_pes_cpf "+
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id "+
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id "+
"inner join cidade on cidade.cid_id = bairro.bai_id " +
"inner join estado on estado.est_uf = cidade.estado_est_uf "+
"where mesa.mes_id = @mesid and pessoafisica.pes_nome LIKE @nome";

            var parametros = criarParametros();
            parametros.Add("@mesid", numMesa);
            parametros.Add("@nome", String.Format("%{0}%", garcomNome.Replace("%", "%%")));

            try
            {
                DataTable dt = Db.executarSelect(sql, parametros); 
                foreach(DataRow row in dt.Rows)
                {
                    ret.Add(mapearObjeto(row));
                }
                return ret;
            }catch(MySqlException err)
            {
                throw new BL.Errors.BLValidationError(
                    "Erro no banco de dados : " + err.Number);
            }
        }

        public List<Model.Comanda> obterComandasv2(Mesa m, string nomeFuncionario)
        {
            List<Model.Comanda> ret = new List<Comanda>();

            var param = criarParametros();
            param.Add("mid", m.Mes_id);
            param.Add("nome", String.Format("%{0}%", nomeFuncionario.Replace("%", "%%")));

            DataTable dt = Db.executarSelect("SELECT com_id, com_apelido, com_observacoes, com_valor_total, com_data_abertura, com_data_fechamento, fun_salario_atual AS a_fun_salario_atual, fun_email AS a_fun_email, fun_telefone AS a_fun_telefone, car_id AS a_car_id, car_nome AS a_car_nome, car_descricao AS a_car_descricao, car_nivel_permissao AS a_car_nivel_permissao, car_sal_base AS a_car_sal_base, fpessoafisica.pes_cpf AS a_pes_cpf, fpessoafisica.pes_rg AS a_pes_rg, fpessoafisica.pes_nome AS a_pes_nome, fpessoafisica.pes_data_nascimento AS a_pes_data_nascimento, fpessoafisica.endereco_end_id AS a_endereco_end_id, fendereco.end_id AS a_end_id, fendereco.end_logradouro AS a_end_logradouro, fendereco.end_numero AS a_end_numero, fendereco.end_observacoes AS a_end_observacoes, fbairro.bai_id AS a_bai_id, fbairro.bai_nome AS a_bai_nome, fcidade.cid_id AS a_cid_id, fcidade.cid_nome AS a_cid_nome, festado.est_uf AS a_est_uf, festado.est_nome AS a_est_nome, mes_id, mes_observacoes, mes_capacidade, mes_disponivel, cli_divida_acumulada AS b_cli_divida_acumulada, cli_email AS b_cli_email, cli_telefone AS b_cli_telefone, cli_ativado AS b_cli_ativado, cpessoafisica.pes_cpf AS b_pes_cpf, cpessoafisica.pes_rg AS b_pes_rg, cpessoafisica.pes_nome AS b_pes_nome, cpessoafisica.pes_data_nascimento AS b_pes_data_nascimento, cpessoafisica.endereco_end_id AS b_endereco_end_id, cendereco.end_id AS b_end_id, cendereco.end_logradouro AS b_end_logradouro, cendereco.end_numero AS b_end_numero, cendereco.end_observacoes AS b_end_observacoes, cbairro.bai_id AS b_bai_id, cbairro.bai_nome AS b_bai_nome, ccidade.cid_id AS b_cid_id, ccidade.cid_nome AS b_cid_nome, cestado.est_uf AS b_est_uf, cestado.est_nome AS b_est_nome FROM comanda  INNER JOIN mesa ON comanda.mesa_mes_id = mesa.mes_id INNER JOIN funcionario ON comanda.funcionario_pessoafisica_pes_cpf = funcionario.pessoafisica_pes_cpf INNER JOIN cargo ON funcionario.cargo_car_id = cargo.car_id INNER JOIN pessoafisica AS fpessoafisica ON funcionario.pessoafisica_pes_cpf = fpessoafisica.pes_cpf LEFT JOIN endereco AS fendereco ON fpessoafisica.endereco_end_id = fendereco.end_id LEFT JOIN bairro AS fbairro ON fendereco.bairro_bai_id = fbairro.bai_id LEFT JOIN cidade AS fcidade ON fbairro.cidade_cid_id = fcidade.cid_id LEFT JOIN estado AS festado ON fcidade.estado_est_uf = festado.est_uf LEFT JOIN cliente ON comanda.cliente_pessoafisica_pes_cpf = cliente.pessoafisica_pes_cpf LEFT JOIN pessoafisica AS cpessoafisica ON cliente.pessoafisica_pes_cpf = cpessoafisica.pes_cpf LEFT JOIN endereco AS cendereco ON cpessoafisica.endereco_end_id = cendereco.end_id LEFT JOIN bairro AS cbairro ON cendereco.bairro_bai_id = cbairro.bai_id LEFT JOIN cidade AS ccidade ON cbairro.cidade_cid_id = ccidade.cid_id LEFT JOIN estado AS cestado ON ccidade.estado_est_uf = cestado.est_uf WHERE comanda.mesa_mes_id = @mid AND comanda.com_data_fechamento IS NULL AND fpessoafisica.pes_nome LIKE @nome", param);

            foreach (DataRow row in dt.Rows)
            {
                ret.Add(mapearObjetov2(row));
            }

            return ret;
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

        public bool fecharComanda(Model.Comanda c, DateTime data_vencimento, Cliente cli)
        {
            Db.abrir();

            var param = criarParametros();
            param.Add("id", c.Com_id);
            param.Add("mesa", c.Mesa.Mes_id);
            param.Add("vencimento", data_vencimento);
            param.Add("cpf", cli != null ? cli.Cpf : null);

            DataTable dt = Db.executarSelect("CALL fechar_comanda(@id, @vencimento, @mesa, @cpf, @result); SELECT @result;", param);

            Db.fechar();

            return dt.Rows.Count == 1 ? ((long)dt.Rows[0]["@result"]) == 1 : false;
        }
    }
}
