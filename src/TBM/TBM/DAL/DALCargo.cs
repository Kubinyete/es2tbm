﻿using System;
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
                Convert.ToInt32(dr["car_id"].ToString()),
                dr["car_nome"].ToString(),
                dr["car_descricao"].ToString(),
                Convert.ToDouble(dr["car_sal_base"].ToString()));
        }

        public Cargo obterCargo(int Id)
        {
            Cargo ret = null;

            Db.abrir();

            var param = criarParametros();
            param.Add("id",Id);

            DataTable dt = Db.executarSelect("SELECT car_id,car_nome,car_descricao,car_sal_base " +
                "FROM cargo where car_id = @id;",param);
            if(dt.Rows.Count >= 1)
            {
                ret = mapearObjeto(dt.Rows[0]);
            }
            return ret;
        }
    }
}