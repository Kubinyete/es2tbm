using System;

namespace TBM.Model
{
	public class Marca
	{
		//Atributos
		private int _id;
		private String _nome;

		//Contrutores
		public Marca()
		{
			Id = 0;
			Nome = "";
		}

		public Marca(int id, String nome)
        {
			Id = id;
			Nome = nome;
        }

		//Get's e Set's
		public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}
