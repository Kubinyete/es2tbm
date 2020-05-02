﻿using System;
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
                // Temos certeza que de um funcionário POSSUI uma data de nascimento!!!
                dtpDtNasc.Value = func_escolhido.Data_nascimento.HasValue ? func_escolhido.Data_nascimento.Value : DateTime.Today;
                lblTitulo.Text = "Alterar Funcionário";
                cbEndereco.SelectedIndex = func_escolhido.Endereco.Id - 1;
                cbCargo.SelectedIndex = func_escolhido.Cargo.Id -4;
                alterando = true;
                this.Text = "Alterar Funcionário";
                tbCPF.Enabled = false;
            }
            else
            {
                this.Text = "Cadastrar Funcionário";
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
            string msg = control.validarDados(tbNome.Text, tbCPF, tbRG, tbSalario.Text,
                cbEndereco.SelectedIndex, cbCargo.SelectedIndex,
                dtpDtNasc.Value);
            if(msg == "OK")
            {
                Model.Funcionario func = new Model.Funcionario(
                        Convert.ToDouble(tbSalario.Text),
                        new Model.Cargo(cbCargo.SelectedIndex + 4),
                        Uteis.ControlUteis.obterStringSemMascara(tbCPF),
                        Uteis.ControlUteis.obterStringSemMascara(tbRG),
                        tbNome.Text.ToUpper(),
                        dtpDtNasc.Value,
                        new Model.Endereco(cbEndereco.SelectedIndex + 1)
                    );
                if (func_escolhido == null)
                    bl_cadalt.inserirFuncionario(func);
                else
                    bl_cadalt.updateFuncionario(func);
                this.Close();
            } else
                control.showInfoMessageBox(msg, "Aviso");
        }   

        private void tbSalario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            new frmGerenciarEnderecos().ShowDialog();
        }

        private void cbEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
