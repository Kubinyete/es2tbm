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
            
        }

        private void tbSrc_TextChanged(object sender, EventArgs e)
        {
            if (bl_func.verificaSrc(tbSrc.Text))
            {
                funcs = null;
                funcs = bl_func.carregarFuncionarios(cbFiltros.SelectedItem.ToString(), 
                    tbSrc.Text);
                dgvFuncionarios.Rows.Clear();
                dgvFuncionarios = control.carregarDataGrid(funcs, dgvFuncionarios);
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int index = dgvFuncionarios.SelectedRows[0].Index;
            if (bl_func.verificaAlt(index))
            {
                FrmCadastroFuncionario.func_escolhido = funcs[index];
                new FrmCadastroFuncionario().Show();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmCadastroFuncionario().Show();
        }
    }
}
