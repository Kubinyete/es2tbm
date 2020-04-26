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
using TBM.BL.Errors;
using TBM.Uteis;

namespace TBM.View
{
    public partial class frmBairro : Form
    {
        private Bairro _bairro;
        private Cidade _cidade;

        public frmBairro(Cidade c, Bairro b = null)
        {
            InitializeComponent();

            Bairro = b;
            Cidade = c;

            string actionStr = Bairro == null ? "Cadastrar novo" : "Alterar";

            Text = Text.Replace("%action%", actionStr);
            lblTitulo.Text = lblTitulo.Text.Replace("%action%", actionStr);
            btnAction.Text = btnAction.Text.Replace("%action%", actionStr);
        }

        protected Bairro bairroConfirmado { get; set; }

        protected Bairro Bairro { get => _bairro; set => _bairro = value; }
        protected Cidade Cidade { get => _cidade; set => _cidade = value; }

        private void preencherDados(Cidade c, Bairro b = null)
        {
            cbCidade.Items.Clear();
            cbCidade.Items.Add(c);
            cbCidade.SelectedIndex = 0;

            if (b != null)
            {
                tbNome.Text = b.Nome;
            }
        }

        private Bairro obterDadosPreenchidos()
        {
            Bairro b = Bairro;

            if (b == null)
                b = new Bairro();

            b.Nome = tbNome.Text.Trim();
            b.Cidade = (Cidade)cbCidade.SelectedItem;

            return b;
        }

        private void frmBairro_Load(object sender, EventArgs e)
        {
            if (Bairro != null)
            {
                btnExcluir.Enabled = true;
            }

            preencherDados(Cidade, Bairro);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o registro atual?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new BLBairro().removerBairro(Bairro);
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

        private void btnAction_Click(object sender, EventArgs e)
        {
            BLBairro bl = new BLBairro();
            Bairro b = obterDadosPreenchidos();

            try
            {

                if (Bairro != null && bl.atualizarBairro(b) || Bairro == null && bl.cadastrarBairro(b))
                {
                    bairroConfirmado = b;

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

        public Bairro exibirComRetorno()
        {
            ShowDialog();

            return bairroConfirmado;
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
    }
}
