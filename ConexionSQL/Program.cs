using Microsoft.Data.SqlClient;
using System.Data;
internal class Program
{
    private static void Main(string[] args)
    {
        string connectionString = "Data Source=JOSE-LAPTOP\\JOSE-LAPTOP;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        SqlConnection conexion = new SqlConnection(connectionString);
        conexion.Open();
    }
    
    /*private static void InsertarMovimiento(SqlConnection conexion, string movimiento, int cantidad, string fecha, string comentario)
    {
        string query = "INSERT INTO Movimientos (Movimiento, Cantidad, Fecha, Comentario) VALUES (@movimiento, @cantidad, @fecha, @comentario)";
        SqlCommand comando = new SqlCommand(query, conexion);
        comando.Parameters.AddWithValue("@movimiento", movimiento);
        comando.Parameters.AddWithValue("@cantidad", cantidad);
        comando.Parameters.AddWithValue("@fecha", fecha);
        comando.Parameters.AddWithValue("@comentario", comentario);
        comando.ExecuteNonQuery();
    }

    private static DataTable ObtenerMovimientos(SqlConnection conexion)
    {
        string query = "SELECT * FROM Movimientos";
        SqlCommand comando = new SqlCommand(query, conexion);
        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
        DataTable tabla = new DataTable();
        adaptador.Fill(tabla);
        return tabla;
    }

    private static void ActualizarMovimiento(SqlConnection conexion, int id, string movimiento, int cantidad, string fecha, string comentario)
    {
        string query = "UPDATE Movimientos SET Movimiento = @movimiento, Cantidad = @cantidad, Fecha = @fecha, Comentario = @comentario WHERE Id = @id";
        SqlCommand comando = new SqlCommand(query, conexion);
        comando.Parameters.AddWithValue("@id", id);
        comando.Parameters.AddWithValue("@movimiento", movimiento);
        comando.Parameters.AddWithValue("@cantidad", cantidad);
        comando.Parameters.AddWithValue("@fecha", fecha);
        comando.Parameters.AddWithValue("@comentario", comentario);
        comando.ExecuteNonQuery();
    }

    private static void EliminarMovimiento(SqlConnection conexion, int id)
    {
        string query = "DELETE FROM Movimientos WHERE Id = @id";
        SqlCommand comando = new SqlCommand(query, conexion);
        comando.Parameters.AddWithValue("@id", id);
        comando.ExecuteNonQuery();
    }*/

}