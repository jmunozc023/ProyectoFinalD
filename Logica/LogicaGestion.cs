using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQL;

namespace Logica
{
    public class LogicaGestion
    {
        private Gestion_BD gestion = new Gestion_BD();
        public DataTable Mostrar() //Muestra los datos de la tabla Equipos
        {
            DataTable dt = new DataTable();
            dt = gestion.Mostrar();
            return dt;
        }
        public void Insertar(string nombre, string descripcion, string marca, string modelo, int estado, DateTime fecha, byte[] imagen, int subcategoria, double precio)
        {
            gestion.Insertar(nombre, descripcion, marca, modelo, Convert.ToInt32(estado), fecha, imagen, Convert.ToInt32(subcategoria), Convert.ToDouble(precio));
        }
        public void Editar(string nombre, string descripcion, string marca, string modelo, int estado, DateTime fecha, byte[] imagen, int subcategoria, double precio, int id)
        {
            gestion.Editar(nombre, descripcion, marca, modelo, Convert.ToInt32(estado), fecha, imagen, Convert.ToInt32(subcategoria), Convert.ToDouble(precio), Convert.ToInt32(id));
        }
        public void Eliminar(int id)
        {
            gestion.Eliminar(Convert.ToInt32(id));
        }
    }
}
