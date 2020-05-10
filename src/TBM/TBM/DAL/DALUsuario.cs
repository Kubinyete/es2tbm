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
                dt["usr_ativado"].ToString() == "True"? true : false,
                funcionario != null ? funcionario : DALFuncionario.mapearObjeto(dt, null, null)
            );
        }

        public Usuario obterUsuario(string username, Funcionario f)
        {
            Usuario ret = null;

            Db.abrir();

            var parametros = criarParametros();
            parametros.Add("@username", username);

            DataTable dt = Db.executarSelect("select usuario.*,cargo.*," +
"pessoafisica.*, funcionario.*," +
"endereco.*," +
"bairro.*," +
"cidade.*, estado.* " +
" from usuario " +
"inner join funcionario on usuario.funcionario_pessoafisica_pes_cpf = funcionario.pessoafisica_pes_cpf " +
"inner join pessoafisica on funcionario.pessoafisica_pes_cpf = pessoafisica.pes_cpf " +
"inner join cargo on cargo.car_id = funcionario.cargo_car_id " +
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id " +
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id " +
"inner join cidade on cidade.cid_id = bairro.bai_id " +
"inner join estado on cidade.estado_est_uf = estado.est_uf " +
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

        public List<Usuario> obterUsuarios(string arg, string pms)
        {
            List<Usuario> ret = new List<Usuario>();

            Db.abrir();
            Dictionary<string,object> parametros = null;
            /*if (arg != null){
                parametros = criarParametros();
                parametros.Add("@param", pms);
            }*/

            DataTable dt = Db.executarSelect("select usuario.*, funcionario.*,"+
"pessoafisica.*, cargo.*," +
"endereco.end_id, endereco.end_logradouro, endereco.end_observacoes,endereco.end_numero,"+
"bairro.bai_id, bairro.bai_nome, cidade.cid_id, cidade.cid_nome,"+
"estado.est_uf, estado.est_nome "+
"from usuario "+
"inner join funcionario on funcionario.pessoafisica_pes_cpf = usuario.funcionario_pessoafisica_pes_cpf "+
"inner join pessoafisica on pessoafisica.pes_cpf = funcionario_pessoafisica_pes_cpf "+
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id "+
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id "+
"inner join cidade on cidade.cid_id = bairro.cidade_cid_id "+
"inner join estado on estado.est_uf = cidade.estado_est_uf "+
"inner join cargo on cargo.car_id = funcionario.cargo_car_id "+
"WHERE usuario.usr_username <> 'TBM' " +
arg +";", parametros); 

            //@TODO 
            //Corrigir pesquisa sem parametros

            Db.fechar();

            foreach(DataRow dr in dt.Rows)
            {
                ret.Add(mapearObjeto(dr,null));
            }
            return ret;
        }

        public string cadastrarUsuario(Usuario u)
        {
            string ret = "";

            string sql = "CALL insere_usuario(@username,@password,@cpf, @output_msg, @output_cod);" +
            "select @output_msg, @output_cod;";

            var parametros = criarParametros();
            parametros.Add("@username", u.Username);
            parametros.Add("@password", u.Password);
            parametros.Add("@cpf", u.Funcionario.Cpf);

            Db.abrir();

            DataTable dt = Db.executarSelect(sql,parametros);

            Db.fechar();

            ret = dt.Rows[0]["@output_cod"].ToString() == "1" ? "Inserido com sucesso"
                : dt.Rows[0]["@output_msg"].ToString();
            return ret;
        }

        public string alterarSenha(Usuario usr)
        {
            string ret = "";

            string sql = "UPDATE usuario set usr_password = md5(@password) " +
                "where funcionario_pessoafisica_pes_cpf = @cpf";

            var parametros = criarParametros();

            parametros.Add("@password", usr.Password);
            parametros.Add("@cpf", usr.Funcionario.Cpf);

            Db.abrir();

            try
            {
                Db.executarNonQuery(sql,parametros);
                ret = "Senha Atualizada";
            }catch(MySqlException e)
            {
                ret = e.ToString();
            }

            Db.fechar();

            return ret;
        }

        public string atualizarEstadoUsuario(Usuario u, int val)
        {
            string ret = "";

            string sql = "UPDATE usuario set usr_ativado = "+val+" where " +
                "funcionario_pessoafisica_pes_cpf = @cpf";

            var parametros = criarParametros();
            parametros.Add("@cpf", u.Funcionario.Cpf);
            Db.abrir();

            try
            {
                Db.executarNonQuery(sql, parametros);
            }catch(MySqlException e)
            {
                ret = e.Message;
            }

            Db.fechar();
            return ret;
        }

    }
}
