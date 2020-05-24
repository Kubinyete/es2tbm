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
            #region carregamento das grids e checkbox
            Controller.PedidoController.carregarCbCategorias(cbCategoria);

            carregarItemsCardapioView();
            carregarPedidosView();

            #endregion

            #region carregar textos
            this.Text = this.Text.Replace("%cmd%", Controller
                .ComandaController
                .comanda.Com_apelido);
            lblAcao.Text = this.lblAcao.Text.Replace("%cmd%", "Comanda Nº" +
                Controller.ComandaController.comanda.Com_id + " - " +
                Controller
                .ComandaController
                .comanda.Com_apelido + " - Mesa " + Controller
                .ComandaController
                .comanda.Mesa.Mes_id);
            lblValorTotal.Text = lblValorTotal.Text.Replace("%total%", Controller
                    .ComandaController.comanda.Com_valor_total.ToString("N2"));
            #endregion
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.PedidoController.item =
                (Model.ItemCardapio)dgvCardapio.SelectedRows[0].DataBoundItem;
                new View.Comanda.frmInformacoesPedido().ShowDialog();
                carregarPedidosView();

                if (Controller
                    .PedidoController.ultimoInserido != null)
                {
                    atualizarValorTotalView(Controller
                        .PedidoController.ultimoInserido.Pedido, "+");
                }
            }catch(Exception err)
            {
                MessageBox.Show("Não há uma prato selecionado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            carregarItemsCardapioView();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Pedido pedido_escolhido = (Model.Pedido)dgvPedido
                    .SelectedRows[0].DataBoundItem;

                Controller.PedidoController
                    .alterarEstadoPedido(new Model.EstadoPedido(5), pedido_escolhido);

                atualizarValorTotalView(pedido_escolhido,"-");

                carregarPedidosView();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "erro", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cbOcultarPedidosCancelados_CheckedChanged(object sender, EventArgs e)
        {
            carregarPedidosView();
        }

        private void carregarPedidosView()
        {
            Controller.PedidoController
                .carregarPedidosDaComanda(dgvPedido,
                cbOcultarPedidosCancelados.Checked);
        }

        private void carregarItemsCardapioView()
        {
            Controller.PedidoController.carregarItemsCardapio(
                dgvCardapio,
                (Model.CategoriaCardapio)cbCategoria.SelectedItem
                );
        }

        private void atualizarValorTotalView(Model.Pedido pedido, 
            string operacao)
        {
            if (operacao == "-")
            {
                Controller.PedidoController.atualizarLabel(
                    Controller.ComandaController.comanda.Com_valor_total,
                    pedido.Ped_valor_total,
                    "-",
                    lblValorTotal
                    );
            }
            else
            {
                Controller.PedidoController.atualizarLabel(
                    Controller.ComandaController.comanda.Com_valor_total,
                    pedido.Ped_valor_total,
                    "+",
                    lblValorTotal
                    );
            }
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
