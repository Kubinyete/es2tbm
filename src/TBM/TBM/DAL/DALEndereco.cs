using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALEndereco : DALBase
    {
        public DALEndereco(Persistencia p) : base(p)
        {

        }

        public static Endereco mapearObjeto(DataRow dr, Bairro e = null)
        {
            return new Endereco(
                (int)dr["end_id"],
                (int)dr["end_numero"],
                (string)dr["end_logradouro"],
                (string)dr["end_observacoes"],
                e != null ? e : DALBairro.mapearObjeto(dr, null)
            );
        }

        public List<Endereco> obterEnderecos(Bairro e)
        {
            List<Endereco> ret = new List<Endereco>();

            Db.abrir();

            var param = criarParametros();
            param.Add("bid", e.Id);

            DataTable dt = Db.executarSelect("SELECT end_id, end_logradouro, end_observacoes FROM bairro WHERE bairro_bai_id = @bid", param);

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr, e)
                );
            }

            Db.fechar();

            return ret;
        }

        /*
         * Fiz esta sobrecarga para carregar o combobox do form de alteração
        */
        public List<Endereco> obterEnderecos()
        {
            List<Endereco> ret = new List<Endereco>();

            Db.abrir();

            DataTable dt = Db.executarSelect("select end_id,end_logradouro,end_observacoes, bairro.bai_id,bairro.bai_nome,"+ 
"cidade.cid_id,endereco.end_numero ,cidade.cid_nome, estado.est_uf, estado.est_nome "+
"from endereco "+
"inner join bairro on endereco.bairro_bai_id = bairro_bai_id "+
"inner join cidade on cidade.cid_id = bairro.cidade_cid_id " +
"inner join estado on estado.est_uf = cidade.estado_est_uf;");

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr, null)
                );
            }

            Db.fechar();

            return ret;
        }

        public List<Endereco> procurarEnderecos(Bairro e, string busca)
        {
            List<Endereco> ret = new List<Endereco>();

            Db.abrir();

            var param = criarParametros();
            param.Add("bid", e.Id);
            param.Add("busca", String.Format("%{0}%", busca));

            DataTable dt = Db.executarSelect("SELECT end_id, end_logradouro, end_observacoes FROM bairro WHERE bairro_bai_id = @bid AND end_logradouro LIKE @busca", param);

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
