using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.BL.Errors
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
                }catch(BL.Errors.BLValidationError err)
                {
                    throw err;
                }
            }

        }
    }
}
