using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBM.Controller
{
    public class EstoqueController
    {
        public static Model.Produto produtoBaixa = null;

        #region Efetuar Baixa

        #region Carregamentos Visuais

        #region comboBox
        public static void carregarCategorias(ComboBox cb)
        {
            DAL.DALCategoriaProduto dalcatprod = new
                DAL.DALCategoriaProduto(DAL
                .PersistenciaFactory.criarConexaoPersistencia());
            cb.DataSource = dalcatprod.obterCategoriasDeProduto();   
        }

        public static void carregarMarcas(ComboBox cb)
        {
            DAL.DALMarca dalmarca =
                new DAL.DALMarca(DAL.
                PersistenciaFactory.
                criarConexaoPersistencia());
            cb.DataSource = dalmarca.obterMarcas();
        }
        #endregion

        #region DataGridviews
        public static void carregarProdutosEstoque(DataGridView dgv, 
            bool mostrarSemEstoque, 
            string marca = null, 
            string categoria = null, 
            string busca = null)
        {
            DAL.DALProduto dalprod = new DAL.DALProduto(DAL
                .PersistenciaFactory
                .criarConexaoPersistencia());
            string args = "";
            if (!mostrarSemEstoque)
            {
                args = " where pro_quantidade > 0 ";
                if (marca != null)
                    args += " and marca.mar_nome = @marca ";
                if (categoria != null)
                    args += " and categoriaproduto.cap_nome = @categoria ";
                if (busca != null)
                    args += " and pro_nome like @busca";
            }
            else if (mostrarSemEstoque && (marca != null || categoria != null))
            {
                args = " where ";
                if (marca != null && categoria != null)
                {
                    args += "marca.mar_nome = @marca AND " +
                        "categoriaproduto.cap_nome = @categoria ";
                    if (busca != null)
                    {
                        args += " and pro_nome like @busca";
                    }
                }
                else
                {
                    if (marca != null)
                        args += "marca.mar_nome = @marca";
                    else
                        args += "categoriaproduto.cap_nome = @categoria";

                    if (busca != null)
                        args += " and pro_nome like @busca";
                }

            }
            else if (busca != null)
                args += " and pro_nome like @busca";

            dgv.DataSource = dalprod.obterProdutos(args, marca, categoria, busca);           
        }
        #endregion

        #endregion

        #region Pesquisa

        public static void redirecionarPesquisa(DataGridView dgv,bool mostrarSemEstoque,string marca, bool filtrarMarca, 
            string categoria, bool filtrarCategoria, string busca)
        {
            if (!filtrarMarca)
                marca = null;
            if (!filtrarCategoria)
                categoria = null;
            if (busca == "")
                busca = null;
           
            carregarProdutosEstoque(dgv, mostrarSemEstoque,
                marca, categoria, busca);
        }

        #endregion

        #region Realização de Baixa no estoque


        #region carregamento de componentes visuais
        public static void carregarComponentes(TextBox nomeProduto, 
            ComboBox unidadeMedida, Label lblQuantidade,
            NumericUpDown numup)
        {
            nomeProduto.Text = produtoBaixa.Pro_nome;
            unidadeMedida.Text = produtoBaixa.Unidademedida.Uni_nome;
            lblQuantidade.Text = "Restante em Estoque : " + produtoBaixa.Pro_quantidade + " " +
                produtoBaixa.Unidademedida.Uni_nome;
            numup.Maximum = produtoBaixa.Pro_quantidade;
        }

        public static void atualizarLabel(Label lblQuantidade, int qtde)
        {
            int restante = produtoBaixa.Pro_quantidade - qtde;
            lblQuantidade.Text = "Restante em Estoque : " + restante +
                " " + produtoBaixa.Unidademedida.Uni_nome;
        }
        #endregion

        #region Ação da baixa de estoque
        public static Model.RegistroBaixa montarObjeto(
            string observacao, 
            int quantidade
            )
        {
            return new Model.RegistroBaixa(
                0,
                observacao,
                quantidade,
                DateTime.Now,
                produtoBaixa
                );
        }

        public static void registrarBaixa(Model.RegistroBaixa p)
        {
            new BL.BLEstoque().registrarBaixa(p);
        }

        #endregion

        #endregion

        #endregion

        #region BaixasEfetuadas

        #region visual
        public static void carregarBaixasEstoque(
            DataGridView dgv, 
            bool hasParams
            ,string marca = null, 
            string categoria = null, 
            string busca = null, 
            Model.dataSpan dataSpan = null)
        {
            DAL.DALRegistroBaixa dalreg_baixa = 
            new DAL.DALRegistroBaixa(DAL
            .PersistenciaFactory
            .criarConexaoPersistencia());

            string args = null;

            if (hasParams)
            {
                args = "where ";
                bool firstArg = true;
                if (marca != null)
                {
                    if (!firstArg)
                        args += "AND ";
                   firstArg = false;
                   args += "marca.mar_nome = @marca ";
                }

                if (categoria != null)
                {
                    if (!firstArg)
                        args += "AND ";
                    firstArg = false;
                    args += "categoriaproduto.cap_nome = @categoria ";
                }

                if (busca != null)
                {
                    if (!firstArg)
                        args += "AND ";
                    args += "produto.pro_nome like @busca ";
                    firstArg = false;
                }

                if (dataSpan != null)
                {
                    if (!firstArg)
                        args += "AND ";
                    args += "reg_data_efetuado BETWEEN @data_ini AND @data_fim ";
                    firstArg = false;
                }
            }

            dgv.DataSource = dalreg_baixa.obterRegistroBaixas(args, 
                marca,categoria,dataSpan,busca);
        }

        public static void redirecionarPesquisaBaixa(DataGridView dgv
            ,bool filtrarCategoria, 
            string categoria,
            bool filtrarMarca,
            string marca,
            bool filtrarData, 
            DateTime data_inicial , 
            DateTime data_final,
            string busca
            )
        {
            Model.dataSpan ds = null;
            if (!filtrarCategoria)
                categoria = null;
            if (!filtrarMarca)
                marca = null;
            if (filtrarData)
            {
                TimeSpan ts = data_final - data_inicial;
                if (ts.Days < 0)
                    throw new Exception("A data final é menor que a data inicial");
                else
                    ds = new Model.dataSpan(data_inicial, data_final);
            }

            carregarBaixasEstoque(dgv, true, marca, categoria, busca, ds);
        }
        #endregion

        #region funções

        public static void cancelarBaixa(Model.RegistroBaixa regBaixa)
        {
            new BL.BLEstoque().cancelarBaixa(regBaixa);
        }

        #endregion

        #endregion

    }
}
