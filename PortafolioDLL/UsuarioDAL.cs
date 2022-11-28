using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using PortafolioDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortafolioDLL
{
    public class UsuarioDAL
    {
        private ConexionMySql conexion = new ConexionMySql();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select idusuario,nombre,apellido, rut, correo, direccion, fecha_nac, usuario, clave, if(rol_fk = 1, \"Administrador\", \"Cliente\") AS rol from usuario;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarRol()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from rol;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        /*
        public DataTable Existe()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select rut from usuario;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }*/

        public void Guardar(string nombre, string correo, string usuario, string clave, DateTime fecha_nac, string direccion, string rut, string apellido, int rol_fk)
        {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "AgregarUsuarios";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@rut", rut);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@clave", clave);
                comando.Parameters.AddWithValue("@fecha_nac", fecha_nac);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@rol_fk", rol_fk);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            
        }
        public string ObtenerRut(string rut)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ObtenerRut";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("rut", rut);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            return rut;

        }

        public void Editar(string nombre, string correo, string usuario, string clave, DateTime fecha_nac, string direccion, string apellido, int rol_fk, int idusuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@rol_fk", rol_fk);
            comando.Parameters.AddWithValue("@idusuario", idusuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            
        }
        public void CargarRol(int rol)
        {
            string sql = "Select id_rol, rol from rol";
            comando.Connection = conexion.AbrirConexion();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion.AbrirConexion());
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar rol" +ex.Message);
            }
            
            finally
            {
                comando.Connection = conexion.CerrarConexion();
            }
        }
        public void Eliminar(int idusuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idusuario", idusuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
