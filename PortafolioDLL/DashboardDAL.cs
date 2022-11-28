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
    public class DashboardDAL
    {
        private ConexionMySql conexion = new ConexionMySql();
        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter DA = new MySqlDataAdapter();


        public DataTable DashDatos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(id_arriendo) as TotalDepartamentos, DATEDIFF(fecha_termino, fecha_inicio) as DiasArrendados from arriendo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Dispose();
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ContadorUsuarios(int idusuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(idusuario) as CantidadUsuario from usuario order by count(2)";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Dispose();
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Fechas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select DATEDIFF(fecha_termino, fecha_inicio) as DiasArrendados, MONTH(fecha_inicio) as 'Mes', YEAR(fecha_inicio) as 'Año' from arriendo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Dispose();
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Departamentos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(id_arriendo) as TotalDepartamentos from arriendo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Dispose();
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Departamentos_disponibles()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(id_departamento_fk) as DepartamentosDisponibles from arriendo WHERE estado_arriendo != 'Ocupado'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Dispose();
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Departamentos_arrendados()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(id_departamento_fk) as DepartamentosArrendados from arriendo WHERE estado_arriendo = 'Ocupado'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Dispose();
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Ganancias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select sum(monto_total) as GananciasTotales from arriendo";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Dispose();
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


    }
}
