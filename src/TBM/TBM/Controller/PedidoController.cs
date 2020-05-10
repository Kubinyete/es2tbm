using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    public class PedidoController
    {
        public static Model.Comanda comanda = null;
        public static Model.ItemCardapio item = null;

        //Carregar elementos da View
        public static void carregarCbCategorias(ComboBox cbCategorias)
        {
            DAL.DALCategoriaCardapio dalcac = 
                new DAL.DALCategoriaCardapio(DAL
                .PersistenciaFactory.criarConexaoPersistencia());
            cbCategorias.DataSource = dalcac.obtercategorias();
        }

        public static void carregarItemsCardapio(DataGridView dgv_pedidos, Model.CategoriaCardapio catcar)
        {
            DAL.DALItemCardapio dalipro = new DAL.DALItemCardapio(
                DAL.PersistenciaFactory.criarConexaoPersistencia()
                );
            dgv_pedidos.DataSource = dalipro.obterItems(catcar.Cac_id);
        }
    }
}
