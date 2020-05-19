using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBM.DAL
{
    class DALPedido : DALBase
    {
        public DALPedido(Persistencia p) : base(p)
        {

        }

        public static Model.Pedido mapearObjeto(DataRow row)
        {
            return new Model.Pedido(
                Convert.ToInt32(row["ped_id"]),
                Convert.ToDateTime(row["ped_data_efetuado"]),
                Convert.ToDouble(row["ped_valor_total"]),
                Controller.ComandaController.comanda,
                DAL.DALEstadoPedido.mapearObjeto(row),
                DAL.DALItemPedido.mapearObjeto(row).Ipe_quantidade,
                DAL.DALItemPedido.mapearObjeto(row)
                );
        }

        public void inserirPedido(Model.ItemPedido iped)
        {
            string sql = "CALL gerenciar_pedido(@ped_id,@ped_dataefetuado," +
                "@ped_valor_total,@ped_com_id, @ped_estadopedido," +
                "@ipe_item_cardapio, @ipe_pedido_id, @ipe_quantidade, " +
                "@ipe_valor_unitario, @ipe_valor_subtotal);";

            var parametros = criarParametros();
            parametros.Add("@ped_id", iped.Pedido.Ped_id);
            parametros.Add("@ped_dataefetuado", 
                iped.Pedido.Ped_data_efetuado);
            parametros.Add("@ped_valor_total", iped.Pedido.Ped_valor_total);
            parametros.Add("@ped_com_id", iped.Pedido.Pedido_comanda.Com_id);
            parametros.Add("@ped_estadopedido", iped.Pedido.Pedido_estado.Esp_id);
            parametros.Add("@ipe_item_cardapio", iped.Item_cardapio.Itc_id);
            parametros.Add("@ipe_pedido_id", iped.Pedido.Ped_id);
            parametros.Add("@ipe_quantidade", iped.Ipe_quantidade);
            parametros.Add("@ipe_valor_unitario", iped.Ipe_valor_unitario);
            parametros.Add("@ipe_valor_subtotal", iped.Ipe_valor_subtotal);

            try
            {
                Db.executarNonQuery(sql, parametros);
            }catch(MySqlException e)
            {
                throw new Exception("Erro no banco de dados:" + e.Number +
                    "-" + e.Message);
            }
        }

        public List<Model.Pedido> carregarPedidosDaComanda(int com_id)
        {
            List<Model.Pedido> ret = new List<Model.Pedido>();

            string sql = "select pedido.*, itempedido.*,estadopedido.*, itemcardapio.*, comanda.*, categoriacardapio.* from pedido " +
"inner join itempedido on itempedido.pedido_ped_id = pedido.ped_id "+
"inner join estadopedido on estadopedido.esp_id = pedido.estadopedido_esp_id "+
"inner join itemcardapio on itemcardapio.itc_id = itempedido.itemcardapio_itc_id " +
"inner join categoriacardapio on categoriacardapio.cac_id = itemcardapio.categoriacardapio_cac_id " +
"inner join comanda on comanda.com_id = comanda_com_id " +
"where pedido.comanda_com_id = " + com_id;
            try
            {
                DataTable dt = Db.executarSelect(sql);
                foreach(DataRow rows in dt.Rows)
                {
                    ret.Add(mapearObjeto(rows));
                }
            }catch(MySqlException error)
            {
                throw new Exception("Erro no banco de dados:" + error.Number);
            }

            return ret;
        }

        public void alterarEstadoPedido(Model.EstadoPedido esp, Model.Pedido ped)
        {
            string sql = "UPDATE pedido set estadopedido_esp_id = @esp_id " +
                "where ped_id = @ped_id";

            var parametros = criarParametros();
            parametros.Add("@esp_id", esp.Esp_id);
            parametros.Add("@ped_id", ped.Ped_id);

            try
            {
                Db.executarNonQuery(sql, parametros);

            }catch(MySqlException erro)
            {
                throw new Exception("Erro no banco de dados : " + erro.Number);
            }
        }


    }
}
