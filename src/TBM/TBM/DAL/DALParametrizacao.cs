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
    }
}
