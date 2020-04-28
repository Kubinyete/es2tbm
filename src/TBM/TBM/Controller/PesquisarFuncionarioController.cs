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
                DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                row.Cells[0].Value = String.Format("{0:000\.000\.000\-00}");
                row.Cells[0].Value = f.Cpf; 
                row.Cells[1].Value = f.Nome;
                row.Cells[2].Value = f.Cargo.Nome;
                row.Cells[3].Value = f.Salario_atual;
                dgv.Rows.Add(row);
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
