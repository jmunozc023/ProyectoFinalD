using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock
{
    internal class LogIn
    {
        //Metodo para autenticar el usuario
        public bool Autenticar(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
