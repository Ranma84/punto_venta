using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_De_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Logica_Negocio
{
    public class UserProductos
    {
        private UserProductos objetoCD = new UserProductos();
        UserProductos UserProd = new UserProductos();

        public DataTable Mostrar()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
     
        public void InsertProd(string Codigo, string NombrePro, string UsuarioCre, DateTime FechaCre, string UsuarioModi,  DateTime FechaModi, string Precio)
        {
            objetoCD.InsertProd(Codigo, NombrePro, UsuarioCre, FechaCre, UsuarioModi, FechaModi, Precio);
        }

    }
}
