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
                dr["pes_cpf"].ToString(),
                dr["pes_rg"].ToString(),
                dr["pes_nome"].ToString(),
                Convert.ToDateTime(dr["pes_data_nascimento"].ToString()),
                endereco != null ? endereco : DALEndereco.mapearObjeto(dr)
                );
        }

        public Funcionario obterFuncionario(string cpf,Endereco endereco,Cargo cargo)
        {
            Funcionario ret = null;

            Db.abrir();

            var param = criarParametros();
            param.Add("cpf", cpf);

            DataTable dt = Db.executarSelect("select fun_salario_atual,cargo.car_id, cargo.car_nome, cargo.car_descricao,cargo.car_sal_base,pessoafisica.pes_cpf,"+
"pessoafisica.pes_rg, pessoafisica.pes_nome, pessoafisica.pes_data_nascimento,"+
"pessoafisica.endereco_end_id, endereco.end_id, endereco.end_logradouro,"+
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
 "where pessoafisica_pes_cpf = @cpf;", param);
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

            string select = "select fun_salario_atual,cargo.car_id, cargo.car_nome, cargo.car_descricao," +
"cargo.car_sal_base,pessoafisica.pes_cpf,pessoafisica.pes_rg, pessoafisica.pes_nome," +
"pessoafisica.pes_data_nascimento,pessoafisica.endereco_end_id, endereco.end_id," +
"endereco.end_logradouro,endereco.end_observacoes, endereco.end_numero," +
"bairro.bai_id,bairro.bai_nome, cidade.cid_id, cidade.cid_nome," +
"estado.est_uf,estado.est_nome" +
" from pessoafisica" +
" inner join funcionario on funcionario.pessoafisica_pes_cpf = pessoafisica.pes_cpf" +
" inner join cargo on cargo.car_id = funcionario.cargo_car_id" +
" inner join endereco on endereco.end_id = pessoafisica.endereco_end_id" +
" inner join bairro on bairro.bai_id = endereco.bairro_bai_id" +
" inner join cidade on cidade.cid_id = bairro.bai_id" +
" inner join estado on cidade.estado_est_uf = estado.est_uf ";
            DataTable dt = Db.executarSelect(select + args + ";");

            Db.fechar();

            foreach(DataRow r in dt.Rows)
            {
                funcionarios.Add(mapearObjeto(r, null, null));
            }

            return funcionarios;
        }
    }
}
