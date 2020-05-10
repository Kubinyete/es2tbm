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
using TBM.DAL;
using TBM.Model;
using TBM.BL;

namespace TBM.View
{
    public partial class mainForm : Form
    {
        private readonly string DefaultTitle;
        private readonly string DefaultFooter;

        public mainForm()
        {
            InitializeComponent();

            DefaultTitle = Text;
            DefaultFooter = lblNomeInferior.Text;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Pegar o Usuario logado atualmente...
            // chamar metodo interno atualizarContextoUsuario(usuarioLogado);
            // atualizarContextoUsuario();

            checkEstadoParametrizacao();
        }

        private void checkEstadoParametrizacao()
        {
            var p = new BLParametrizacao().obterParametrizacao();

            if (p == null)
            {
                // Primeiro acesso no sistema, não temos dados parametrizados
                // @TODO: Não deixar cancelar?
                while (p == null)
                {
                    new frmParametrizacao().ShowDialog();

                    p = new BLParametrizacao().obterParametrizacao();
                }

            }

            atualizarDadosParametrizados(p);
        }

        private void atualizarDadosParametrizados(Parametrizacao p)
        {
            Text = DefaultTitle.Replace("%nome%", p.Nome_fantasia);
            lblNomeInferior.Text = DefaultFooter.Replace("%nome%", p.Nome_fantasia).Replace("%cnpj%", p.Cnpj).Replace("%hoje%", DateTime.Now.ToString("dd/MM/yyyy"));

            if (p.Logomarca != null)
            {
                try
                {
                    pbLogo.Image = Image.FromStream(new MemoryStream(p.Logomarca));
                } catch (ArgumentException) { }
            }
        }

        private void atualizarContextoUsuario(Usuario logado)
        {
            // @TODO:
            // Remover opções que não são acessiveis ao usuário atualmente logado...
        }

        private void parametrizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmParametrizacao().ShowDialog();

            // Isso vai forçar que tudo seja recarregado na tela inicial..
            checkEstadoParametrizacao();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Funcionario.PesquisarFuncionario().ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGerenciarClientes().ShowDialog();
        }
        
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Usuarios.PesquisarUsuario().ShowDialog();
        }
    }
}
