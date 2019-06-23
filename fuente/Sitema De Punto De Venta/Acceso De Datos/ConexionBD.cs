using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Acceso_De_Datos

{
    //public class ConexionBD
    //{

    //    string cadena = ();
    //    public SqlConnection conetarDB = new SqlConnection();

    //    public ConexionBD()
    //    {
    //        conetarDB.ConnectionString = cadena;
    //    }
    //    public void abrir()
    //    {
    //        try
    //        {
    //            conetarDB.Open();
    //            Console.WriteLine("Conexion Abierta");
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error Al Abrir la BD", ex.Message);
    //        }
    //    }

    //    public void Cerra()
    //    {
    //        conetarDB.Close();
    //    }

    public abstract class ConnectionToSql
    {
            private readonly string connectionString;

            public ConnectionToSql()
            {
                connectionString = "server=DESKTOP-30HBJFJ;DataBase=PuntoVenta; integrated security = true";
            }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

    }

//}
