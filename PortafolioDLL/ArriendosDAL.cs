using MySql.Data.MySqlClient;
using PortafolioDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortafolioDLL
{
    public class ArriendosDAL
    {
        private ConexionMySql conexion = new ConexionMySql();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id_arriendo ,monto_total ,estado_arriendo , fecha_inicio , fecha_termino , usuario_id_cliente_fk as rut, id_departamento_fk from arriendo;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public void Guardar(int monto_total, string estado_arriendo, DateTime fecha_inicio, DateTime fecha_termino, string usuario_id_cliente_fk, int id_departamento_fk)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarArriendos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@monto_total", monto_total);
            comando.Parameters.AddWithValue("@estado_arriendo", estado_arriendo);
            comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@fecha_termino", fecha_termino);
            comando.Parameters.AddWithValue("@usuario_id_cliente_fk", usuario_id_cliente_fk);
            comando.Parameters.AddWithValue("@id_departamento_fk", id_departamento_fk);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Editar(int monto_total, string estado_arriendo, DateTime fecha_inicio, DateTime fecha_termino, string usuario_id_cliente_fk, int id_departamento_fk, int id_arriendo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarArriendos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@monto_total", monto_total);
            comando.Parameters.AddWithValue("@estado_arriendo", estado_arriendo);
            comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@fecha_termino", fecha_termino);
            comando.Parameters.AddWithValue("@usuario_id_cliente_fk", usuario_id_cliente_fk);
            comando.Parameters.AddWithValue("@id_departamento_fk", id_departamento_fk);
            comando.Parameters.AddWithValue("@id_arriendo", id_arriendo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public DataTable MostrarRut()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select rut, nombre from usuario;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarDepartamento()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id_departamento from departamento;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public void Eliminar(int id_arriendo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarArriendos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_arriendo", id_arriendo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
