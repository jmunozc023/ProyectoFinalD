using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock
{
    // Clase Programador
    internal class Programador : BaseUsuario.Usuario
    {
        public Programador(string nombre, string apellido, string email)
            : base(nombre, apellido, email) { }

        public override void Acceso()
        {
            Console.WriteLine("Acceso a funcionalidades de desarrollo.");
        }
    }
    
}
