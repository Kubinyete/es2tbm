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
    }
}
