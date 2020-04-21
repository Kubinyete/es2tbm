using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace TBM.DAL
{
    public abstract class Persistencia
    {
        private bool _isSubContext;
        public bool IsSubContext { get => _isSubContext; set => _isSubContext = value; }

        public abstract void abrir();

        public abstract void fechar();

        public abstract DataTable executarSelect(string select, Dictionary<string, object> parametros = null);

        public abstract int executarNonQuery(string query, Dictionary<string, object> parametros = null);

        public abstract long obterUltimoId();
    }
}
