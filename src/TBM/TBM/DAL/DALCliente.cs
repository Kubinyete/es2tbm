using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;

namespace TBM.DAL
{
    public class DALCliente : DALBase
    {
        public DALCliente(Persistencia p, bool isSub = false) : base(p, isSub)
        {

        }

        public static Cliente mapearObjeto(DataRow dr, Endereco e = null)
        {
            return new Cliente(
                (string)dr["pes_cpf"],
                dr["pes_rg"] is DBNull ? null : (string)dr["pes_rg"],
                (string)dr["pes_nome"],
                // Pode ser NULL também
                dr["pes_data_nascimento"] is DBNull ? null : (DateTime?)dr["pes_data_nascimento"],
                // Podemos também receber um Cliente sem endereço, se esse for o caso, não tente mapear (resultará em um objeto Endereco com valores NULL)
                e != null ? e : (dr["endereco_end_id"] is DBNull ? null : DALEndereco.mapearObjeto(dr, null)),
                (double)dr["cli_divida_acumulada"]
            );
        }

        public static Dictionary<string, object> mapearParametros(Cliente e)
        {
            var param = criarParametros();
            param.Add("cpf", e.Cpf);
            // Assumir string vazias -> NULL
            param.Add("rg", e.Rg == String.Empty ? null : e.Rg);
            param.Add("nome", e.Nome);
            param.Add("datanascimento", e.Data_nascimento);
            // Podemos ter um Cliente sem endereço...
            param.Add("endereco", e.Endereco?.Id);
            param.Add("dividaacumulada", e.Divida_acumulada);

            return param;
        }

        public List<Cliente> procurarClientes(string buscanome, string buscacpf, string buscarg)
        {
            List<Cliente> ret = new List<Cliente>();

            Db.abrir();

            var param = criarParametros();
            param.Add("bnome", String.Format("%{0}%", buscanome.Replace("%", "%%")));
            param.Add("bcpf", String.Format("%{0}%", buscacpf.Replace("%", "%%")));
            param.Add("brg", String.Format("%{0}%", buscarg.Replace("%", "%%")));

            DataTable dt = Db.executarSelect("SELECT * FROM cliente INNER JOIN pessoafisica ON cliente.pessoafisica_pes_cpf = pessoafisica.pes_cpf LEFT JOIN endereco ON pessoafisica.endereco_end_id = endereco.end_id INNER JOIN bairro ON endereco.bairro_bai_id = bairro.bai_id INNER JOIN cidade ON bairro.cidade_cid_id = cidade.cid_id INNER JOIN estado ON cidade.estado_est_uf = estado.est_uf WHERE pes_nome LIKE @bnome AND pes_cpf LIKE @bcpf AND (pes_rg IS NULL OR pes_rg LIKE @brg);", param);

            foreach (DataRow dr in dt.Rows)
            {
                ret.Add(
                    mapearObjeto(dr)
                );
            }

            Db.fechar();

            return ret;
        }

        public bool inserirCliente(Cliente e)
        {
            Db.abrir();

            var param = mapearParametros(e);

            DataTable dt = Db.executarSelect("CALL cadastrar_cliente(@cpf, @rg, @nome, @datanascimento, @endereco, @result); SELECT @result;", param);

            Db.fechar();


            return dt.Rows.Count == 1 ? ((long)dt.Rows[0]["@result"]) == 1 : false;
        }

        public bool atualizarCliente(Cliente e)
        {
            Db.abrir();

            var param = mapearParametros(e);

            bool ret = Db.executarNonQuery("UPDATE pessoafisica SET pes_rg = @rg, pes_nome = @nome, pes_data_nascimento = @datanascimento, endereco_end_id = @endereco WHERE pes_cpf = @cpf;", param) > 0;
            Db.fechar();

            return ret;
        }
    }
}
