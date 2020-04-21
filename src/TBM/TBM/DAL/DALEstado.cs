using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    class DALEstado : DALBase
    {
        public DALEstado(Persistencia p) : base(p)
        {

        } 

        public static Estado mapearObjeto(DataRow dr)
        {
            return new Estado(
                (string)dr["est_uf"],
                (string)dr["est_nome"]
            );
        }

        public Estado obterEstado(string uf)
        {
            Estado ret = null;

            Db.abrir();

            var param = criarParametros();
            param.Add("uf", uf);

            DataTable dt = Db.executarSelect("SELECT est_uf, est_nome FROM estado WHERE est_uf = @uf", param);

            if (dt.Rows.Count >= 1)
            {
                ret = mapearObjeto(dt.Rows[0]);
            }

            Db.fechar();

            return ret;
        }
    }
}
