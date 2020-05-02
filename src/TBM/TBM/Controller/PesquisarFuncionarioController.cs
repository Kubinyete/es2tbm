using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    class PesquisarFuncionarioController
    {
        public PesquisarFuncionarioController() { }

        public DataGridView carregarDataGrid(List<Model.Funcionario> obj,DataGridView dgv)
        {
            foreach (Model.Funcionario f in obj)
            {
                dgv.Rows.Add(f.CpfMascarado, 
                    f.Nome, 
                    f.Cargo.Nome, 
                    f.Salario_atual);
            }
            return dgv;
        }

        public void showInfoMessageBox(string sub, string msg)
        {
            MessageBox.Show(sub, msg,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
