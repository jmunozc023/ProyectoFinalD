using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQL;
using static System.Collections.Specialized.BitVector32;

namespace Logica
{
    public class LogicaMovimiento
    {
        Movimiento_BD movimiento = new Movimiento_BD();
        public void Insertar(int idEquipo, int idUsuario, DateTime fecha, string tipoMovimiento, int cantidad, string comentario)
        {
            movimiento.Movimiento(Convert.ToInt32(idEquipo), Convert.ToInt32(idUsuario), fecha, tipoMovimiento, Convert.ToInt32(cantidad), comentario);
        }
        public void ActualizarStock(int idEquipo, int cantidad)
        {
            movimiento.ActualizarStock(Convert.ToInt32(idEquipo), Convert.ToInt32(cantidad));
        }
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            dt = movimiento.Mostrar();
            return dt;
        }
    }
}
