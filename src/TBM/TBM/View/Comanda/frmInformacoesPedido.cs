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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Model.ItemPedido ipe = Controller.PedidoController
                .montarObjeto(tbQuantidade.Text);
            try
            {
                Controller.PedidoController.cadastrarPedido(ipe);
                Controller.PedidoController.ultimoInserido = ipe;
                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (tbQuantidade.Text.Length > 0)
            {
                try
                {
                    Controller.PedidoController.calcularValor(
                        tbQuantidade.Text,
                        lblTotal
                        );
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
                lblTotal.Text = "Total : R$ ";
        }
    }
}
