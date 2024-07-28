using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock
{
    internal class BaseProducto
    {
        public abstract class Producto
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }

            public Producto(string nombre, string descripcion, decimal precio, int cantidad)
            {
                Nombre = nombre;
                Descripcion = descripcion;
                Precio = precio;
                Cantidad = cantidad;
            }

            public abstract void MostrarProducto();
        }
    }
}
