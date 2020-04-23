using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TBM.DAL
{
    public class PersistenciaFactory
    {
        private static readonly dynamic json = JsonConvert.DeserializeObject(File.ReadAllText(@"./config.json"));

        public static Persistencia criarConexaoPersistencia()
        {
            return new MySQLPersistencia(
                (string)json.database.connectionString
            );
        }
    }
}
