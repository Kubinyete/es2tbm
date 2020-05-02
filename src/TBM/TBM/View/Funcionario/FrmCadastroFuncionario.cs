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

namespace TBM.View
{
    public partial class FrmCadastroFuncionario : Form
    {
        public static Model.Funcionario func_escolhido = null;
        private Controller.CadastroAlteracaoFuncionarioController
            control = new Controller.CadastroAlteracaoFuncionarioController();
        private BL.BLCadastroeAlteracaoFuncionario 
            bl_cadalt = new BL.BLCadastroeAlteracaoFuncionario(null);

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            // control.carregarEnderecoComboBox(bl_cadalt.obterEnderecos(),cbEndereco);
            List<Model.Cargo> cargos = bl_cadalt.obterCargos();
            cbCargo.DataSource = cargos;
            if (!control.Load(func_escolhido))
            {
                tbNome.Text = func_escolhido.Nome;
                tbCPF.Text = func_escolhido.Cpf;
                tbRG.Text = func_escolhido.Rg;
                tbSalario.Text = func_escolhido.Salario_atual.ToString();
                tbEmail.Text = func_escolhido.Email;
                tbTelefone.Text = func_escolhido.Telefone;
                // Temos certeza que de um funcionário POSSUI uma data de nascimento!!!
                dtpDtNasc.Value = func_escolhido.Data_nascimento.HasValue ? func_escolhido.Data_nascimento.Value : DateTime.Today;
                lblTitulo.Text = "Alterar Funcionário";
                //cbEndereco.SelectedIndex = func_escolhido.Endereco.Id - 1;
                //cbCargo.SelectedIndex = func_escolhido.Cargo.Id -4;

                cbEndereco.Items.Clear();
                cbEndereco.Items.Add(func_escolhido.Endereco);
                cbEndereco.SelectedIndex = 0;
                cbCargo.SelectedIndex = control.buscarIndice(cargos, func_escolhido.Cargo);


                this.Text = "Alterar Funcionário";
                tbCPF.Enabled = false;
            }
            else
            {
                this.Text = "Cadastrar Funcionário";
                lblTitulo.Text = "Cadastro de Funcionário";
                cbCargo.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string msg = control.validarDados(tbNome.Text, tbCPF, tbRG, tbSalario.Text,
                cbEndereco.SelectedIndex, cbCargo.SelectedIndex,
                dtpDtNasc.Value, tbEmail.Text, tbTelefone.Text);
            if(msg == "OK")
            {
                Model.Funcionario func = new Model.Funcionario(
                        Convert.ToDouble(tbSalario.Text),
                        (Cargo)cbCargo.SelectedItem,
                        tbEmail.Text,
                        Uteis.ControlUteis.obterStringSemMascara(tbTelefone),
                        Uteis.ControlUteis.obterStringSemMascara(tbCPF),
                        Uteis.ControlUteis.obterStringSemMascara(tbRG),
                        tbNome.Text.ToUpper(),
                        dtpDtNasc.Value,
                        (Endereco)cbEndereco.SelectedItem);
                if (func_escolhido == null)
                    control.showInfoMessageBox(bl_cadalt.inserirFuncionario(func),"Erro");
                else
                    bl_cadalt.updateFuncionario(func);
                this.Close();
            } else
                control.showInfoMessageBox(msg, "Aviso");
        }   

        private void tbSalario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEndereco_Click(object sender, EventArgs ev)
        {
            Endereco e = new frmGerenciarEnderecos().exibirComRetorno();

            if (e != null)
            {
                cbEndereco.Items.Clear();
                cbEndereco.Items.Add(e);
                cbEndereco.SelectedIndex = 0;
            }
        }

        private void cbEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
