using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;
using TBM.DAL;

namespace TBM.BL
{
    public class BLCidade : BLBase
    {
        public List<Cidade> obterCidades(Estado e)
        {
            return new DALCidade(Persistencia).obterCidades(e);
        }
    }
}
