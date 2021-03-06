﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBM.Model;

namespace TBM.Controller
{
    public class ComandaController
    {
        public static Model.Comanda comanda = null;

        public Comanda Comanda { get => comanda; set => comanda = value; }

        // Funções relacionadas ao Carregamento 
        public static void carregarGarcom(ComboBox cbGarcom)
        {
            DAL.DALFuncionario dalfun = new DAL.DALFuncionario(
                DAL.PersistenciaFactory.criarConexaoPersistencia());
            cbGarcom.DataSource = dalfun.obterGarcons();
        }

        public static void carregarMesas(ComboBox cbMesas)
        {
            DAL.DALMesa dalmesa = new DAL.DALMesa(
                DAL.PersistenciaFactory
                .criarConexaoPersistencia());
            cbMesas.DataSource = dalmesa.obterMesas();
        }

        public static void redirecionar(DataGridView dgvComandas,bool filtrarMesa,string mesa, 
            bool filtrarGarcom, string garcom, string busca)
        {
            if (filtrarMesa && filtrarGarcom)
            {
                carregarComandas(
                    dgvComandas,
                    busca,
                    mesa,
                    garcom
                );
            }
            else
            {
                if (filtrarGarcom && !filtrarMesa)
                {
                    carregarComandas(
                        dgvComandas,
                        busca,
                        null,
                        garcom
                        );
                }
                else
                {
                    carregarComandas(
                        dgvComandas,
                        busca,
                        mesa,
                        null
                        );
                }
            }
        }

        public static void carregarComandas(DataGridView dgvComandas,
            string busca = null,
            string mesa = null, 
            string Garcom = null
            )
        {
            DAL.DALComanda dalcom = new DAL.DALComanda(DAL
                .PersistenciaFactory
                .criarConexaoPersistencia());
            //optei por buscar sem filtros
            if (mesa == null && Garcom == null&&busca==null)
            {
                dgvComandas.DataSource = dalcom.obterComandas();
            }
            else
            {
                string args = "WHERE com_apelido like @busca ";

                if (mesa != null)
                {
                    args += "AND mesa.mes_id = @mesid ";
                }

                if(Garcom!= null)
                {
                    args += "AND pessoafisica.pes_nome = @nome ";
                }
                dgvComandas.DataSource = dalcom.obterComandas(
                    args,
                    busca,
                    mesa,
                    Garcom
                );
            }
        }

        public static int buscarIndice(List<Model.Funcionario> funcionarios)
        {
            int index = 0;
            foreach(Funcionario f in funcionarios)
            {
                if (f.Cpf == comanda.Funcionario.Cpf)
                    return index;
                index++;
            }
            return index;
        }

        // ==========================================================//
        // Funções de controle
        public static void registrarComanda(Model.Comanda c)
        {
            if (c == null)
            {
                throw new BL.Errors.BLValidationError("Comanda Vazia");
            }
            else if(c.Com_apelido == "" || c.Com_apelido == null)
            {
                throw new BL.Errors.BLValidationError("Não é possível inserir uma" +
                    " comanda sem um apelido!");
            }
            else if (!Uteis.StringUteis
                .hasNumersOnly(c.Mesa.Mes_id))
            {
                throw new BL.Errors.BLValidationError("Número da mesa inválido!");
            }
            else
            {
                try{
                    new BL.Errors.BLComanda().verificarConsistencia(c);
                }
                catch (BL.Errors.BLValidationError erro)
                {
                    throw erro;
                }
            }
        }


        // Montar Objetos
        public static Model.Comanda montarObjeto(string comandaNumero, 
            string comandaApelido, Model.Funcionario comandaGarcom, 
            string comandaObservacao, string mesaNumero)
        {
            return new Model.Comanda(
                comandaNumero == "" ? 0 : Convert.ToInt32(comandaNumero),
                comandaApelido,
                comandaObservacao,
                0,
                comandaGarcom,
                null,  //no client
                new Model.Mesa(mesaNumero),
                DateTime.Now
            );
        }

        
    }
}
