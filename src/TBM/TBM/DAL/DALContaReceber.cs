using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALContaReceber : DALBase
    {
        public DALContaReceber(Persistencia p, bool isSub = false) : base(p, isSub)
        {

        }

        public static ContaReceber mapearObjeto(DataRow dr, Comanda e = null)
        {
            return new ContaReceber(
                (int)dr["con_id"],
                (double)dr["con_valor"],
                (FormaRecebimento)dr["con_forma_recebimento"],
                dr["con_data_recebimento"] is DBNull ? null : (DateTime?)dr["con_data_recebimento"],
                (DateTime)dr["con_data_vencimento"],
                e != null ? e : DALComanda.mapearObjeto(dr)
            );
        }

        public static Dictionary<string, object> mapearParametros(ContaReceber c, string suffix = "")
        {
            var param = criarParametros();
            param.Add("id" + suffix, c.Id);
            param.Add("valor" + suffix, c.Valor);
            param.Add("formarecebimento" + suffix, (char)c.Forma_recebimento);

            if (c.Data_recebimento.HasValue)
                param.Add("datarecebimento" + suffix, c.Data_recebimento.Value);
            else
                param.Add("datarecebimento" + suffix, null);

            param.Add("datavencimento" + suffix, c.Data_vencimento);
            param.Add("comanda" + suffix, c.Comanda.Com_id);

            return param;
        }

        public bool inserirContasReceber(List<ContaReceber> l)
        {
            if (l.Count < 1)
                return true;

            string sql = "INSERT INTO contareceber (con_valor, con_forma_recebimento, con_data_recebimento, con_data_vencimento, comanda_com_id) VALUES ";
            int suffix = 1;
            Dictionary<string, object> d = null;

            foreach (var c in l)
            {
                sql += String.Format("{0}(@valor{1}, @formarecebimento{1}, @datarecebimento{1}, @datavencimento{1}, @comanda{1})", suffix == 1 ? String.Empty : ", ", suffix);

                if (d == null)
                {
                    d = mapearParametros(c, suffix.ToString());
                } else
                {
                    foreach (var item in mapearParametros(c, suffix.ToString()))
                    {
                        d[item.Key] = item.Value;
                    }
                }

                suffix++;
            }

            Db.abrir();
            bool ret = Db.executarNonQuery(sql, d) > 0;
            Db.fechar();

            return ret;
        }
    }
}
