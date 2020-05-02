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
using TBM.BL.Errors;

namespace TBM.View
{
    public partial class frmCliente : Form
    {
        private Cliente _cliente;

        protected Cliente Cliente { get => _cliente; set => _cliente = value; }
        protected Cliente clienteConfirmado { get => _cliente; set => _cliente = value; }

        public frmCliente(Cliente c = null)
        {
            InitializeComponent();

            Cliente = c;

            string actionStr = Cliente == null ? "Cadastrar novo" : "Alterar";

            Text = Text.Replace("%action%", actionStr);
            lblTitulo.Text = lblTitulo.Text.Replace("%action%", actionStr);
            btnAction.Text = btnAction.Text.Replace("%action%", actionStr);
            btnExcluir.Enabled = Cliente != null;
        }

        private void preencherDados(Cliente c)
        {
            cbEndereco.Items.Clear();

            if (c != null)
            {
                tbCpf.Text = c.Cpf;
                tbRg.Text = c.Rg;
                tbNome.Text = c.Nome;
                tbEmail.Text = c.Email;
                tbTelefone.Text = c.Telefone;
                
                checkDataNascimento.Checked = c.Data_nascimento.HasValue;
                
                if (checkDataNascimento.Checked)
                    dtpDataNascimento.Value = (DateTime)c.Data_nascimento;

                if (c.Endereco != null)
                {
                    cbEndereco.Items.Add(c.Endereco);
                    cbEndereco.SelectedIndex = 0;
                }
            } 
            else
            {
                tbCpf.Enabled = true;
                dtpDataNascimento.Value = DateTime.Today;
                checkDataNascimento.Checked = false;
            }
        }

        private Cliente obterDadosPreenchidos()
        {
            Cliente e = Cliente;

            if (e == null)
                e = new Cliente();

            e.Cpf = ControlUteis.obterStringSemMascara(tbCpf);
            e.Rg = ControlUteis.obterStringSemMascara(tbRg);
            e.Nome = tbNome.Text;
            e.Endereco = (Endereco)cbEndereco.SelectedItem;
            e.Data_nascimento = checkDataNascimento.Checked ? dtpDataNascimento.Value : (DateTime?)null;
            e.Email = tbEmail.Text;
            e.Telefone = ControlUteis.obterStringSemMascara(tbTelefone);

            return e;
        }

        public Cliente exibirComRetorno()
        {
            ShowDialog();

            return clienteConfirmado;
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            Endereco novo = new frmGerenciarEnderecos().exibirComRetorno();

            if (novo != null)
            {
                cbEndereco.Items.Clear();
                cbEndereco.Items.Add(novo);
                cbEndereco.SelectedIndex = 0;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o registro atual?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new BLCliente().removerCliente(Cliente);
                    Close();
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
                catch (Exception err)
                {
                    MessageBox.Show(
                        String.Format("Não foi possível excluir o registro da base de dados:\n{0}.", err.Message),
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs ev)
        {
            BLCliente bl = new BLCliente();
            Cliente e = obterDadosPreenchidos();

            if (e != null)
            {
                try
                {
                    if (Cliente != null && bl.atualizarCliente(e) || Cliente == null && bl.cadastrarCliente(e))
                    {
                        clienteConfirmado = e;

                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Não foi possível atualizar o registro na base de dados.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
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
                catch (Exception err)
                {
                    MessageBox.Show(
                        String.Format("Não foi possível atualizar o registro na base de dados:\n{0}.", err.Message),
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            preencherDados(Cliente);
        }

        private void checkDataNascimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataNascimento.Enabled = checkDataNascimento.Checked;
        }
    }
}
