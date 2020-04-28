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
using TBM.BL;
using TBM.Uteis;

namespace TBM.View
{
    public partial class frmGerenciarClientes : Form
    {
        public frmGerenciarClientes()
        {
            InitializeComponent();
        }

        protected Cliente clienteSelecionado
        {
            get
            {
                return dgvClientes.SelectedRows.Count > 0 ? (Cliente)dgvClientes.SelectedRows[0].DataBoundItem : null;
            }
        }

        protected Cliente clienteConfirmado { get; set; }


        public Cliente exibirComRetorno()
        {
            btnConfirmar.Enabled = true;

            ShowDialog();

            return clienteConfirmado;
        }

        private void carregarClientes(string nome, string cpf, string rg, Cliente prev = null)
        {
            prev = prev == null ? clienteSelecionado : prev;

            dgvClientes.DataSource = new BLCliente().pesquisarClientes(nome, cpf, rg);

            ControlUteis.selecionarEmTabela(dgvClientes, prev);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                clienteConfirmado = clienteSelecionado;
                Close();
            } 
            else
            {
                MessageBox.Show(
                   "É preciso informar selecionar um cliente para poder confirmar a seleção.",
                   "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarClientes(tbNome.Text, ControlUteis.obterStringSemMascara(tbCpf), ControlUteis.obterStringSemMascara(tbRg));
        }

        private void frmGerenciarClientes_Load(object sender, EventArgs e)
        {
            carregarClientes(tbNome.Text, ControlUteis.obterStringSemMascara(tbCpf), ControlUteis.obterStringSemMascara(tbRg));
        }

        private void btnClienteNovo_Click(object sender, EventArgs e)
        {
            Cliente b = new frmCliente().exibirComRetorno();

            carregarClientes(tbNome.Text, ControlUteis.obterStringSemMascara(tbCpf), ControlUteis.obterStringSemMascara(tbRg), b);
        }

        private void btnClienteEditar_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                Cliente b = new frmCliente(clienteSelecionado).exibirComRetorno();

                carregarClientes(tbNome.Text, ControlUteis.obterStringSemMascara(tbCpf), ControlUteis.obterStringSemMascara(tbRg), b);
            }
            else
            {
                MessageBox.Show(
                    "É preciso selecionar um cliente para poder editá-lo.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
