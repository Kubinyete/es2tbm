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

        public void carregarCargoComboBox(List<Model.Cargo> car, ComboBox cb_cargos)
        {
            foreach(var c in car)
            {
                cb_cargos.Items.Add(""+c.Nome);
            }
        }

        public void showInfoMessageBox(string sub, string msg)
        {
            MessageBox.Show(sub, msg,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public string validarDados(string tbNome, MaskedTextBox tbCPF,MaskedTextBox tbRG,string tbSalario,
            int cbEndereco, int cbCargo, DateTime dt_nasc)
        {
            if (tbNome != "" && tbNome.Length > 3)
            {
                if (tbCPF.Text != "" && Uteis.StringUteis.validarCPF(Uteis.ControlUteis.
                    obterStringSemMascara(tbCPF)))
                {
                    if (tbRG.Text != "" && Uteis.StringUteis.validarRG(Uteis.ControlUteis.
                    obterStringSemMascara(tbRG)))
                    {
                        if (tbSalario != "")
                        {
                            try
                            {
                                double b = Convert.ToDouble(tbSalario);
                                if (b > 0)
                                {
                                    if (cbEndereco >= 0 && cbCargo >= 0)
                                    {
                                        TimeSpan tsp = dt_nasc - DateTime.Now;
                                        if(tsp.Days > 0)
                                        {
                                            return "data em formato inválido, verifique novamente";
                                        }
                                        else
                                        { //Botar na camada Negócio
                                            string msg = new BL.BLCadastroeAlteracaoFuncionario(null).validarIdade(dt_nasc) 
                                                == true ? "OK" : "Erro, funcionário deve possuir mais de 16 anos!";
                                            return msg;
                                        }
                                    }
                                    else
                                        return "erro na aplicação!";
                                }
                                else
                                    return "Salário inválido";
                            }
                            catch (Exception e)
                            {
                                return "Salário inválido";
                            }
                        }
                        else
                        {
                            return "Informe o salário!";
                        }
                    }
                    else
                    {
                        return "O RG está em um formato inválido, verifique se inseriu corretamente";
                    }
                }
                else
                {
                    return "O CPF está em um formato inválido, verifique se inseriu corretamente";
                }
            }
            else
            {
                return "Nome inválido, verifique se inseriu corretamente";
            }
            return "OK";
        }
    }
}
