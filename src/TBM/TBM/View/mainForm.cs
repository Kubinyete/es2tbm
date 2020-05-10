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
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Controller.mainController.montarTela(Controller.LoginController.usuario_logado,  
                this);  //vamos montar a tela do usuário, primeiramente, passo a tela atual e o 
            //usuário que está logado

            // atualizarContextoUsuario();

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
            Text = Text.Replace("%nome%", p.Nome_fantasia);
            lblNomeInferior.Text = lblNomeInferior.Text.Replace("%nome%", p.Nome_fantasia).Replace("%cnpj%", p.Cnpj).Replace("%hoje%", DateTime.Now.ToString("dd/MM/yyyy"));

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

        private void abrirComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Comanda.frmAbrirComanda().Show();
        }

        private void efetuarBaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Estoque.FrmEfetuarBaixaDeProduto().Show();
        }

        private void comandaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void telaGerenciarComandaExperimentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Comanda.FrmGerenciarComandas().Show();
        }
    }
}
