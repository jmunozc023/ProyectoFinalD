using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SmartStock
{
    internal class ConexionSQL
    {
        string connectionString = "Data Source=JOSE-LAPTOP\\MSSQLSERVER;Initial Catalog=EmpresaEmpleados;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
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
}
