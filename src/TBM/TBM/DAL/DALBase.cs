using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TBM.DAL
{
    public abstract class DALBase
    {
        private readonly Persistencia _db;

        public DALBase(Persistencia p, bool isSub = false)
        {
            _db = p;
            _db.IsSubContext = isSub;
        }

        protected Persistencia Db { get => _db;}

        protected static Dictionary<string, object> criarParametros()
        {
            return new Dictionary<string, object>();
        }
    }
}
