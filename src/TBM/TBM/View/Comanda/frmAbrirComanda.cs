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
    public partial class frmAbrirComanda : Form
    {
        public frmAbrirComanda()
        {
            InitializeComponent();
        }

        private void frmAbrirComanda_Load(object sender, EventArgs e)
        {
            Controller.ComandaController.carregarGarcom(cbGarcom);
            lblAcao.Text = "Abrir Comanda";
            if (Controller.ComandaController.comanda != null)
            {
                tbNumero.Text = Controller.ComandaController
                    .comanda.Com_id.ToString();
                tbNomeIdentificacao.Text = Controller.ComandaController
                    .comanda.Com_apelido;
                tbNumeroMesa.Text = Controller.ComandaController
                    .comanda.Mesa.Mes_id.ToString();
                tbObs.Text = Controller.ComandaController
                    .comanda.Com_observacoes;
                cbGarcom.SelectedIndex = Controller.
                    ComandaController.buscarIndice((List<Model.Funcionario>)
                    cbGarcom.DataSource);
                lblAcao.Text = "Alterar Comanda";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Model.Comanda comanda =
                Controller.ComandaController.montarObjeto(
                    tbNumero.Text,
                    tbNomeIdentificacao.Text,
                    (Model.Funcionario)cbGarcom.SelectedValue,
                    tbObs.Text,
                    Convert.ToInt32(tbNumeroMesa.Text)
                );
            try
            {
                Controller.ComandaController.registrarComanda(comanda);
                this.Close();
            }catch(BL.Errors.BLValidationError error)
            {
                MessageBox.Show(error.Message,"Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
