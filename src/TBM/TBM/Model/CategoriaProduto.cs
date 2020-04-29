using System;

namespace TBM.Model
{
	public class CategoriaProduto
	{
		//Atributos
		private int _id;
		private String _nome;

		//Contrutores
		public CategoriaProduto()
		{
			Id = 0;
			Nome = "";
		}

		public CategoriaProduto(int id, String nome)
		{
			Id = id;
			Nome = nome;
		}

		//Get's e Set's
		public int Id { get => _id; set => _id = value; }
		public string Nome { get => _nome; set => _nome = value; }
	}
}
