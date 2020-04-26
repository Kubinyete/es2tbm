using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;
using TBM.DAL;
using TBM.BL.Errors;

namespace TBM.BL
{
    public class BLEndereco : BLBase
    {
        private void verificarConsistencia(Endereco e)
        {
            if (e.Logradouro.Trim().Length < 3)
                throw new BLValidationError("O nome do logradouro precisa ser informado.");

            if (e.Numero <= 0)
                throw new BLValidationError("O número do endereço precisa ser maior que zero.");

            if (e.Bairro == null)
                throw new BLValidationError("O bairro precisa ser informado.");
        }

        public List<Endereco> obterEnderecos(Bairro b)
        {
            return new DALEndereco(Persistencia).obterEnderecos(b);
        }

        public List<Endereco> pesquisarEnderecos(Bairro b, string search)
        {
            return new DALEndereco(Persistencia).procurarEnderecos(b, search);
        }

        public bool cadastrarEndereco(Endereco e)
        {
            verificarConsistencia(e);

            return new DALEndereco(Persistencia).inserirEndereco(e);
        }

        public bool atualizarEndereco(Endereco e)
        {
            verificarConsistencia(e);

            return new DALEndereco(Persistencia).atualizarEndereco(e);
        }

        public bool removerEndereco(Endereco e)
        {
            return new DALEndereco(Persistencia).excluirEndereco(e);
        }
    }
}
