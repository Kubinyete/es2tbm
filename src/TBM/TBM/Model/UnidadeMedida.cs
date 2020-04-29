using System;

namespace TBM.Model
{
	public class UnidadeMedida
	{
		//Atributos
		private int _id;
		private String _nome;
		private String _descricao;

		//Contrutores
		public UnidadeMedida()
		{
			Id = 0;
			Nome = "";
			Descricao = "";
		}

		public UnidadeMedida(int id, String nome, String descricao)
		{
			Id = id;
			Nome = nome;
			Descricao = descricao;
		}

		//Get's e Set's
		public int Id { get => _id; set => _id = value; }
		public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
