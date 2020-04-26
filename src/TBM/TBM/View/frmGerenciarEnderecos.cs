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
using TBM.BL.Errors;
using TBM.Model;

namespace TBM.View
{
    public partial class frmGerenciarEnderecos : Form
    {

        public frmGerenciarEnderecos()
        {
            InitializeComponent();
        }

        protected Endereco enderecoConfirmado { get; set; }

        protected Bairro bairroSelecionado
        {
            get
            {
                return dgvBairros.SelectedRows.Count > 0 ? (Bairro)dgvBairros.SelectedRows[0].DataBoundItem : null;
            }
        }

        protected Endereco enderecoSelecionado
        {
            get
            {
                return dgvEnderecos.SelectedRows.Count > 0 ? (Endereco)dgvEnderecos.SelectedRows[0].DataBoundItem : null;
            }
        }

        protected Cidade cidadeSelecionada
        {
            get
            {
                return (Cidade)cbCidade.SelectedItem;
            }
        }

        protected Estado estadoSelecionado
        {
            get
            {
                return (Estado)cbEstado.SelectedItem;
            }
        }

        private void frmGerenciarEnderecos_Load(object sender, EventArgs e)
        {
            cbEstado.DataSource = new BLEstado().obterTodosEstados();
            cbEstado.SelectedIndex = 0;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedItem != null)
            {
                cbCidade.DataSource = new BLCidade().obterCidades((Estado)cbEstado.SelectedItem);
                cbCidade.SelectedIndex = 0;
            }
        }

        private void carregarBairros(Cidade c, Bairro prev = null)
        {
            if (c != null)
            {
                prev = prev == null ? bairroSelecionado: prev;

                dgvBairros.DataSource = new BLBairro().pesquisarBairros(c, tbBairro.Text);

                Uteis.ControlUteis.selecionarEmTabela(dgvBairros, prev);
            }
        }

        private void carregarEnderecos(Bairro b, Endereco prev = null)
        {
            if (b != null)
            {
                prev = prev == null ? enderecoSelecionado : prev;

                dgvEnderecos.DataSource = new BLEndereco().pesquisarEnderecos(b, tbLogradouro.Text);

                Uteis.ControlUteis.selecionarEmTabela(dgvEnderecos, prev);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cidade c = cidadeSelecionada;

            if (c != null)
            {
                carregarBairros(c);
                carregarEnderecos(bairroSelecionado);
            }
            else
            {
                MessageBox.Show(
                    "É preciso informar uma cidade para poder efetuar as pesquisas.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvBairros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarEnderecos(bairroSelecionado);
        }

        public Endereco exibirComRetorno()
        {
            btnConfirmar.Enabled = true;

            ShowDialog();

            return enderecoConfirmado;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (enderecoSelecionado != null)
            {
                enderecoConfirmado = enderecoSelecionado;

                Close();
            }
            else
            {
                MessageBox.Show(
                    "É preciso informar selecionar um endereço para poder confirmar a seleção.",
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

        private void btnBairroNovo_Click(object sender, EventArgs e)
        {
            if (cidadeSelecionada != null)
            {
                Bairro b = new frmBairro(cidadeSelecionada).exibirComRetorno();

                carregarBairros(cidadeSelecionada, b);
            } else
            {
                MessageBox.Show(
                    "É preciso informar uma cidade para poder efetuar o registro de novos bairros.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBairroEditar_Click(object sender, EventArgs e)
        {
            if (bairroSelecionado != null)
            {
                Bairro b = new frmBairro(bairroSelecionado.Cidade, bairroSelecionado).exibirComRetorno();

                carregarBairros(bairroSelecionado.Cidade, b);
            }
            else
            {
                MessageBox.Show(
                    "É preciso selecionar um bairro para poder efetuar a edição.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEnderecoNovo_Click(object sender, EventArgs ev)
        {
            if (bairroSelecionado != null)
            {
                Endereco e = new frmEndereco(bairroSelecionado).exibirComRetorno();

                carregarEnderecos(bairroSelecionado, e);
            }
            else
            {
                MessageBox.Show(
                    "É preciso selecionar um bairro para poder efetuar o registro de endereços.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEnderecoEditar_Click(object sender, EventArgs ev)
        {
            if (enderecoSelecionado != null)
            {
                Endereco e = new frmEndereco(enderecoSelecionado.Bairro, enderecoSelecionado).exibirComRetorno();

                carregarEnderecos(enderecoSelecionado.Bairro, e);
            }
            else
            {
                MessageBox.Show(
                    "É preciso selecionar um endereço para poder efetuar a edição.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
