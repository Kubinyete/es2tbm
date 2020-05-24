using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    public class UnidadeMedida
    {
        int _uni_id;
        string _uni_nome;
        string _uni_descricao;

        public UnidadeMedida()
        {
        }

        public UnidadeMedida(int uni_id, string uni_nome, string uni_descricao)
        {
            Uni_id = uni_id;
            Uni_nome = uni_nome;
            Uni_descricao = uni_descricao;
        }

        public int Uni_id { get => _uni_id; set => _uni_id = value; }
        public string Uni_nome { get => _uni_nome; set => _uni_nome = value; }
        public string Uni_descricao { get => _uni_descricao; set => _uni_descricao = value; }
    }
}
