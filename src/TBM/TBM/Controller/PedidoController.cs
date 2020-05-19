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
        public static Model.ItemCardapio item = null;
        public static Model.ItemPedido ultimoInserido = null;

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

        public static void atualizarLabel(double valor,double valor2, string operacao, 
            Label label)
        {
            double resultado = operacao == "+" ? valor + valor2 : valor - valor2;
            label.Text = "Total : R$ " + resultado;
            Controller
                .ComandaController
                .comanda.Com_valor_total = resultado;
        }

        //Validações e Trabalho com Banco de Dados

        public static void calcularValor(string valor, Label lbltotal)
        {
            try
            {
                int qtde = Convert.ToInt32(valor);
                lbltotal.Text = "Total : R$ " + qtde * item.Itc_preco;
            }catch(Exception e)
            {
                throw new Exception("Quantidade inválida");
            }
        }

        public static void cadastrarPedido(Model.ItemPedido p)
        {
            if(p.Ipe_quantidade < 1)
            {
                throw new Exception("Deve sempre conter um pedido");
            }
            else
            {
                new BL.BLPedido(DAL
                    .PersistenciaFactory
                    .criarConexaoPersistencia())
                    .inserirPedido(p);
            }
        }

        public static void carregarPedidosDaComanda(DataGridView dgvPedidosEfetuados)
        {
            DAL.DALPedido dalped = new DAL.DALPedido(DAL
                .PersistenciaFactory
                .criarConexaoPersistencia());
            dgvPedidosEfetuados.DataSource = dalped.carregarPedidosDaComanda(Controller
                .ComandaController.
                comanda
                .Com_id);
        }

        public static void alterarEstadoPedido(Model.EstadoPedido e_ped, Model.Pedido ped)
        {
            new BL.BLPedido(DAL
                .PersistenciaFactory
                .criarConexaoPersistencia()).alterarEstadoPedido(e_ped, ped);
        }

        //montagem de objeto em memória
        public static Model.ItemPedido montarObjeto(string quantidade
          )
        {
            int qtde = Convert.ToInt32(quantidade);
            return new Model.ItemPedido(
                item,
                new Model.Pedido(
                    0,
                    DateTime.Now,
                    qtde * item.Itc_preco,
                    Controller.ComandaController.comanda,
                    new Model.EstadoPedido(1),
                    qtde, 
                    null
                    ),
                qtde,
                item.Itc_preco,
                item.Itc_preco * qtde
                );
        }
    }
}
