using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.DAL;

namespace TBM.BL
{
    public abstract class BLBase
    {
        private Persistencia _persistencia;

        public BLBase(Persistencia p = null)
        {
            Persistencia = p != null ? p : PersistenciaFactory.criarConexaoPersistencia();
        }

        protected Persistencia Persistencia { get => _persistencia; private set => _persistencia = value; }
    }
}
