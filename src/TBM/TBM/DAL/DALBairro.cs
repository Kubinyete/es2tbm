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

        public static Dictionary<string, object> mapearParametros(Bairro b)
        {
            var param = criarParametros();
            param.Add("id", b.Id);
            param.Add("nome", b.Nome);
            param.Add("cidade", b.Cidade.Id);

            return param;
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

        public bool inserirBairro(Bairro b)
        {
            Db.abrir();

            var param = mapearParametros(b);

            bool ret = Db.executarNonQuery("INSERT INTO bairro (bai_nome, cidade_cid_id) VALUES (@nome, @cidade)", param) > 0;

            Db.fechar();

            if (ret)
                b.Id = (int)Db.obterUltimoId();

            return ret;
        }

        public bool atualizarBairro(Bairro b)
        {
            Db.abrir();

            var param = mapearParametros(b);

            bool ret = Db.executarNonQuery("UPDATE bairro SET bai_nome = @nome, cidade_cid_id = @cidade WHERE bai_id = @id", param) > 0;

            Db.fechar();

            return ret;
        }

        public bool excluirBairro(Bairro b)
        {
            Db.abrir();

            var param = mapearParametros(b);

            bool ret = Db.executarNonQuery("DELETE FROM bairro WHERE bai_id = @id", param) > 0;

            Db.fechar();

            return ret;
        }
    }
}
