using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.Model;
using TBM.DAL;

namespace TBM.BL
{
    public class BLEndereco : BLBase
    {
        public List<Endereco> obterEnderecos(Bairro b)
        {
            return new DALEndereco(Persistencia).obterEnderecos(b);
        }

        public List<Endereco> pesquisarEnderecos(Bairro b, string search)
        {
            return new DALEndereco(Persistencia).procurarEnderecos(b, search);
        }
    }
}
