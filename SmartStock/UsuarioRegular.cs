using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock
{
    // Clase UsuarioRegular
    internal class UsuarioRegular : BaseUsuario.Usuario
    {
        public UsuarioRegular(string nombre, string apellido, string email)
            : base(nombre, apellido, email) { }

        public override void Acceso()
        {
            Console.WriteLine("Acceso limitado.");
        }
    }
    
    
}
