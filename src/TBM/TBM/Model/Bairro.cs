﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class Bairro
    {
        private int _id;
        private string _nome;

        private Cidade _cidade;

        public Bairro(int id, string nome, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            Cidade = cidade;
        }

        public Bairro()
        {
            Id = 0;
            Nome = String.Empty;
            Cidade = null;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public Cidade Cidade { get => _cidade; set => _cidade = value; }

        public override string ToString()
        {
            return Nome;
        }

        public bool Equals(Bairro obj)
        {
            return Id == obj.Id;
        }
    }
}
