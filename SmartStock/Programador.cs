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
        private string cargo;
        public Programador(string nombre, string apellido, string email, int telefono, string direccion, string cargo)
            : base(nombre, apellido, email, telefono, direccion)
        {
            this.cargo = cargo;
        }


        public override void Acceso()
        {
            Console.WriteLine("Acceso a funcionalidades de desarrollo.");
        }
    }
    
}
