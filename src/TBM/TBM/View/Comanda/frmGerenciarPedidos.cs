﻿using System;
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
            this.Text = this.Text.Replace("%cmd%", Controller
                .ComandaController
                .comanda.Com_apelido);
            lblAcao.Text = this.lblAcao.Text.Replace("%cmd%", Controller
                .ComandaController
                .comanda.Com_apelido);
            Controller.PedidoController.carregarPedidosDaComanda(dgvPedido);
            lblValorTotal.Text = lblValorTotal.Text.Replace("%total%", Controller
                    .ComandaController.comanda.Com_valor_total.ToString());
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.PedidoController.item =
                (Model.ItemCardapio)dgvCardapio.SelectedRows[0].DataBoundItem;
                new View.Comanda.frmInformacoesPedido().ShowDialog();
                Controller.PedidoController.carregarPedidosDaComanda(dgvPedido);
                Controller.ComandaController.comanda.Com_valor_total +=
                    Controller.PedidoController.ultimoInserido.Ipe_valor_subtotal;
                lblValorTotal.Text = "Total : R$ "+
                    Controller.ComandaController.comanda.Com_valor_total
                    ;
            }catch(Exception err)
            {
                MessageBox.Show("Não há uma prato selecionado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Controller.PedidoController.carregarItemsCardapio(
                dgvCardapio, (Model.CategoriaCardapio)cbCategoria.SelectedItem
                );
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Pedido pedido_escolhido = (Model.Pedido)dgvPedido
                    .SelectedRows[0].DataBoundItem;

                Controller.PedidoController
                    .alterarEstadoPedido(new Model.EstadoPedido(5), pedido_escolhido);

                Controller.PedidoController.atualizarLabel(
                    Controller.ComandaController.comanda.Com_valor_total,
                    pedido_escolhido.Ped_valor_total,
                    "-",
                    lblValorTotal
                    );

                Controller
                    .PedidoController
                    .carregarPedidosDaComanda(dgvPedido);
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "erro", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
