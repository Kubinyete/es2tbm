using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALParametrizacao : DALBase
    {
        public DALParametrizacao(Persistencia p) : base(p)
        {

        }

        public static Parametrizacao mapearObjeto(DataRow dr, Endereco e = null)
        {
            if (e == null)
                e = DALEndereco.mapearObjeto(dr, null);

            return new Parametrizacao(
                Convert.ToInt32(dr["par_id"]),
                Convert.ToString(dr["par_nome_fantasia"]),
                Convert.ToString(dr["par_razao_social"]),
                Convert.ToString(dr["par_cnpj"]),
                Convert.ToInt64(dr["par_ie"]),
                Convert.ToString(dr["par_email"]),
                dr["par_logomarca"] is DBNull ? null : (byte[])dr["par_logomarca"],
                Convert.ToString(dr["par_logomarca_path"]),
                Convert.ToString(dr["par_telefone"]),
                (DateTime)dr["par_data_ativacao"],
                e
            );
        }

        public static Dictionary<string, object> mapearParametros(Parametrizacao p)
        {
            var param = criarParametros();

            param.Add("id", p.Id);
            param.Add("nome", p.Nome_fantasia);
            param.Add("razao", p.Razao_social);
            param.Add("cnpj", p.Cnpj);
            param.Add("ie", p.Ie);
            param.Add("email", p.Email == String.Empty ? null : p.Email);
            param.Add("logo", p.Logomarca);
            param.Add("logopath", p.Logomarca_path == String.Empty ? null : p.Logomarca_path);
            param.Add("telefone", p.Telefone == String.Empty ? null : p.Telefone);
            param.Add("data", p.Data_ativacao);
            param.Add("endereco", p.Endereco.Id);

            return param;
        }

        public Parametrizacao obterParametrizacao()
        {
            Parametrizacao ret = null;

            Db.abrir();

            DataTable dt = Db.executarSelect("SELECT * FROM parametrizacao AS par INNER JOIN endereco AS end ON par.endereco_end_id = end.end_id INNER JOIN bairro AS bai ON end.bairro_bai_id = bai.bai_id INNER JOIN cidade AS cid ON bai.cidade_cid_id = cid.cid_id INNER JOIN estado AS est ON cid.estado_est_uf = est.est_uf ORDER BY par_data_ativacao DESC LIMIT 1");

            foreach (DataRow dr in dt.Rows)
            {
                ret = mapearObjeto(dr);
            }

            Db.fechar();

            return ret;
        }

        public bool inserirParametrizacao(Parametrizacao p) {
            Db.abrir();

            var param = mapearParametros(p);

            bool ret = Db.executarNonQuery("INSERT INTO parametrizacao (par_nome_fantasia, par_razao_social, par_cnpj, par_ie, par_email, par_logomarca, par_logomarca_path, par_telefone, par_data_ativacao, endereco_end_id) VALUES (@nome, @razao, @cnpj, @ie, @email, @logo, @logopath, @telefone, @data, @endereco)", param) > 0;

            Db.fechar();

            if (ret)
                p.Id = (int)Db.obterUltimoId();

            return ret;
        }

        public bool atualizarParametrizacao(Parametrizacao p)
        {
            Db.abrir();

            var param = mapearParametros(p);

            bool ret = Db.executarNonQuery("UPDATE parametrizacao SET par_nome_fantasia = @nome, par_razao_social = @razao, par_cnpj = @cnpj, par_ie = @ie, par_email = @email, par_logomarca = @logo, par_logomarca_path = @logopath, par_telefone = @telefone, par_data_ativacao = @data, endereco_end_id = @endereco WHERE par_id = @id", param) > 0;

            Db.fechar();

            return ret;
        }
    }
}
