using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.BL.Errors;
using TBM.DAL;
using TBM.Model;

namespace TBM.BL
{
    public class BLContaReceber : BLBase
    {
        public static void verificarConsistencia(List<ContaReceber> l)
        {
            double sum = 0;
            foreach (ContaReceber e in l)
            {
                verificarConsistencia(e);

                sum += e.Valor;
            }

            if (sum > 0 && sum > l[0].Comanda.Com_valor_total)
                throw new BLValidationError("A soma de todas as contas a receber não pode ser maior que o valor total da comanda.");
        }

        public static void verificarConsistencia(ContaReceber e)
        {
            if (e.Comanda == null)
                throw new BLValidationError("É preciso vincular a conta à uma comanda.");

            // @NOTE:
            // Os bancos podem conter data errada, por enquanto vou desativar essa verificação
            //if (e.Data_recebimento.HasValue && e.Data_recebimento.Value < e.Comanda.Com_data_abertura)
            //    throw new BLValidationError("A data de recebimento está inválida.");

            if (DateTime.Now.AddDays(1) > e.Data_vencimento)
                throw new BLValidationError("A data de vencimento precisa estar pelomenos à um dia a frente da data atual.");

            if (!(e.Valor > 0))
                throw new BLValidationError("O valor informado não pode ser igual ou inferior à zero.");
        }

        public bool cadastrarContasReceber(List<ContaReceber> l)
        {
            verificarConsistencia(l);

            return new DALContaReceber(Persistencia).inserirContasReceber(l);
        }
    }
}
