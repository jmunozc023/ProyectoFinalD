using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQL;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Logica
{
    public class LogicaGestion
    {
        private Gestion_BD gestion = new Gestion_BD();
        Conexion_BD conexion = new Conexion_BD();
        /*public void Insertar(string nombre, string descripcion, string marca, string modelo, DateTime fecha, int estado,  int subcategoria, decimal precio, int cantidad)
        {
            gestion.Insertar(nombre, descripcion, marca, modelo, fecha, Convert.ToInt32(estado),  Convert.ToInt32(subcategoria), Convert.ToDecimal(precio), Convert.ToInt32(cantidad));
        }
        public void Editar(string nombre, string descripcion, string marca, string modelo, DateTime fecha, int estado, int subcategoria, decimal precio, int cantidad, int id)
        {
            gestion.Editar(nombre, descripcion, marca, modelo, fecha, Convert.ToInt32(estado),  Convert.ToInt32(subcategoria), Convert.ToDecimal(precio), Convert.ToInt32(cantidad), Convert.ToInt32(id));
        }
        public void Eliminar(int id)
        {
            gestion.Eliminar(Convert.ToInt32(id));
        }*/
    }
}
