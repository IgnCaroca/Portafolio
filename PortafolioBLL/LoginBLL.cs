using Comun.Cache;
using PortafolioDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioBLL
{
    public class LoginBLL
    {
        LoginDAL login = new LoginDAL();
        public bool LoginUser(string usuario, string clave)
        {
            return login.Login(usuario, clave);
        }
        public void Roles()
        {
            if (UserLoginCache.Rol_fk == Rol_fky.Administrador)
            {

            }
            if (UserLoginCache.Rol_fk == Rol_fky.Cliente)
            {

            }
        }
    }
    
}
