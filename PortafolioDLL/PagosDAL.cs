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
    public class PagosDAL
    {
        private ConexionMySql conexion = new ConexionMySql();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();
        public DataTable MostrarPagos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id_pago,monto_total as monto,abono, usuario_rut_cliente_fk as rut from pagos;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
