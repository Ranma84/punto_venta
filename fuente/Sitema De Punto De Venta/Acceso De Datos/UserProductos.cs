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
    public class UserProductos
    {

        private CD_Conexion connection = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand command = new SqlCommand();
        DataTable tabla = new DataTable();

        public DataTable Mostrar()
        {

            command.Connection = connection.AbrirConexion();
            command.CommandText = "Select * From dbo.tbProducto";
            leer = command.ExecuteReader();
            tabla.Load(leer);
            connection.CerrarConexion();
            return tabla;

        }

        public void Productos(string Codigo, string NombrePro, string UsuarioCre, DateTime FechaCre, string UsuarioModi, DateTime FechaModi, string Precio)
        {

            command.Connection = connection.AbrirConexion();
            command.CommandText = "Insert Into dbo.tbProducto Values ('0','"+ Codigo + "' , '" + NombrePro + "','" + UsuarioCre + "','" + FechaCre + "','" + UsuarioModi + "','" + FechaModi + "', '" + Precio + "')";
            command.ExecuteNonQuery();
            connection.CerrarConexion();

        }
    }
}
