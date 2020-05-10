using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBM.View;

namespace TBM
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new frmLogin().ShowDialog();
            if(Controller.LoginController.usuario_logado != null)
                new mainForm().ShowDialog();

            Application.Exit();
        }
    }
}
