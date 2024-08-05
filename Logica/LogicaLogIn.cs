using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQL;

namespace Logica
{
    public class LogicaLogIn
    {

        private LogIn_BD logIn = new LogIn_BD();
        public bool Autenticar(string username, string password)
        {
            return logIn.Autenticar(username, password);
        }
        public string ObtenerTipoUsuario(string username)
        {
            return logIn.ObtenerTipoUsuario(username);
        }
    }
}
