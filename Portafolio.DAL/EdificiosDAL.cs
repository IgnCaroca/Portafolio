using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PortafolioDAL
{
    class EdificiosDAL
    {
        private ConexionMySql conexion = new ConexionMySql();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Edificios";
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
