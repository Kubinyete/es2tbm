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

        public List<Model.Endereco> obterEnderecos()
        {
            List<Model.Endereco> enderecos = new List<Model.Endereco>();
            enderecos = new DALEndereco(Persistencia).obterEnderecos();
            return enderecos;
        }

        public List<Model.Cargo> obterCargos()
        {
            List<Model.Cargo> cargos = new List<Model.Cargo>();
            cargos = new DALCargo(Persistencia).obterCargos();
            return cargos;
        }
    }
}
