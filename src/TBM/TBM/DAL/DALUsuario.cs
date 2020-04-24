using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    class DALUsuario : DALBase
    {
        public DALUsuario(Persistencia p) : base(p)
        {

        }

        public static Usuario mapearObjeto(DataRow dt, Funcionario funcionario)
        {
            return new Usuario(
                dt["usr_username"].ToString(),
                "",
                dt["usr_ativado"].ToString() == "1" ? true : false,
                funcionario != null ? funcionario : DALFuncionario.mapearObjeto(dt, null, null)
            );
        }

        public Usuario obterUsuario(string username, Funcionario f)
        {
            Usuario ret = null;

            Db.abrir();

            var parametros = criarParametros();
            parametros.Add("@username", username);

            DataTable dt = Db.executarSelect("select usuario.usr_username,usuario.usr_ativado,cargo.car_id, cargo.car_nome, cargo.car_descricao,cargo.car_sal_base," +
"pessoafisica.pes_cpf," +
"pessoafisica.pes_rg, pessoafisica.pes_nome, pessoafisica.pes_data_nascimento," +
"pessoafisica.endereco_end_id, endereco.end_id, endereco.end_logradouro," +
"endereco.end_observacoes, endereco.end_numero, bairro.bai_id," +
"bairro.bai_nome, cidade.cid_id, cidade.cid_nome, estado.est_uf," +
"estado.est_nome" +
 "from usuario" +
 "inner join funcionario on usuario.funcionario_pessoafisica_pes_cpf = funcionario_pessoafisica_pes_cpf" +
 "inner join pessoafisica on funcionario.pessoafisica_pes_cpf = pessoafisica.pes_cpf" +
"inner join cargo on cargo.car_id = funcionario.cargo_car_id" +
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id" +
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id" +
"inner join cidade on cidade.cid_id = bairro.bai_id" +
"inner join estado on cidade.estado_est_uf = estado.est_uf" +
 "where usuario.usr_username = @username;", parametros);

            Db.fechar();

            if (dt.Rows.Count >= 1)
            {
                ret = mapearObjeto(dt.Rows[0], f);
            }
            return ret;
        }

        public string Logar(string username, string password)
        {
            string ret = "Erro";
            bool logou = false;

            Db.abrir();

            var parametros = criarParametros();
            parametros.Add("@username", username);
            parametros.Add("@password", password);

            DataTable dt = Db.executarSelect("CALL login(@username,@password,@output_cod,@output_msg);"+
            "select @output_cod, @output_msg;", parametros);

            if (dt.Rows.Count > 0)
            {
                ret = dt.Rows[0]["@output_msg"].ToString();
            }

            Db.fechar();

            return ret;
        }


    }
}
