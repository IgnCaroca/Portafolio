using MySql.Data.MySqlClient;
using PortafolioDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioDLL
{
    public class ServicioExtraDAL
    {
        private ConexionMySql conexion = new ConexionMySql();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from extras_departamento;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public void Guardar(string descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into `extras_departamento` (descripcion) values('" + descripcion + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Editar(string descripcion, int id_extras_departamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarExtrasDepa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@id_extras_departamento", id_extras_departamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Eliminar(int id_extras_departamento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarExtrasDepa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_extras_departamento", id_extras_departamento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
