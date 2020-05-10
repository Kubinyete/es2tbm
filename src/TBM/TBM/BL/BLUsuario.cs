using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBM.DAL;

namespace TBM.BL
{
    class BLUsuario : BLBase
    {
        public BLUsuario(Persistencia p) : base(p)
        {}

        public List<Model.Usuario> carregarUsuarios()
        {
            return new DAL.DALUsuario(Persistencia).obterUsuarios(null, null);
        }

        public List<Model.Usuario> carregarUsuarios(string filtro,string src)
        {
            if (filtro == "Username")
            {
                return new DAL.DALUsuario(Persistencia).obterUsuarios("AND usuario.usr_username " +
                    "like '%"+src+"%'", null); 
            }else
                return new DAL.DALUsuario(Persistencia).obterUsuarios("AND pessoafisica.pes_nome " +
                    "like '%"+src+ "%'", null);
        }

        public bool validarSrc(int value)
        {
            return value > 3;
        }

        public string excluirUsuario(Model.Usuario user)
        {
            return new DAL.DALUsuario(Persistencia).atualizarEstadoUsuario(user, 0);
        }

        public string ativarUsuario(Model.Usuario user)
        {
            return new DAL.DALUsuario(Persistencia).atualizarEstadoUsuario(user, 1);
        }

    }
}
