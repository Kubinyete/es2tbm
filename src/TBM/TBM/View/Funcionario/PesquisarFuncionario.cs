using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.Funcionario
{
    public partial class PesquisarFuncionario : Form
    {
        private BL.BLPesquisarFuncionario bl_func = new BL.BLPesquisarFuncionario(null);
        List<Model.Funcionario> funcs = null;
        Controller.PesquisarFuncionarioController control = new Controller.PesquisarFuncionarioController();
        public PesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void PesquisarFuncionario_Load(object sender, EventArgs e)
        {
            cbFiltros.SelectedItem = cbFiltros.Items[1];
            funcs = bl_func.carregarFuncionarios("","");
            dgvFuncionarios = control.carregarDataGrid(funcs, dgvFuncionarios);
        }

        private void btnPequisa_Click(object sender, EventArgs e)
        {
            if (bl_func.verificaSrc(tbSrc.Text))
            {
                funcs = null;
                funcs = bl_func.carregarFuncionarios(cbFiltros.SelectedItem.ToString(),
                    tbSrc.Text);
                dgvFuncionarios.Rows.Clear();
                dgvFuncionarios = control.carregarDataGrid(funcs, dgvFuncionarios);
            }
            else
            {
                dgvFuncionarios.Rows.Clear();
                funcs = bl_func.carregarFuncionarios("", "");
                dgvFuncionarios = control.carregarDataGrid(funcs, dgvFuncionarios);
            }
        }

        private void tbSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int index = dgvFuncionarios.SelectedRows.Count > 0 ? dgvFuncionarios.SelectedRows[0].Index : -1;
            if (index >= 0 && index < funcs.Count)
            {
                if (bl_func.verificaAlt(index))
                {
                    FrmCadastroFuncionario.func_escolhido = funcs[index];
                    new FrmCadastroFuncionario().ShowDialog();
                    dgvFuncionarios.Rows.Clear();
                    funcs = bl_func.carregarFuncionarios("", "");
                    dgvFuncionarios = control.carregarDataGrid(funcs, dgvFuncionarios);
                    FrmCadastroFuncionario.func_escolhido = null;
                }
            }
            else
                control.showInfoMessageBox("Deve haver um funcionário selecionado!", "Aviso");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = dgvFuncionarios.SelectedRows.Count > 0 ? dgvFuncionarios.SelectedRows[0].Index : -1;
            if (index >= 0 && index < funcs.Count)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o funcionário selecionado?", "Confirmar Exclusão?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    Model.Funcionario f = funcs[index];
                    bl_func.excluiFuncionario(f);
                    dgvFuncionarios.Rows.Clear();
                    funcs = bl_func.carregarFuncionarios("", "");
                    dgvFuncionarios = control.carregarDataGrid(funcs, dgvFuncionarios);
                }
            }
            else
                control.showInfoMessageBox("Deve haver um funcionário selecionado!", "Erro");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().ShowDialog();
            dgvFuncionarios.Rows.Clear();
            funcs = bl_func.carregarFuncionarios("", "");
            dgvFuncionarios = control.carregarDataGrid(funcs, dgvFuncionarios);
        }

        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
