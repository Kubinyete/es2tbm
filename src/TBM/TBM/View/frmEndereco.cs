using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TBM.BL;
using TBM.BL.Errors;
using TBM.Model;

namespace TBM.View
{
    public partial class frmEndereco : Form
    {
        private Endereco _endereco;
        private Bairro _bairro;

        protected Endereco enderecoConfirmado { get; set; }
        protected Endereco Endereco { get => _endereco; set => _endereco = value; }
        protected Bairro Bairro { get => _bairro; set => _bairro = value; }

        public frmEndereco(Bairro b, Endereco e = null)
        {
            InitializeComponent();

            _bairro = b;
            _endereco = e;

            string actionStr = Endereco == null ? "Cadastrar novo" : "Alterar";

            Text = Text.Replace("%action%", actionStr);
            lblTitulo.Text = lblTitulo.Text.Replace("%action%", actionStr);
            btnAction.Text = btnAction.Text.Replace("%action%", actionStr);
        }

        private void preencherDados(Bairro b, Endereco e = null)
        {
            cbBairro.Items.Clear();
            cbBairro.Items.Add(b);
            cbBairro.SelectedIndex = 0;

            if (e != null)
            {
                tbLogradouro.Text = e.Logradouro;
                tbNumero.Text = e.Numero.ToString();
                tbObservacoes.Text = e.Observacoes;
            }
        }

        private Endereco obterDadosPreenchidos()
        {
            Endereco e = Endereco;

            if (e == null)
                e = new Endereco();

            e.Logradouro = tbLogradouro.Text.Trim();
            
            try
            {
                e.Numero = Convert.ToInt32(tbNumero.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "O número do endereço informado não é um número válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return null;
            }

            e.Observacoes = tbObservacoes.Text;

            e.Bairro = (Bairro)cbBairro.SelectedItem;

            return e;
        }

        private void frmEndereco_Load(object sender, EventArgs e)
        {
            if (Endereco != null)
            {
                btnExcluir.Enabled = true;
            }

            preencherDados(Bairro, Endereco);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o registro atual?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new BLEndereco().removerEndereco(Endereco);
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
            Endereco e = obterDadosPreenchidos();

            if (e == null)
                return;

            BLEndereco bl = new BLEndereco();

            try
            {
                if (Endereco != null && bl.atualizarEndereco(e) || Endereco == null && bl.cadastrarEndereco(e))
                {
                    enderecoConfirmado = e;

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

        public Endereco exibirComRetorno()
        {
            ShowDialog();

            return enderecoConfirmado;
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

        private void tbNumero_KeyUp(object sender, KeyEventArgs e)
        {
            tbNumero.Text = Regex.Replace(tbNumero.Text, @"[^0123456789]", "");
        }
    }
}

