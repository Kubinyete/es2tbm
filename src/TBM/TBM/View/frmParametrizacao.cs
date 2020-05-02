using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TBM.Model;
using TBM.BL;
using TBM.Uteis;
using TBM.BL.Errors;

namespace TBM.View
{
    public partial class frmParametrizacao : Form
    {
        private Parametrizacao _parametrizacao;

        protected Parametrizacao Parametrizacao { get => _parametrizacao; set => _parametrizacao = value; }

        public frmParametrizacao()
        {
            InitializeComponent();
        }

        private void preencherDados(Parametrizacao p)
        {
            if (p != null)
            {
                tbNomeFantasia.Text = p.Nome_fantasia;
                tbRazaoSocial.Text = p.Razao_social;
                tbCnpj.Text = p.Cnpj;
                tbInscricaoEstadual.Text = p.Ie.ToString();
                tbEmail.Text = p.Email;
                tbTelefone.Text = p.Telefone;
                tbCaminhoLogo.Text = p.Logomarca_path ;
                
                cbEndereco.Items.Clear();

                if (p.Endereco != null)
                {
                    cbEndereco.Items.Add(p.Endereco);
                    cbEndereco.SelectedItem = p.Endereco;
                }

                pbLogo.Image = null;

                if (p.Logomarca != null)
                {
                    try
                    {
                        pbLogo.Image = Image.FromStream(new MemoryStream(p.Logomarca));
                    } catch (Exception) {}
                }
            }
        }

        private Parametrizacao obterDadosPreenchidos()
        {
            Parametrizacao p = Parametrizacao;

            if (p == null)
                p = new Parametrizacao();

            p.Nome_fantasia = tbNomeFantasia.Text;
            p.Razao_social = tbRazaoSocial.Text;
            p.Cnpj = ControlUteis.obterStringSemMascara(tbCnpj);
            
            try
            {
                p.Ie = Convert.ToInt64(ControlUteis.obterStringSemMascara(tbInscricaoEstadual));
            } catch
            {
                MessageBox.Show(
                    "O número da IE informado não é um número válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return null;
            }
            
            p.Email = tbEmail.Text;
            p.Telefone = ControlUteis.obterStringSemMascara(tbTelefone);
            p.Endereco = (Endereco)cbEndereco.SelectedItem;
            
            try
            {
                p.Logomarca = pbLogo.Image != null ? (byte[])new ImageConverter().ConvertTo(pbLogo.Image, typeof(byte[])) : null;
            } 
            catch (NotSupportedException)
            {
                p.Logomarca = null;
            }
            
            p.Logomarca_path = tbCaminhoLogo.Text;

            return p;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Parametrizacao p = obterDadosPreenchidos();

            if (p == null)
                return;

            var bl = new BLParametrizacao();

            try
            {
                if (Parametrizacao != null && bl.atualizarParametrizacao(p) || Parametrizacao == null && bl.cadastrarParametrizacao(p))
                {
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
            } catch (Exception err)
            {
                MessageBox.Show(
                    String.Format("Não foi possível atualizar o registro na base de dados:\n{0}.", err.Message),
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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

        private void frmParametrizacao_Load(object sender, EventArgs e)
        {
            Parametrizacao = new BLParametrizacao().obterParametrizacao();

            preencherDados(Parametrizacao);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (ofdAlterar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(ofdAlterar.FileName);

                    if (bytes != null)
                    {
                        pbLogo.Image = Image.FromStream(new MemoryStream(bytes));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível carregar a imagem selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
