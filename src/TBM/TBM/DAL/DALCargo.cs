using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    class DALCargo : DALBase
    {
        public DALCargo(Persistencia p) : base(p)
        { }

        public static Cargo mapearObjeto(DataRow dr)
        {
            return new Cargo(
                Convert.ToInt32(dr["car_id"]),
                (string)dr["car_nome"],
                dr["car_descricao"] is DBNull ? null : (string)dr["car_descricao"],
                Convert.ToDouble(dr["car_sal_base"]),
                (NivelAcesso)Convert.ToInt32(dr["car_nivel_permissao"])
            );
        }

        public Cargo obterCargo(int Id)
        {
            Cargo ret = null;

            Db.abrir();

            var param = criarParametros();
            param.Add("@id",Id);

            DataTable dt = Db.executarSelect("SELECT from cargo " +
                "FROM cargo where car_id = @id;",param);
            if(dt.Rows.Count >= 1)
            {
                ret = mapearObjeto(dt.Rows[0]);
            }
            return ret;
        }

        public List<Cargo> obterCargos()
        {
            List<Cargo> ret = new List<Cargo>();

            Db.abrir();

            DataTable dt = Db.executarSelect("select * from cargo;");
            
            foreach(DataRow r in dt.Rows)
            {
                string c = r["car_nivel_permissao"].ToString();
                ret.Add(mapearObjeto(r));
            }
            return ret;
        }
    }
}
