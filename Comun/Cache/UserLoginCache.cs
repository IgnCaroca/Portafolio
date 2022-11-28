using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Cache
{
    public static class UserLoginCache
    {
        public static int Id { get; set;}
        public static string Rut { get; set; }
        public static string Nombre  { get; set; }
        public static string Apellido { get; set; }
        public static string Fecha_nac { get; set; }
        public static string Correo { get; set; }
        public static string Direccion { get; set; }
        public static string Usuario { get; set; }
        public static string Clave { get; set; }
        public static int Rol_fk { get; set; }


    }
}
