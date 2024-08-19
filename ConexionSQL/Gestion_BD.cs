using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ConexionSQL
{
    public class Gestion_BD
    {
        private Conexion_BD conexion = new Conexion_BD();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        int idEquipo;

        public DataTable Mostrar() //Muestra los datos de la tabla Equipos
        {
            conexion.AbrirConexion();
            string query = "SELECT e.ID, e.Nombre, e.Descripcion, e.Marca, e.Modelo, e.Fecha_compra AS 'Fecha de compra', " +
                           "es.Estado, c.Nombre AS 'Categoria', s.Nombre AS 'Subcategoria', " +
                           "e.Precio, e.Cantidad " +
                           "FROM Equipos e JOIN Subcategorías s ON s.ID = e.ID_Subcategoria " +
                           "JOIN Categorías c ON s.ID_Categoria = c.ID JOIN Estados es ON es.ID = e.ID_Estado";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conexion.CerrarConexion();
            return dt;
        }
        public void Insertar(string nombre, string descripcion, string marca, string modelo, DateTime fecha, int estado, int subcategoria, decimal precio, int cantidad)
        {
            conexion.AbrirConexion();
            string query = "INSERT INTO Equipos (Nombre, Descripcion, Marca, Modelo, Fecha_compra, ID_Estado, ID_Subcategoria, Precio, Cantidad) VALUES (@Nombre, @Descripcion, @Marca, @Modelo, @Fecha_compra, @ID_Estado, @ID_Subcategoria, @Precio, @Cantidad); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Descripcion", descripcion);
            command.Parameters.AddWithValue("@Marca", marca);
            command.Parameters.AddWithValue("@Modelo", modelo);
            command.Parameters.AddWithValue("@Fecha_compra", fecha);
            command.Parameters.AddWithValue("@ID_Estado", estado);
            command.Parameters.AddWithValue("@ID_Subcategoria", subcategoria);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Cantidad", cantidad);
            idEquipo = Convert.ToInt32(command.ExecuteScalar());
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public int ObtenerIdEquipo()
        {
            idEquipo = Convert.ToInt32(idEquipo);
            return idEquipo;
        }
        public void Editar(string nombre, string descripcion, string marca, string modelo, DateTime fecha, int estado, int subcategoria, decimal precio, int cantidad, int id)
        {
            conexion.AbrirConexion();
            string query = "UPDATE Equipos SET Nombre = @Nombre, Descripcion = @Descripcion, Marca = @Marca, Modelo = @Modelo, Fecha_compra = @Fecha_compra, ID_Estado = @ID_Estado, ID_Subcategoria = @ID_Subcategoria, Precio = @Precio, Cantidad = @Cantidad WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Descripcion", descripcion);
            command.Parameters.AddWithValue("@Marca", marca);
            command.Parameters.AddWithValue("@Modelo", modelo);
            command.Parameters.AddWithValue("@Fecha_compra", fecha);
            command.Parameters.AddWithValue("@ID_Estado", estado);
            command.Parameters.AddWithValue("@ID_Subcategoria", subcategoria);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Cantidad", cantidad);
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int id)
        {
            conexion.AbrirConexion();
            string query = "DELETE FROM Equipos WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
