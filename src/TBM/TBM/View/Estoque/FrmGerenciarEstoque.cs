using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.Estoque
{
    public partial class FrmGerenciarEstoque : Form
    {
        public FrmGerenciarEstoque()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEfetuarBaixaDeProduto_Load(object sender, EventArgs e)
        {
            carregarComboBox();
            carregarDataGrid();
        }

        #region Estoque
        private void btnEfetuarBaixa_Click(object sender, EventArgs e)
        {
            efetuarBaixa();
        }

        private void cbMostrarProdutosSemEstoque_CheckedChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }
        #endregion


        #region Funcoes Secundarias

        public void carregarComboBox()
        {
            Controller.EstoqueController
                .carregarCategorias(cbCategoria);
            Controller.EstoqueController
                .carregarCategorias(cbCategoriaBaixasEfetuadas);
            Controller.EstoqueController.carregarMarcas(cbMarca);
            Controller.EstoqueController
                .carregarMarcas(cbMarcaBaixaEfetuada);
        }

        public void carregarDataGrid()
        {
            Controller
                .EstoqueController
                .carregarProdutosEstoque(dgvProdutosEstoque,
                cbMostrarProdutosSemEstoque.Checked);
            Controller
                .EstoqueController
                .carregarBaixasEstoque(dgvBaixasEfetuadas,false);
        }

        private void pesquisar()
        {
            try
            {
                Controller.EstoqueController.redirecionarPesquisa(
                dgvProdutosEstoque,
                cbMostrarProdutosSemEstoque.Checked,
                cbMarca.Text,
                cbFiltrarMarca.Checked,
                cbCategoria.Text,
                cbFiltrarCategoria.Checked,
                tbPesquisa.Text
                );
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro ao processar pesquisa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pesquisarBaixa()
        {
            try
            {
                Controller.EstoqueController.redirecionarPesquisaBaixa(
                    dgvBaixasEfetuadas,
                    cbFiltrarCategoriaBaixa.Checked,
                    cbCategoriaBaixasEfetuadas.Text,
                    cbFiltrarMarcaBaixa.Checked,
                    cbMarcaBaixaEfetuada.Text,
                    cbFiltrarDataBaixa.Checked,
                    dtpBaixaDataInicial.Value,
                    dtpBaixaDataFinal.Value,
                    tbPesquisaBaixa.Text
                    );
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void efetuarBaixa()
        {
            Controller.EstoqueController.produtoBaixa
                = (Model.Produto)dgvProdutosEstoque
                .SelectedRows[0].DataBoundItem;

            if (Controller.EstoqueController
                .produtoBaixa.Pro_quantidade > 0)
            {
                new FrmEfetuarBaixaProdutoSelecionado().ShowDialog();
                carregarDataGrid();
                Controller.EstoqueController.produtoBaixa
                    = null;
            }
            else
                MessageBox.Show("Não é possível efetuar baixa de um produto sem estoque!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        #endregion

        #region Baixas Efetuadas

        #region Cliques
        private void btnCancelarBaixa_Click(object sender, EventArgs e)
        {
            cancelarBaixa();
            carregarDataGrid();
        }

        private void btnPesquisarBaixa_Click(object sender, EventArgs e)
        {
            pesquisarBaixa();
        }
        #endregion

        #region Ações

        private void cancelarBaixa()
        {
            Model.RegistroBaixa registroBaixa =(Model.RegistroBaixa)
                dgvBaixasEfetuadas.SelectedRows[0].DataBoundItem;
            try
            {
                Controller.EstoqueController.cancelarBaixa(registroBaixa);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

    }
}
