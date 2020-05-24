using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBM.BL;
using TBM.Model;
using TBM.Uteis;

namespace TBM.View
{
    public partial class frmListarComandasAbertas : Form
    {
        private Model.Comanda ComandaSelecionada => dgvComandas.SelectedRows.Count > 0 ? (Model.Comanda)dgvComandas.SelectedRows[0].DataBoundItem : null;
        private Model.Mesa MesaSelecionada => (Model.Mesa)cbMesa.SelectedItem;

        public frmListarComandasAbertas()
        {
            InitializeComponent();
        }

        private void carregarTabela(Mesa m, string nome)
        {
            Model.Comanda prevSel = ComandaSelecionada;

            dgvComandas.DataSource = new BLComanda().obterComandas(MesaSelecionada, nome);

            ControlUteis.selecionarEmTabela(dgvComandas, prevSel);
        }

        private void frmListarComandasAbertas_Load(object sender, EventArgs e)
        {
            cbMesa.DataSource = new BLMesa().obterMesas();
            cbMesa.SelectedIndex = 0;

            carregarTabela(MesaSelecionada, tbNome.Text);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Model.Comanda sel = ComandaSelecionada;

            if (sel == null)
            {
                MessageBox.Show(
                    "É preciso selecionar uma comanda para poder fechá-la.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            } 
            else
            {
                new frmFecharComanda(sel).ShowDialog();

                carregarTabela(MesaSelecionada, tbNome.Text);
            }
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarTabela(MesaSelecionada, tbNome.Text);
        }
    }
}
