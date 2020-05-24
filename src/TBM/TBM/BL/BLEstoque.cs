using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.BL
{
    public class BLEstoque : BLBase
    {
        public void registrarBaixa(Model.RegistroBaixa rb)
        {
            DAL.DALRegistroBaixa dalreg =
            new DAL.DALRegistroBaixa(Persistencia);
            if ((rb.Produto.Pro_quantidade - rb.Reg_quantidade)
                < rb.Produto.Pro_quantidade_minima)
            {
                if(MessageBox.Show("A quantidade em estoque será" +
                    " menor que a mínima","Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    dalreg.inserirBaixa(rb);
                }
            }
            else
            {
                dalreg.inserirBaixa(rb);
            }
        }

        public void cancelarBaixa(Model.RegistroBaixa rb)
        {
            DAL.DALRegistroBaixa dalreg_baixa =
            new DAL.DALRegistroBaixa(Persistencia);
            if(MessageBox.Show(
                "Deseja realmente cancelar a baixa realizada?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dalreg_baixa.removerBaixa(rb);
            }
        }
    }

}
