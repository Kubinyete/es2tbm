using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    class CadastroAlteracaoFuncionarioController
    {
        public CadastroAlteracaoFuncionarioController() { }
        public bool Load(Model.Funcionario f)
        {
            return f == null;
        }

        public void carregarEnderecoComboBox(List<Model.Endereco> len, ComboBox cb_param)
        {
            foreach(var e in len)
            {
                cb_param.Items.Add("" + e.Logradouro+ ", nº "+e.Numero+ "," + 
                e.Bairro.Nome +","+e.Bairro.Cidade.Nome + "," + e.Bairro.Cidade.Estado.Uf);
            }

        }

        public int buscarIndice(List<Model.Cargo> car, Model.Cargo e)
        {
            int index = 0;
            foreach(Model.Cargo c in car)
            {
                if (c.Id == e.Id)
                    return index;
                index++;
            }
            return index;
        }

        public void showInfoMessageBox(string sub, string msg)
        {
            MessageBox.Show(sub, msg,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

 //      ==========    VALIDAR DADOS     =================

        public bool validarNome(string nome)
        {
            return nome != "" && nome.Length > 3;
        }

        public bool validarCPF(string cpf)
        {
            return cpf != "" && Uteis.StringUteis.validarCPF(cpf);
        }

        public bool validarRG(string rg)
        {
            return rg != "" && Uteis.StringUteis.validarRG(rg);
        }

        public bool validarSalario(string salario)
        {
            try
            {
                double b = Convert.ToDouble(salario);
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public bool validarData(DateTime d)
        {
            TimeSpan tsp = d - DateTime.Now;
            return tsp.Days > 0;
        }

        public bool verificarCBs(int a, int b)
        {
            return a >= 0 && b >= 0;
        }

        public bool validarEmail(string email)
        {
            return email != "" || Uteis.StringUteis.
                validarEmail(email);
        }

        public bool validarTelefone(string telefone)
        {
            return telefone != "" || Uteis.StringUteis.
                validarTelefone(telefone);
        }

        //==================================    =======================//

        public string validarDados(string tbNome, MaskedTextBox tbCPF,MaskedTextBox tbRG,string tbSalario,
            int cbEndereco, int cbCargo, DateTime dt_nasc, string tbEmail, string tbTelefone)
        {
            if (!validarNome(tbNome))
            {
                return "Nome inválido, verifique se inseriu corretamente";
            }

            if(!validarCPF(Uteis.ControlUteis.
                obterStringSemMascara(tbCPF)))
            {
                return "O CPF está em um formato inválido, " +
                    "verifique se inseriu corretamente";
            }

            if (!validarRG(tbRG.Text))
            {
                return "O RG está em um formato inválido, verifique se " +
                    "inseriu corretamente";
            }

            if (!validarSalario(tbSalario))
            {
                return "Salário inválido!";
            }

            if (!verificarCBs(cbEndereco, cbCargo))
            {
                return "Não há endereço selecionado!";
            }

            if(!new BL.BLCadastroeAlteracaoFuncionario(null).
                validarIdade(dt_nasc))
            {
                return "Erro, o funcionário deve possuir mais de 16 anos!";
            }

            if (!validarTelefone(tbTelefone))
            {
                return "Telefone em formato inválido!";
            }

            if (!validarEmail(tbEmail))
            {
                return "Email em formato inválido!";
            }

            return "OK";    
        }
    }
}
