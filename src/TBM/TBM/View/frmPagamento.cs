using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBM.Model;

namespace TBM.View
{
    public partial class frmPagamento : Form
    {
        protected Model.Comanda Comanda;
        protected DateTime DataVencimento;
        protected ContaReceber ContaReceber;

        public frmPagamento(Model.Comanda c, DateTime dataVencimento)
        {
            InitializeComponent();

            Comanda = c;
            DataVencimento = dataVencimento;
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            cbForma.Items.Add(FormaRecebimento.Dinheiro);
            cbForma.Items.Add(FormaRecebimento.Cartao);
            cbForma.SelectedIndex = 0;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(upValor.Value);

            ContaReceber = new ContaReceber(
                0,
                val,
                (FormaRecebimento)cbForma.SelectedItem,
                // Redundante, só está aqui por que DAL pode optar por especificar a data via aplicação.
                DateTime.Now,
                DataVencimento,
                Comanda
            );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Você está prestes a cancelar todas as modificações efetuadas até o momento.",
                "Deseja cancelar a operação atual?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        public ContaReceber exibirComRetorno()
        {
            ShowDialog();

            return ContaReceber;
        }
    }
}
