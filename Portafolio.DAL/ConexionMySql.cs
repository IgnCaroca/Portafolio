using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioDAL
{
    public class ConexionMySql
    {
       private MySqlConnection Conexion = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=;");
        
        
       public MySqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Close();
            return Conexion;
        }
    }
}