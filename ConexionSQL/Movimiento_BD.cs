using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ConexionSQL
{
    public class Movimiento_BD
    {
        private Conexion_BD conexion = new Conexion_BD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar() //Muestra los datos de la tabla Equipos
        {
            conexion.AbrirConexion();
            string query = "SELECT * FROM Equipos";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conexion.CerrarConexion();
            return dt;
        }
        public void Movimiento(int idEquipo, int idUsuario, DateTime fecha, string tipoMovimiento, int cantidad , string comentario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RealizarMovimiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_equipo", idEquipo);
            comando.Parameters.AddWithValue("@ID_usuario", idUsuario);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@Tipo", tipoMovimiento);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void ActualizarStock(int idEquipo, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarInventario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_equipo", idEquipo);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
