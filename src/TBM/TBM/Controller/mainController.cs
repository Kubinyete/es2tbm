using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.Controller
{
    public class mainController
    {
        public  mainController(){}

        public static void montarTela(Model.Usuario u, View.mainForm telaPrincipal)
        {
            switch (u.Funcionario.Cargo.NivelAcesso)
            {
                case Model.NivelAcesso.Atendente:
                    telaPrincipal.funcionárioToolStripMenuItem.Dispose();
                    telaPrincipal.usuárioToolStripMenuItem.Dispose();
                    telaPrincipal.parametrizaçãoToolStripMenuItem.Dispose();
                    // telaPrincipal.Container.Remove(telaPrincipal.funcionárioToolStripMenuItem);
                break;
                default:
                break;
            }
        }
    }
}
