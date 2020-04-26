using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.DAL;
using TBM.Model;

namespace TBM.BL
{
    class BLPesquisarFuncionario : BLBase
    {
        public BLPesquisarFuncionario(Persistencia p) : base(p)
        {

        }

       public List<Funcionario> carregarFuncionarios(string filtro,string src)
        {
            DAL.DALFuncionario dalfun = new DAL.DALFuncionario(Persistencia);
            if(filtro == "")
            {
                return dalfun.obterFuncionarios("");
            }
            else if(src.Length > 3)
            {
                if (filtro == "Nome")
                    return dalfun.obterFuncionarios("where " +
                        "pessoafisica.pes_nome like '%" + src + "%'");
                else
                    return dalfun.obterFuncionarios("where " +
                        "pessoafisica.pes_cpf like '%" + src + "%'");
            }
            return null;     
        }
        public bool verificaSrc(string src)
        {
            return src.Length > 3;
        }

        public bool verificaAlt(int index)
        {
            return index >= 0;
        }

    }
}
