using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.DAL;
using TBM.Model;
using TBM.BL.Errors;
using TBM.Uteis;

namespace TBM.BL
{
    public class BLParametrizacao : BLBase
    {
        public Parametrizacao obterParametrizacao()
        {
            return new DALParametrizacao(Persistencia).obterParametrizacao();
        }

        private void verificarConsistencia(Parametrizacao p)
        {
            if (p.Nome_fantasia.Trim().Length < 3) 
                throw new BLValidationError("O nome fantasia precisa ser informado.");
            
            if (p.Razao_social.Trim().Length < 3) 
                throw new BLValidationError("A razão social precisa ser informada.");
            
            if (p.Cnpj.Length != 14 || !StringUteis.validarCnpj(p.Cnpj)) 
                throw new BLValidationError("É preciso informar um CNPJ válido.");

            if (!StringUteis.validarEmail(p.Email))
                throw new BLValidationError("É preciso informar um email válido.");

            if (!StringUteis.validarTelefone(p.Telefone) && !StringUteis.validarCelular(p.Telefone))
                throw new BLValidationError("É preciso informar um telefone ou número de celular válido.");

            if (p.Endereco == null)
                throw new BLValidationError("É preciso informar um endereço.");
        }

        public bool atualizarParametrizacao(Parametrizacao p)
        {
            verificarConsistencia(p);
            return new DALParametrizacao(Persistencia).atualizarParametrizacao(p);
        }

        public bool cadastrarParametrizacao(Parametrizacao p)
        {
            verificarConsistencia(p);
            return new DALParametrizacao(Persistencia).inserirParametrizacao(p);
        }

        public Parametrizacao cadastrarParametrizacao(string nome_fantasia, string razao_social, string cnpj, long ie, string email, byte[] logomarca, string logomarca_path, string telefone, DateTime data_ativacao, Endereco endereco)
        {
            var p = new Parametrizacao(
                0,
                nome_fantasia,
                razao_social,
                cnpj,
                ie,
                email,
                logomarca,
                logomarca_path,
                telefone,
                data_ativacao,
                endereco
            );

            return cadastrarParametrizacao(p) ? p : null;
        }
    }
}
