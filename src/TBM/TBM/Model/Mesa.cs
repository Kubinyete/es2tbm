using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Mesa
    {
        string _mes_id;
        string _mes_observacoes;
        int _mes_capacidade;
        bool _mes_disponivel;

        public Mesa(string mes_id, string mes_observacoes, int mes_capacidade, bool mes_disponivel)
        {
            Mes_id = mes_id;
            _mes_observacoes = mes_observacoes;
            _mes_capacidade = mes_capacidade;
            _mes_disponivel = mes_disponivel;
        }

        public Mesa(string mes_id)
        {
            _mes_id = mes_id;
        }

        public string Mes_observacoes { get => _mes_observacoes; set => _mes_observacoes = value; }
        public int Mes_capacidade { get => _mes_capacidade; set => _mes_capacidade = value; }
        public bool Mes_disponivel { get => _mes_disponivel; set => _mes_disponivel = value; }
        public string Mes_id { get => _mes_id; set => _mes_id = value; }

        public override string ToString()
        {
            return _mes_id;
        }
    }
}
