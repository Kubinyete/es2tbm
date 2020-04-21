using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace TBM.DAL
{
    public class MySQLPersistencia : Persistencia
    {
        private MySqlConnection _con;
        private MySqlCommand _cmd;

        public MySQLPersistencia(string connectionString)
        {
            _con = new MySqlConnection(
                connectionString
            );

            _cmd = _con.CreateCommand();

            IsSubContext = false;
        }

        public override void abrir()
        {
            if (_con.State != System.Data.ConnectionState.Open)
            {
                _con.Open();
            }

            // Resetando estado de Comando.

            _cmd.CommandText = String.Empty;
            _cmd.Parameters.Clear();
        }

        public override void fechar()
        {
            if (!IsSubContext)
                _con.Close();
        }

        public override DataTable executarSelect(string select, Dictionary<string, object> parametros = null)
        {
            abrir();
            _cmd.CommandText = select;

            if (parametros != null)
            {
                foreach (var kv in parametros)
                {
                    _cmd.Parameters.AddWithValue(String.Format("@{0}", kv.Key), kv.Value);
                }
            }

            DataTable ret = new DataTable();
            ret.Load(_cmd.ExecuteReader());

            fechar();
            return ret;
        }

        public override int executarNonQuery(string query, Dictionary<string, object> parametros = null)
        {
            abrir();

            if (parametros != null)
            {
                foreach (var kv in parametros)
                {
                    _cmd.Parameters.AddWithValue(String.Format("@{0}", kv.Key), kv.Value);
                }
            }

            _cmd.CommandText = query;
            int lc = _cmd.ExecuteNonQuery();

            fechar();
            return lc;
        }

        public override long obterUltimoId()
        {
            return _cmd.LastInsertedId;
        }
    }
}
