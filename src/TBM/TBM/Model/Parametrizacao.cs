using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Model
{
    class Parametrizacao
    {
        private int _id;
        private string _nome_fantasia;
        private string _razao_social;
        private string _cnpj;
        private long _ie;
        private string _email;
        private byte[] _logomarca;
        private string _logomarca_path;
        private string _telefone;
        private DateTime _data_ativacao;

        private Endereco _endereco;

        public Parametrizacao(int id, string nome_fantasia, string razao_social, string cnpj, long ie, string email, byte[] logomarca, string logomarca_path, string telefone, DateTime data_ativacao, Endereco endereco)
        {
            Id = id;
            Nome_fantasia = nome_fantasia;
            Razao_social = razao_social;
            Cnpj = cnpj;
            Ie = ie;
            Email = email;
            Logomarca = logomarca;
            Logomarca_path = logomarca_path;
            Telefone = telefone;
            Data_ativacao = data_ativacao;
            Endereco = endereco;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome_fantasia { get => _nome_fantasia; set => _nome_fantasia = value; }
        public string Razao_social { get => _razao_social; set => _razao_social = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public long Ie { get => _ie; set => _ie = value; }
        public string Email { get => _email; set => _email = value; }
        public byte[] Logomarca { get => _logomarca; set => _logomarca = value; }
        public string Logomarca_path { get => _logomarca_path; set => _logomarca_path = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public DateTime Data_ativacao { get => _data_ativacao; set => _data_ativacao = value; }
        public Endereco Endereco { get => _endereco; set => _endereco = value; }
    }
}
