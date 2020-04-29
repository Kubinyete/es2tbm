using System;

namespace TBM.Model
{
    public class Fornecedor
    {
        //Atributos
        private String _cnpj;
        private String _nomeFantasia;
        private String _razaoSocial;
        private int _inscrEst;
        private String _email;
        private String _telefone;
        private Endereco _endereco;

        //Construtores
        public Fornecedor()
        {
            _cnpj = "";
            _nomeFantasia = "";
            _razaoSocial = "";
            _inscrEst = 0;
            _email = "";
            _telefone = "";
            _endId = 0;
            _endereco = null;
        }

        public Fornecedor(string cnpj, string nomeFantasia, string razaoSocial, int inscrEst, string email, string telefone, int endId, Endereco endereco)
        {
            _cnpj = cnpj;
            _nomeFantasia = nomeFantasia;
            _razaoSocial = razaoSocial;
            _inscrEst = inscrEst;
            _email = email;
            _telefone = telefone;
            _endId = endId;
            _endereco = endereco;
        }

        //Get's e Set's
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        public int InscrEst { get => _inscrEst; set => _inscrEst = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public int EndId { get => _endId; set => _endId = value; }
        public Endereco Endereco { get => _endereco; set => _endereco = value; }
    }
}