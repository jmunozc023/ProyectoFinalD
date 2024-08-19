using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ConexionSQL
{
    public class Consulta_BD
    {
        private Conexion_BD conexion = new Conexion_BD();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable FiltrarPorIdYEstado(int idProducto, string estado) //Filtra los datos de la tabla Movimientos por Id de Producto y estado
        {
            conexion.AbrirConexion();
            string query = "SELECT m.ID_Movimiento AS ID, e.Nombre, e.Marca, e.Modelo, u.Nombre AS 'Nombre de Usuario', m.Fecha, m.Tipo, m.Cantidad, m.Comentarios " +
                "FROM Movimientos m JOIN Equipos e ON m.ID_equipo = e.ID JOIN Usuarios u ON m.ID_usuario = u.ID_usuario " +
                "JOIN Estados es ON e.ID_Estado = es.ID WHERE m.ID_equipo = @idProducto AND es.Estado = @estado";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.Parameters.AddWithValue("@estado", estado);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conexion.CerrarConexion();
            return dt;
        }
    }
}
