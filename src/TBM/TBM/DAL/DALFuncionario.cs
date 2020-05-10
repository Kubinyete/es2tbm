using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    class DALFuncionario : DALBase
    {
        public DALFuncionario(Persistencia p) : base(p)
        {
            
        }

        public static Funcionario mapearObjeto(DataRow dr,Cargo cargo,Endereco endereco)
        {
            return new Funcionario(Convert.ToDouble(
                dr["fun_salario_atual"].ToString()),
                cargo != null ? cargo : DALCargo.mapearObjeto(dr),
                dr["fun_email"] is DBNull ? "" : dr["fun_email"].ToString(),
                dr["fun_telefone"] is DBNull ? "" : dr["fun_telefone"].ToString(),
                dr["pes_cpf"].ToString(),
                dr["pes_rg"].ToString(),
                dr["pes_nome"].ToString(),
                Convert.ToDateTime(dr["pes_data_nascimento"].ToString()),
                endereco != null ? endereco : DALEndereco.mapearObjeto(dr, null)
                ) ;
        }

        public Funcionario obterFuncionario(string cpf,Endereco endereco,Cargo cargo)
        {
            Funcionario ret = null;

            Db.abrir();

            var param = criarParametros();
            param.Add("cpf", cpf);

            DataTable dt = Db.executarSelect("select funcionario.*,cargo.*,pessoafisica.*,"+
"endereco.end_id, endereco.end_logradouro,"+
"endereco.end_observacoes, endereco.end_numero, bairro.bai_id,"+
"bairro.bai_nome, cidade.cid_id, cidade.cid_nome, estado.est_uf,"+
"estado.est_nome"+
"from pessoafisica"+
"inner join funcionario on funcionario.pessoafisica_pes_cpf = pessoafisica.pes_cpf"+
 "inner join cargo on cargo.car_id = funcionario.cargo_car_id"+
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id"+
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id"+
"inner join cidade on cidade.cid_id = bairro.bai_id"+
"inner join estado on cidade.estado_est_uf = estado.est_uf"+
 "where pessoafisica_pes_cpf = @cpf AND cargo.car_nome <> SYSADM;", param);
            if(dt.Rows.Count >= 1)
            {
                ret = mapearObjeto(dt.Rows[0], cargo, endereco);
            }

            Db.fechar();

            return ret;
        }

        public List<Funcionario> obterFuncionarios(string args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Db.abrir();

            string select = "select funcionario.*,cargo.*,pessoafisica.*, endereco.*," +
"bairro.*, cidade.*," +
"estado.* " +
" from pessoafisica" +
" inner join funcionario on funcionario.pessoafisica_pes_cpf = pessoafisica.pes_cpf" +
" inner join cargo on cargo.car_id = funcionario.cargo_car_id" +
" inner join endereco on endereco.end_id = pessoafisica.endereco_end_id" +
" inner join bairro on bairro.bai_id = endereco.bairro_bai_id" +
" inner join cidade on cidade.cid_id = bairro.bai_id" +
" inner join estado on cidade.estado_est_uf = estado.est_uf " +
" where pes_cpf > 100000 ";
            DataTable dt = Db.executarSelect(select + args + ";");

            Db.fechar();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    funcionarios.Add(mapearObjeto(r, null, null));
                }
            }

            return funcionarios;
        }

        public bool inserirFuncionario(Model.Funcionario f)
        {
            string sql = "CALL cadastrar_funcionario(@cpf,@rg,@nome,@datanasc,@end_id," +
                "@salario_atual,@email,@telefone,@cargo_id,@proc_result);" +
                "select @proc_result";

            var parametros = criarParametros();
            parametros.Add("@cpf", f.Cpf);
            parametros.Add("@rg", f.Rg);
            parametros.Add("@nome", f.Nome);
            parametros.Add("@datanasc", f.Data_nascimento);
            parametros.Add("@end_id", f.Endereco.Id);
            parametros.Add("@email", f.Email);
            parametros.Add("@telefone", f.Telefone);
            parametros.Add("@salario_atual", f.Salario_atual);
            parametros.Add("@cargo_id", f.Cargo.Id);

            Db.abrir();

            DataTable dt = new DataTable();

            dt = Db.executarSelect(sql, parametros);
            Db.fechar();

            if (dt.Rows[0]["@proc_result"].ToString() == "1")
            {
                return true;
            }
            else
                return false;
        }

        public bool atualizarFuncionario(Funcionario f)
        {
            bool ret = true;

            string sql = "CALL atualiza_funcionario(@cpf,@rg,@nome,@dt_nasc," +
                "@endid,@sal_base,@email,@telefone,@carid,@output); " +
            "select @output;";

            Db.abrir();

            var parametros = criarParametros();
            parametros.Add("@cpf", f.Cpf);
            parametros.Add("@rg", f.Rg);
            parametros.Add("@nome", f.Nome);
            parametros.Add("@dt_nasc", f.Data_nascimento);
            parametros.Add("@endid", f.Endereco.Id);
            parametros.Add("@email", f.Email);
            parametros.Add("@telefone", f.Telefone);
            parametros.Add("@sal_base", f.Salario_atual);
            parametros.Add("@carid", f.Cargo.Id);
     

            DataTable dt = Db.executarSelect(sql, parametros);

            Db.fechar();

            ret = dt.Rows[0]["@output"].ToString() == "1" ? true : false;

            return ret;
        }

        public bool excluirFuncionario(Funcionario f)
        {
            bool ret = true;

            string sql = "CALL atualiza_funcionario(@cpf,@rg,@nome,@dt_nasc,@endid,@sal_base," +
                "@email,@telefone,@carid,@output); " +
            "select @output;";

            Db.abrir();

            var parametros = criarParametros();
            parametros.Add("@cpf", f.Cpf);
            parametros.Add("@rg", f.Rg);
            parametros.Add("@nome", f.Nome);
            parametros.Add("@dt_nasc", f.Data_nascimento);
            parametros.Add("@endid", f.Endereco.Id);
            parametros.Add("@email", f.Email);
            parametros.Add("@telefone", f.Telefone);
            parametros.Add("@sal_base", f.Salario_atual);
            parametros.Add("@carid", null);

            DataTable dt = Db.executarSelect(sql, parametros);

            Db.fechar();

            ret = dt.Rows[0]["@output"].ToString() == "1" ? true : false;

            return ret;
        }

        public List<Funcionario> obterFuncionariosSemUsuario()
        {
            List<Funcionario> ret = new List<Funcionario>();

            string sql = "select cargo.*," +
"pessoafisica.*, funcionario.*,"+
"endereco.*, bairro.*, cidade.*, estado.* "+
"from funcionario "+
"left join usuario on usuario.funcionario_pessoafisica_pes_cpf = funcionario.pessoafisica_pes_cpf " +
"inner join pessoafisica on funcionario.pessoafisica_pes_cpf = pessoafisica.pes_cpf " +
"inner join cargo on cargo.car_id = funcionario.cargo_car_id " +
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id " +
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id " +
"inner join cidade on cidade.cid_id = bairro.bai_id " +
"inner join estado on cidade.estado_est_uf = estado.est_uf " +
"where cargo_car_id is not null and " +
"usuario.funcionario_pessoafisica_pes_cpf is null;";

            Db.abrir();

            DataTable dt = Db.executarSelect(sql);

            Db.fechar(); 

            foreach(DataRow r in dt.Rows)
            {
                ret.Add(mapearObjeto(r,null, null));
            }

            return ret;
        }

        public List<Model.Funcionario> obterGarcons()
        {
            List<Model.Funcionario> ret = new List<Model.Funcionario>();

            string sql = "select funcionario.*,cargo.*,pessoafisica.*, " +
                "endereco.*, bairro.*,cidade.*,estado.* "+
"from funcionario " +
"inner join cargo on cargo.car_id = funcionario.cargo_car_id " +
"inner join pessoafisica on pessoafisica.pes_cpf = funcionario.pessoafisica_pes_cpf "+
"inner join endereco on endereco.end_id = pessoafisica.endereco_end_id "+
"inner join bairro on bairro.bai_id = endereco.bairro_bai_id "+
"inner join cidade on cidade.cid_id = bairro.cidade_cid_id "+
"inner join estado on estado.est_uf = cidade.estado_est_uf "+
"where cargo.car_nome = 'Garçom'; ";

            Db.abrir();

            DataTable dt = Db.executarSelect(sql);

            foreach(DataRow dr in dt.Rows)
            {
                ret.Add(mapearObjeto(dr,null, null));
            }
            return ret;
        }
    }
}
