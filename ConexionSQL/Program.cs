using Microsoft.Data.SqlClient;
using System.Data;
internal class Program
{
    private static void Main(string[] args)
    {
        string connectionString = "Data Source=JOSE-LAPTOP\\MSSQLSERVER;Initial Catalog=EmpresaEmpleados;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
    }
    private SqlConnection Conexion = new SqlConnection();
    public SqlConnection AbrirConexion()
    {
        if (Conexion.State == ConnectionState.Closed)
            Conexion.Open();
        return Conexion;
    }
    public SqlConnection CerrarConexion()
    {
        if (Conexion.State == ConnectionState.Open)
            Conexion.Close();
        return Conexion;
    }
}