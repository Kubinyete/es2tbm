using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBM.DAL;
using TBM.Model;

namespace TBM
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Model.Parametrizacao p = new DALParametrizacao(PersistenciaFactory.criarConexaoPersistencia()).obterParametrizacao();

            Console.WriteLine(p.ToString());
        }
    }
}
