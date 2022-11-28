using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using MySql.Data.MySqlClient;
using PortafolioDLL;

namespace PortafolioBLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public DataTable MostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = usuarioDAL.Mostrar();
            return tabla;
        }
        public string ObtenerRut(string rut)
        {
            usuarioDAL.ObtenerRut(rut);
            return rut;
        }
        /*
        public DataTable ExisteRut()
        {
            DataTable tabla = new DataTable();
            tabla = usuarioDAL.Existe();
            return tabla;
        }*/
        public DataTable MostrarRol()
        {
            DataTable tabla = new DataTable();
            tabla = usuarioDAL.MostrarRol();
            return tabla;
        }

        public void AgregarUsuario(string nombre, string correo, string usuario, string clave, DateTime fecha_nac , string direccion , string rut, string apellido, int rol_fk)
        {
            usuarioDAL.Guardar(nombre, correo,usuario,clave,fecha_nac,direccion,rut, apellido, Convert.ToInt32(rol_fk));
        }
        public void EditarUsuario(string nombre, string correo, string usuario, string clave, DateTime fecha_nac, string direccion, string apellido, int rol_fk, int idusuario)
        {
            usuarioDAL.Editar(nombre, correo, usuario, clave, fecha_nac, direccion, apellido, Convert.ToInt32(rol_fk), Convert.ToInt32(idusuario)) ;

        }
        public void EliminarUsuario(string idusuario)
        {
            usuarioDAL.Eliminar(Convert.ToInt32(idusuario));
        }
        public void CargarRol(int rol)
        {
            usuarioDAL.CargarRol(rol);
            

        }
    }
}
