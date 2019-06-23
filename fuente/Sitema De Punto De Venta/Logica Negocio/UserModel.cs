using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Acceso_De_Datos;

namespace Logica_Negocio
{
    public class UserModel
    {
        
        UserDatos userDao = new UserDatos();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
    }

}
