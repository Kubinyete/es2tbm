using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.BL.Errors;
using TBM.Model;

namespace TBM.BL
{
    public class BLComanda : BLBase
    {

        public void verificarConsistencia(Model.Comanda c)
        {
            if (c.Com_apelido.Length < 5)
            {
                throw new BL.Errors.BLValidationError("Nome da comanda muito pequeno");
            }
            else
            {
                try
                {
                    DAL.DALComanda dalcom = new DAL.DALComanda(Persistencia);
                    if (c.Com_id == 0)
                        dalcom.cadastrarComanda(c);
                    else
                        dalcom.atualizarComanda(c);
                } catch (BL.Errors.BLValidationError err)
                {
                    throw err;
                }
            }
        }

        public List<Comanda> obterComandas(Model.Mesa m, string nomeFuncionario) => new DAL.DALComanda(Persistencia).obterComandasv2(m, nomeFuncionario);

        public bool fecharComanda(Model.Comanda c, DateTime dataVencimento, List<ContaReceber> pagamentos, Cliente cli) 
        {
            BL.BLContaReceber.verificarConsistencia(pagamentos);

            if (DateTime.Now.AddDays(1) > dataVencimento)
                throw new BLValidationError("A data de vencimento precisa estar pelomenos à um dia a frente da data atual.");

            bool ok = false;
            
            Persistencia.abrir();
            var t = Persistencia.beginTransaction();

            try 
            {
                ok = new DAL.DALContaReceber(Persistencia, true).inserirContasReceber(pagamentos);

                if (!ok)
                    throw new Exception("Não foi possível inserir os pagamentos.");
                else
                {
                    ok = new DAL.DALComanda(Persistencia, true).fecharComanda(c, dataVencimento, cli);

                    if (ok)
                        t.Commit();
                    else
                        throw new Exception("Não foi possível fechar a comanda.");
                }
            } 
            catch (Exception e) {
                t.Rollback();
                throw e;
            }

            return ok;
        }
    }
}
