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
            return new DALBairro(Persistencia).excluirBairro(b);
        }
    }
}
