using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class EstadoPedido
    {
        int _esp_id;
        string _esp_nome;

        public EstadoPedido()
        {
        }

        public EstadoPedido(int esp_id)
        {
            _esp_id = esp_id;
        }

        public EstadoPedido(int esp_id, string esp_nome)
        {
            Esp_id = esp_id;
            Esp_nome = esp_nome;
        }

        public int Esp_id { get => _esp_id; set => _esp_id = value; }
        public string Esp_nome { get => _esp_nome; set => _esp_nome = value; }

        public override string ToString()
        {
            return Esp_nome;
        }
    }
}
