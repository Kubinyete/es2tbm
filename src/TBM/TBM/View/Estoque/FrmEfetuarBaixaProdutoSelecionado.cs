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
    public partial class FrmEfetuarBaixaProdutoSelecionado : Form
    {
        public FrmEfetuarBaixaProdutoSelecionado()
        {
            InitializeComponent();
        }

        private void FrmEfetuarBaixaProdutoSelecionado_Load(object sender, EventArgs e)
        {
            CarregarAtributos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarAtributos()
        {
            Controller.EstoqueController.carregarComponentes(
                tbNomeProduto,
                cbUnidadeMedida,
                lblRestante, 
                numQuantidade
                );
        }

        private void RegistrarBaixa()
        {
            Model.RegistroBaixa regBaixa =
            Controller.EstoqueController.montarObjeto(
                tbObservacoes.Text,
                (int)numQuantidade.Value);
            Controller.EstoqueController.registrarBaixa(
                regBaixa
                );
        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            Controller.EstoqueController.atualizarLabel(lblRestante, 
                (int)numQuantidade.Value); 
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrarBaixa();
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
