using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    class UsuarioController
    {
        public UsuarioController()
        {

        }

        public void carregarDgv(List<Model.Usuario> obj, DataGridView dgv)
        {
            foreach(var item in obj)
            {
                DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                row.Cells[0].Value = item.Username;
                row.Cells[1].Value = item.Funcionario.Nome;
                row.Cells[2].Value = item.Ativado == true ? "Ativado" : "Desativado";
                dgv.Rows.Add(row);
            }
        }

        public void showInfoMessageBox(string sub, string msg)
        {
            MessageBox.Show(sub, msg,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
