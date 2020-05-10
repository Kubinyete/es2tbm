using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Comanda
    {
        int _com_id;
        string _com_apelido;
        string _com_observacoes;
        double _com_valor_total;
        DateTime _com_data_abertura;
        Funcionario _funcionario;
        Cliente _cliente;
        Mesa _mesa;

        public Comanda(int com_id, string com_apelido, string com_observacoes,
            double com_valor_total, Funcionario funcionario,
            Cliente cliente, Mesa mesa, DateTime com_data_abertura)
        {
            _com_id = com_id;
            _com_apelido = com_apelido;
            _com_observacoes = com_observacoes;
            _com_valor_total = com_valor_total;
            _funcionario = funcionario;
            _cliente = cliente;
            _mesa = mesa;
            Com_data_abertura = com_data_abertura;
        }

        public int Com_id { get => _com_id; set => _com_id = value; }
        public string Com_apelido { get => _com_apelido; set => _com_apelido = value; }
        public string Com_observacoes { get => _com_observacoes; set => _com_observacoes = value; }
        public double Com_valor_total { get => _com_valor_total; set => _com_valor_total = value; }
        public Funcionario Funcionario { get => _funcionario; set => _funcionario = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public DateTime Com_data_abertura { get => _com_data_abertura; set => _com_data_abertura = value; }
        internal Mesa Mesa { get => _mesa; set => _mesa = value; }
    }
}
