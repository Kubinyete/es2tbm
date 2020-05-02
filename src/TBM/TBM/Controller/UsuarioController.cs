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
                dgv.Rows.Add(item.Username, 
                    item.Funcionario.Nome, 
                    item.Ativado == true ? "Ativado" : "Desativado");
            }
        }
        public void showInfoMessageBox(string sub, string msg)
        {
            MessageBox.Show(sub, msg,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
