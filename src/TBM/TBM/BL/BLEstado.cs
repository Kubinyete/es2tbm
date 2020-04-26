using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;
using TBM.DAL;

namespace TBM.BL
{
    public class BLEstado : BLBase
    {
        public List<Estado> obterTodosEstados()
        {
            return new DALEstado(Persistencia).obterTodosEstados();
        }
    }
}
