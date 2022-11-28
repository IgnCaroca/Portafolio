using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PortafolioDAL
{
    public class EdificiosDAL
    {
        private ConexionMySql conexion = new ConexionMySql();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarDepartamentos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from departamento";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarExtras()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from extras_departamento;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public void Guardar(string direccion, string estacionamiento, int num_habitaciones, int extras_departamento_fk, string nombre)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into `departamento` (direccion,estacionamiento,num_habitaciones,extras_departamento_fk, nombre) values('" + direccion + "','" + estacionamiento + "','" + num_habitaciones + "','" + extras_departamento_fk + "', '" + nombre+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Editar(string direccion, string estacionamiento, int num_habitaciones, int extras_departamento_fk, string nombre, int id_departamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDepartamentos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@estacionamiento", estacionamiento);
            comando.Parameters.AddWithValue("@num_habitaciones", num_habitaciones);
            comando.Parameters.AddWithValue("@extras_departamento_fk", extras_departamento_fk);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@id_departamento", id_departamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void CargarExtra(int extras_departamento_fk)
        {
            string sql = "Select id_extras_departamento, descripcion from extras_departamento";
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
                MessageBox.Show("Error al cargar extra departamento" + ex.Message);
            }

            finally
            {
                comando.Connection = conexion.CerrarConexion();
            }
        }
        public void Eliminar(int id_departamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDepartamentos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_departamento", id_departamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}