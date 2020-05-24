using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBM.BL.Errors;
using TBM.Model;

namespace TBM.View
{
    public partial class frmFecharComanda : Form
    {
        private readonly string _defaultFooterText;
        private string DefaultFooterText => _defaultFooterText;

        private Model.Comanda Comanda { get; set; }
        private List<ContaReceber> Contas { get; set; }

        private ContaReceber ContaSelecionada => dgvPagamentos.SelectedRows.Count > 0 ? (ContaReceber)dgvPagamentos.SelectedRows[0].DataBoundItem : null;

        public frmFecharComanda(Model.Comanda c)
        {
            InitializeComponent();

            Comanda = c;
            Contas = new List<ContaReceber>();

            _defaultFooterText = lblDadosTotal.Text;
        }

        private void frmFecharComanda_Load(object sender, EventArgs e)
        {
            if (Comanda != null)
            {
                if (Comanda.Com_data_fechamento.HasValue)
                {
                    // Está fechada
                    Text = "Detalhes da comanda fechada";
                    lblTitulo.Text = Text;
                    btnSelecionarCliente.Enabled = false;
                    upValor.Enabled = false;
                    cbForma.Enabled = false;
                    dtpVencimento.Enabled = false;
                    btnAdicionar.Enabled = false;
                    btnRemover.Enabled = false;
                    dgvPagamentos.Enabled = false;
                    btnAction.Enabled = false;
                    checkBox1.Enabled = false;
                }

                preencherDados(Comanda);
                preencherTabelas(Comanda);
            } 
            else
            {
                MessageBox.Show("A tela de fechar comanda precisa receber uma comanda válida com argumento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void preencherDados(Model.Comanda c)
        {
            tbComanda.Text = c.Com_id.ToString();
            
            cbMesa.Items.Clear();
            cbMesa.Items.Add(c.Mesa);
            cbMesa.SelectedIndex = 0;
            
            tbApelido.Text = c.Com_apelido != null ? c.Com_apelido : tbApelido.Text;
            
            cbGarcom.Items.Clear();
            cbGarcom.Items.Add(c.Funcionario);
            cbGarcom.SelectedIndex = 0;

            cbForma.Items.Clear();
            cbForma.Items.Add(FormaRecebimento.Dinheiro);
            cbForma.Items.Add(FormaRecebimento.Cartao);
            cbForma.SelectedIndex = 0;

            if (c.Cliente != null)
            {
                cbCliente.Items.Clear();
                cbCliente.Items.Add(c.Cliente);
                cbCliente.SelectedIndex = 0;
            }

            upValor.Value = Convert.ToDecimal(c.Com_valor_total);
        }

        private void preencherTabelas(Model.Comanda c)
        {
            int qtd = 0;
            var l = new BL.BLItemPedido().obterItemsPedido(c);

            foreach (var i in l)
            {
                qtd += i.Quantidade;
            }

            dgvPedidos.DataSource = l;

            lblDadosTotal.Text = DefaultFooterText.Replace(
                "%qtd%", qtd.ToString()
            ).Replace(
                "%total%", Comanda.Com_valor_total.ToString()
            );

            dgvPagamentos.DataSource = preencherRestanteEmCarteira(Contas);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (obterSomaContas(Contas) < Comanda.Com_valor_total && (Cliente)cbCliente.SelectedItem == null && !checkBox1.Checked)
            {
                MessageBox.Show(
                    "É preciso vincular um cliente a esta comanda para poder fechá-la com uma conta de recebimento em cateira pendente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                if (!new BL.BLComanda().fecharComanda(Comanda, dtpVencimento.Value, Contas, (Cliente)cbCliente.SelectedItem))
                {
                    MessageBox.Show(
                        "Não foi possível atualizar o registro na base de dados.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                } else
                {
                    Close();
                }
            } 
            catch (BLValidationError err)
            {
                MessageBox.Show(
                    err.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            /*catch (Exception err)
            {
                MessageBox.Show(
                    String.Format("Não foi possível atualizar o registro na base de dados:\n{0}.", err.Message),
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }*/
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

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            Model.Cliente c = new frmGerenciarClientes().exibirComRetorno();

            if (c != null)
            {
                cbCliente.Items.Clear();
                cbCliente.Items.Add(c);
                cbCliente.SelectedIndex = 0;
            }
        }

        private List<ContaReceber> preencherRestanteEmCarteira(List<ContaReceber> l)
        {
            double sum = 0;

            foreach (var c in l)
            {
                sum += c.Valor;
            }

            if (sum < Comanda.Com_valor_total)
            {
                var copy = new List<ContaReceber>(l);
                
                copy.Add(
                    new ContaReceber(
                        0,
                        Comanda.Com_valor_total - sum,
                        FormaRecebimento.Carteira,
                        null,
                        dtpVencimento.Value,
                        Comanda
                    )
                );

                return copy;
            } 
            else
            {
                return l;
            }
        }

        private double obterSomaContas(List<ContaReceber> l)
        {
            double sum = 0;

            foreach (var c in l)
            {
                sum += c.Valor;
            }

            return sum;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ContaReceber nova = new ContaReceber(
                0,
                Convert.ToDouble(upValor.Value),
                (FormaRecebimento)cbForma.SelectedItem,
                (FormaRecebimento)cbForma.SelectedItem == FormaRecebimento.Carteira ? (DateTime?)null : DateTime.Now,
                dtpVencimento.Value,
                Comanda
            );

            if (nova.Valor + obterSomaContas(Contas) <= Comanda.Com_valor_total)
            {
                Contas.Add(nova);
                dgvPagamentos.DataSource = preencherRestanteEmCarteira(Contas);
            } 
            else
            {
                MessageBox.Show(
                    "O valor informado ultrapassa o valor total da comanda.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var sel = ContaSelecionada;

            if (sel != null)
            {
                if (sel.Forma_recebimento != FormaRecebimento.Carteira)
                {
                    Contas.Remove(sel);
                    dgvPagamentos.DataSource = preencherRestanteEmCarteira(Contas);
                }
            } 
            else
            {
                MessageBox.Show(
                    "É preciso selecionar um pagamento para removê-lo.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnSelecionarCliente.Enabled = !checkBox1.Checked;

            if (!checkBox1.Checked)
            {
                cbCliente.Items.Clear();
            }
        }
    }
}
