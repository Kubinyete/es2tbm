using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALBairro : DALBase
    {
        public DALBairro(Persistencia p) : base(p)
        {

        }

        public static Bairro mapearObjeto(DataRow dr, Cidade e = null)
        {
            return new Bairro(
                (int)dr["bai_id"],
                (string)dr["bai_nome"],
                e != null ? e : DALCidade.mapearObjeto(dr, null)
            );
        }

        public List<Bairro> obterBairros(Cidade e)
        {
            List<Bairro> ret = new List<Bairro>();

            Db.abrir();

            var param = criarParametros();
            param.Add("cid", e.Id);

            DataTable dt = Db.executarSelect("SELECT bai_id, bai_nome FROM bairro WHERE cidade_cid_id = @cid", param);

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr, e)
                );
            }

            Db.fechar();

            return ret;
        }

        public List<Bairro> procurarBairros(Cidade e, string busca)
        {
            List<Bairro> ret = new List<Bairro>();

            Db.abrir();

            var param = criarParametros();
            param.Add("cid", e.Id);
            param.Add("busca", String.Format("%{0}%", busca));

            DataTable dt = Db.executarSelect("SELECT bai_id, bai_nome FROM bairro WHERE cidade_cid_id = @cid AND bai_nome LIKE @busca", param);

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
