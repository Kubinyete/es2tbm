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
    public partial class frmGerenciarPedidos : Form
    {
        public frmGerenciarPedidos()
        {
            InitializeComponent();
        }

        private void frmGerenciarPedidos_Load(object sender, EventArgs e)
        {
            Controller.PedidoController.carregarCbCategorias(cbCategoria);
            Controller.PedidoController.carregarItemsCardapio(
                dgvCardapio, (Model.CategoriaCardapio)cbCategoria.SelectedItem
                );
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            Controller.PedidoController.item =
                (Model.ItemCardapio)dgvCardapio.SelectedRows[0].DataBoundItem;
            new View.Comanda.frmInformacoesPedido().ShowDialog();
        }

        private void cbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Controller.PedidoController.carregarItemsCardapio(
                dgvCardapio, (Model.CategoriaCardapio)cbCategoria.SelectedItem
                );
        }
    }
}
