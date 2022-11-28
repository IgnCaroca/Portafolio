using MySql.Data.MySqlClient;
using PortafolioDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioDLL
{
    public class ServicioAdicionalDAL
    {
        private ConexionMySql conexion = new ConexionMySql();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarServicios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id_servicio_adicional ,descripcion from servicio_adicional;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public void Guardar(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into `servicio_adicional` (descripcion) values('" + descripcion + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Editar(string descripcion, int id_servicio_adicional)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarServicios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@id_servicio_adicional", id_servicio_adicional);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Eliminar(int id_servicio_adicional)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarServicio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_servicio_adicional", id_servicio_adicional);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
