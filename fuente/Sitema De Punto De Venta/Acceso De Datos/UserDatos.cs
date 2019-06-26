using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Cache;

namespace Acceso_De_Datos
{
    public class UserDatos : CD_Conexion
    {
            public bool Login(string user, string pass)
            {
            using (var connection = AbrirConexion())
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from dbo.tbusuario where usuario = @user and contrasnia = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetString(0);
                            UserLoginCache.Nombre = reader.GetString(3);
                            UserLoginCache.Perfil = reader.GetString(6);
                        }
                        return true;
                    }
                    else

                        return false;
                }
            }

            }
        }

}
