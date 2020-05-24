using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.View.Comanda
{
    public partial class FrmGerenciarComandas : Form
    {
        public int _mesaSelected = 0;
        public int _garcomSelect = 0;
        public FrmGerenciarComandas()
        {
            InitializeComponent(); 
        }

        private void FrmGerenciarComandas_Load(object sender, EventArgs e)
        {
            Controller.ComandaController.carregarGarcom(cbGarcom);
            Controller.ComandaController.carregarMesas(cbMesa);
            try
            {
                Controller.ComandaController.carregarComandas(dgvComandas);
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnabrirComanda_Click(object sender, EventArgs e)
        {
            new View.Comanda.frmAbrirComanda().ShowDialog();
            try
            {
                Controller.ComandaController.carregarComandas(dgvComandas);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.ComandaController.redirecionar(
                    dgvComandas,
                    cbFiltrarMesa.Checked,
                    cbMesa.Text,
                    cbFiltrarGarcom.Checked,
                    cbGarcom.Text,
                    tbBusca.Text
                    );
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnAlterarComanda_Click(object sender, EventArgs e)
        {
            Controller.ComandaController comandaController =
                new Controller.ComandaController();

            if (dgvComandas.SelectedRows.Count > 0)
            {
                comandaController.Comanda =
                    (Model.Comanda)dgvComandas.SelectedRows[0].DataBoundItem;
                new frmAbrirComanda().ShowDialog();
                comandaController.Comanda = null;
                try
                {
                    Controller.ComandaController.carregarComandas(dgvComandas);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Não há uma comanda selecionada",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btnGerenciarPedidos_Click(object sender, EventArgs e)
        {
            Controller.ComandaController.comanda = 
                (Model.Comanda)dgvComandas
                .SelectedRows[0]
                .DataBoundItem;
            new View.Comanda.frmGerenciarPedidos().ShowDialog();
            Controller.ComandaController.carregarComandas(dgvComandas);
        }

        private void btnFecharComanda_Click(object sender, EventArgs e)
        {
            //COLOQUE SUA FUNÇÃO AQUI (Fechar Comanda) 
        }
    }
}
