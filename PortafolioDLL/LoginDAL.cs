using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PortafolioDAL;
using MySql.Data.MySqlClient;
using Comun;
using Comun.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace PortafolioDLL
{
    public class LoginDAL:ConexionMySql
    {
            public bool Login(string usuario, string clave)
        {
            using (var connection = AbrirConexion())
            {
                //connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from usuario where usuario=@user and clave=@pass and rol_fk=1";
                    command.Parameters.AddWithValue("@user", usuario);
                    command.Parameters.AddWithValue("@pass", clave);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Id = reader.GetInt32(0);
                            UserLoginCache.Rut = reader.GetString(1);
                            UserLoginCache.Nombre = reader.GetString(2);
                            UserLoginCache.Apellido = reader.GetString(3);
                            UserLoginCache.Fecha_nac = reader.GetString(4);
                            UserLoginCache.Correo = reader.GetString(5);
                            UserLoginCache.Direccion = reader.GetString(6);
                            UserLoginCache.Usuario = reader.GetString(7);
                            UserLoginCache.Clave = reader.GetString(8);
                            UserLoginCache.Rol_fk = reader.GetInt32(9);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

        }
            
            public void Roles()
            {
                if (UserLoginCache.Rol_fk == Rol_fky.Administrador)
                {

                }
                if (UserLoginCache.Rol_fk == Rol_fky.Cliente)
                {

                }
            }
        }
}
