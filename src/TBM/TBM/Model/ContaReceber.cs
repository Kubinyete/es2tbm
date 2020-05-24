using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public enum FormaRecebimento
    {
        Dinheiro = 'D',
        Cartao = 'C',
        Carteira = 'F'
    }

    public class ContaReceber
    {
        private int _id;
        private double _valor;
        private FormaRecebimento _forma_recebimento;
        private DateTime? _data_recebimento;
        private DateTime _data_vencimento;
        private Comanda _comanda;

        public ContaReceber(int id, double valor, FormaRecebimento forma_recebimento, DateTime? data_recebimento, DateTime data_vencimento, Comanda comanda)
        {
            Id = id;
            Valor = valor;
            Forma_recebimento = forma_recebimento;
            Data_recebimento = data_recebimento;
            Data_vencimento = data_vencimento;
            Comanda = comanda;
        }

        public int Id { get => _id; set => _id = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public DateTime? Data_recebimento { get => _data_recebimento; set => _data_recebimento = value; }
        public DateTime Data_vencimento { get => _data_vencimento; set => _data_vencimento = value; }
        public Comanda Comanda { get => _comanda; set => _comanda = value; }
        public FormaRecebimento Forma_recebimento { get => _forma_recebimento; set => _forma_recebimento = value; }
    }
}
