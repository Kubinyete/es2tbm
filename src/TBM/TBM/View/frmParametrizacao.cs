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

namespace TBM.View
{
    public partial class frmParametrizacao : Form
    {
        private Parametrizacao _parametrizacao;

        public Parametrizacao Parametrizacao { get => _parametrizacao; set => _parametrizacao = value; }

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
                    pbLogo.Image = Image.FromStream(new MemoryStream(p.Logomarca));
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
            p.Cnpj = tbCnpj.Text;
            p.Ie = Convert.ToInt64(ControlUteis.obterStringSemMascara(tbInscricaoEstadual));
            p.Email = tbEmail.Text;
            p.Telefone = ControlUteis.obterStringSemMascara(tbTelefone);
            p.Endereco = (Endereco)cbEndereco.SelectedItem;
            p.Logomarca = (byte[])new ImageConverter().ConvertTo(pbLogo.Image, typeof(byte[]));
            p.Logomarca_path = tbCaminhoLogo.Text;

            return p;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Parametrizacao p = obterDadosPreenchidos();

            if (Parametrizacao != null)
            {
                // Alterar os dados    

                // BLParametrizacao.atualizar(p);
            } else
            {
                // Cadastrar os dados

                // Parametrizacao = BLParametrizacao.cadastrar(p);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Dseja cancelar a operação atual?", 
                "Você está prestes a cancelar todas as modificações efetuadas até o momento.", 
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
                    MessageBox.Show("Erro", "Não foi possível carregar a imagem selecionada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
