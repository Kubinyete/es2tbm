using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;
using TBM.BL.Errors;
using TBM.Uteis;
using TBM.DAL;

namespace TBM.BL
{
    public class BLCliente : BLBase
    {
        private void verificarConsistencia(Cliente c)
        {
            if (c.Cpf.Length != 11 || !StringUteis.validarCpf(c.Cpf))
                throw new BLValidationError("O CPF informado não é válido.");

            if (c.Rg != null && c.Rg != String.Empty && (c.Rg.Length != 9 || !StringUteis.validarRg(c.Rg)))
                throw new BLValidationError("O RG informado não é válido.");

            if (c.Data_nascimento.HasValue && c.Data_nascimento.Value.AddYears(13) > DateTime.Today)
                throw new BLValidationError("A idade informada não é aceitável para ser registrada no sistema, o mínimo de idade do cliente deve ser de 13 anos.");

            if (c.Divida_acumulada < 0)
                throw new BLValidationError("A divida acumulada informada do cliente não é válida.");

            if (c.Nome.Trim().Length < 3)
                throw new BLValidationError("É preciso informar um nome de cliente de pelomenos 3 caracteres.");

            if (c.Endereco == null)
                throw new BLValidationError("É preciso informar um endereço ao cliente.");
        }

        public bool atualizarCliente(Cliente c)
        {
            verificarConsistencia(c);
            return new DALCliente(Persistencia).atualizarCliente(c);
        }

        public bool cadastrarCliente(Cliente c)
        {
            verificarConsistencia(c);
            return new DALCliente(Persistencia).inserirCliente(c);
        }

        public List<Cliente> pesquisarClientes(string buscanome, string buscacpf, string buscarg)
        {
            return new DALCliente(Persistencia).procurarClientes(buscanome, buscacpf, buscarg);
        }
    }
}
