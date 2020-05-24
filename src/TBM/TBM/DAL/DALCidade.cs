using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALCidade : DALBase
    {
        public DALCidade(Persistencia p) : base(p)
        {

        }

        public static Cidade mapearObjeto(DataRow dr, Estado e = null)
        {
            return new Cidade(
                (int)dr["cid_id"],
                (string)dr["cid_nome"],
                e != null ? e : DALEstado.mapearObjeto(dr)
            );
        }

        public static Cidade mapearObjetov2(DataRow dr, string v, Estado e = null)
        {
            return new Cidade(
                (int)dr[v + "cid_id"],
                (string)dr[v + "cid_nome"],
                e != null ? e : DALEstado.mapearObjetov2(dr, v)
            );
        }

        public List<Cidade> obterCidades(Estado e)
        {
            List<Cidade> ret = new List<Cidade>();

            Db.abrir();

            var param = criarParametros();
            param.Add("uf", e.Uf);

            DataTable dt = Db.executarSelect("SELECT cid_id, cid_nome FROM cidade WHERE estado_est_uf = @uf", param);

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr, e)
                );
            }

            Db.fechar();

            return ret;
        }
    }
}
