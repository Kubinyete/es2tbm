using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.Comanda
{
    public partial class frmInformacoesPedido : Form
    {
        public frmInformacoesPedido()
        {
            InitializeComponent();
        }

        private void frmInformacoesPedido_Load(object sender, EventArgs e)
        {
            tbItem.Text = Controller.PedidoController.item.Itc_nome;
            tbPreco.Text = Controller.
                PedidoController.item.Itc_preco.ToString();
        }
    }
}
