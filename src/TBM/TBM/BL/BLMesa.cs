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
    public class BLMesa : BLBase
    {

        public List<Mesa> obterMesas()
        {
            return new DALMesa(Persistencia).obterMesas();
        }
    }
}
