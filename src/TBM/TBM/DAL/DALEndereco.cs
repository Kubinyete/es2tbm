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

        public static Dictionary<string, object> mapearParametros(Endereco e)
        {
            var param = criarParametros();
            param.Add("id", e.Id);
            param.Add("logradouro", e.Logradouro);
            param.Add("numero", e.Numero);
            param.Add("observacoes", e.Observacoes == String.Empty ? null : e.Observacoes);
            param.Add("bairro", e.Bairro.Id);

            return param;
        }

        public List<Endereco> obterEnderecos(Bairro e)
        {
            List<Endereco> ret = new List<Endereco>();

            Db.abrir();

            var param = criarParametros();
            param.Add("bid", e.Id);

            DataTable dt = Db.executarSelect("SELECT end_id, end_logradouro, end_numero, end_observacoes FROM endereco WHERE bairro_bai_id = @bid", param);

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr, e)
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

            DataTable dt = Db.executarSelect("SELECT end_id, end_logradouro, end_numero, end_observacoes FROM endereco WHERE bairro_bai_id = @bid AND end_logradouro LIKE @busca", param);

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr, e)
                );
            }

            Db.fechar();

            return ret;
        }

        public bool inserirEndereco(Endereco e)
        {
            Db.abrir();

            var param = mapearParametros(e);

            bool ret = Db.executarNonQuery("INSERT INTO endereco (end_logradouro, end_numero, end_observacoes, bairro_bai_id) VALUES (@logradouro, @numero, @observacoes, @bairro)", param) > 0;

            Db.fechar();

            if (ret)
                e.Id = (int)Db.obterUltimoId();

            return ret;
        }

        public bool atualizarEndereco(Endereco e)
        {
            Db.abrir();

            var param = mapearParametros(e);

            bool ret = Db.executarNonQuery("UPDATE endereco SET end_logradouro = @logradouro, end_numero = @numero, end_observacoes = @observacoes, bairro_bai_id = @bairro WHERE end_id = @id", param) > 0;

            Db.fechar();

            return ret;
        }

        public bool excluirEndereco(Endereco e)
        {
            Db.abrir();

            var param = mapearParametros(e);

            bool ret = Db.executarNonQuery("DELETE FROM endereco WHERE end_id = @id", param) > 0;

            Db.fechar();

            return ret;
        }
    }
}
