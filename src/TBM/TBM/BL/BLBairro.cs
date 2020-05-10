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
    public class BLBairro : BLBase
    {
        private void verificarConsistencia(Bairro b)
        {
            if (b.Nome.Trim().Length < 3)
                throw new BLValidationError("O nome do bairro precisa ser informado.");

            if (b.Cidade == null)
                throw new BLValidationError("A cidade precisa ser informada.");
        }

        private void verificarConsistenciaExclusao(Bairro b)
        {
            if (new DALBairro(Persistencia).quantidadeEnderecosBairro(b) > 0)
            {
                throw new BLValidationError("O bairro não pode ser excluido pois existem endereços cadastrados.");
            }
        }

        public List<Bairro> obterBairros(Cidade c)
        {
            return new DALBairro(Persistencia).obterBairros(c);
        }

        public List<Bairro> pesquisarBairros(Cidade c, string search)
        {
            return new DALBairro(Persistencia).procurarBairros(c, search);
        }

        public bool atualizarBairro(Bairro b)
        {
            verificarConsistencia(b);

            return new DALBairro(Persistencia).atualizarBairro(b);
        }

        public bool cadastrarBairro(Bairro b)
        {
            verificarConsistencia(b);

            return new DALBairro(Persistencia).inserirBairro(b);
        }

        public bool removerBairro(Bairro b)
        {
            verificarConsistenciaExclusao(b);

            return new DALBairro(Persistencia).excluirBairro(b);
        }
    }
}
