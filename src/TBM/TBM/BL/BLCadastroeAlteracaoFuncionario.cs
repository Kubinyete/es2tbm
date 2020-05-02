using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.DAL;

namespace TBM.BL
{
    class BLCadastroeAlteracaoFuncionario : BLBase
    {
        public BLCadastroeAlteracaoFuncionario(Persistencia p) : base(p) { }

        public List<Model.Cargo> obterCargos()
        {
            List<Model.Cargo> cargos = new List<Model.Cargo>();
            cargos = new DALCargo(Persistencia).obterCargos();
            return cargos;
        }

        public string inserirFuncionario(Model.Funcionario f)
        {
            if (new DAL.DALFuncionario(Persistencia).inserirFuncionario(f))
                return "Inserido com sucesso!";
            else
                return "Erro na conexão com o banco de dados";
        }

        public string updateFuncionario(Model.Funcionario f)
        {
            if (new DAL.DALFuncionario(Persistencia).atualizarFuncionario(f))
                return "Atualizado com sucesso";
            else
                return "Erro ao atualizar no banco de dados!";
        }

        public bool validarIdade(DateTime datanasc)
        {
            return (DateTime.Now.Year - datanasc.Year) > 16;
        }
    }
}
