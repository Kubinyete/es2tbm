using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Cargo
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private double _sal_base;

        public Cargo(int id, string nome, string descricao, double sal_base)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Sal_base = sal_base;
        }

        public Cargo(int id)
        {
            Id = id;
            Nome = "";
            Descricao = "";
            Sal_base = 00.00;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public double Sal_base { get => _sal_base; set => _sal_base = value; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
