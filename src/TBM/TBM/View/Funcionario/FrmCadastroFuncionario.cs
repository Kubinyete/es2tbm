using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View
{
    public partial class FrmCadastroFuncionario : Form
    {
        public static Model.Funcionario func_escolhido = null;
        private Controller.CadastroAlteracaoFuncionarioController
            control = new Controller.CadastroAlteracaoFuncionarioController();
        private BL.BLCadastroeAlteracaoFuncionario 
            bl_cadalt = new BL.BLCadastroeAlteracaoFuncionario(null);
        private bool alterando = false;

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            control.carregarEnderecoComboBox(bl_cadalt.obterEnderecos(),cbEndereco);
            control.carregarCargoComboBox(bl_cadalt.obterCargos(), cbCargo);
            if (!control.Load(func_escolhido))
            {
                tbNome.Text = func_escolhido.Nome;
                tbCPF.Text = func_escolhido.Cpf;
                tbRG.Text = func_escolhido.Rg;
                tbSalario.Text = func_escolhido.Salario_atual.ToString();
                dtpDtNasc.Value = func_escolhido.Data_nascimento;
                lblTitulo.Text = "Alteração de Funcionário";
                cbEndereco.SelectedIndex = func_escolhido.Endereco.Id;
                cbCargo.SelectedIndex = func_escolhido.Cargo.Id - 1;
                alterando = true;
            }
            else
            {
                lblTitulo.Text = "Cadastro de Funcionário";
                cbEndereco.SelectedIndex = 0;
                cbCargo.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
