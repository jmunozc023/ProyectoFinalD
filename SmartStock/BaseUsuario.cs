using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock
{
    public class BaseUsuario
    {
        // base Usuario
        public abstract class Usuario
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }
            public int Telefono { get; set; }
            public string Direccion { get; set; }


            public Usuario(string nombre, string apellido, string email, int telefono, string direccion)
            {
                Nombre = nombre;
                Apellido = apellido;
                Email = email;
                Telefono = telefono;
                Direccion = direccion;
            }

            public abstract void Acceso();
        }
    }
}
