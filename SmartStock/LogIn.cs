using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartStock
{
    internal class LogIn
    {
        // Metodo para autenticar el usuario
        public bool Autenticar(string username, string password)
        {
            bool isValid = false;
            string connectionString = "Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            string query = "SELECT COUNT(*) FROM LogIn WHERE Nombre_usuario = @Nombre_usuario AND Contraseña = @Contraseña";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre_usuario", username);
                command.Parameters.AddWithValue("@Contraseña", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                isValid = (count > 0);
            }

            return isValid;
        }

        // Metodo para obtener el tipo de usuario
        public string ObtenerTipoUsuario(string username)
        {
            string tipoUsuario = "";
            string connectionString = "Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            string query = "SELECT U.Cargo AS TipoUsuario FROM SmartStock.dbo.Usuarios AS U JOIN SmartStock.dbo.Login as L ON L.ID_usuario = U.ID_usuario WHERE L.Nombre_Usuario = @Nombre_usuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre_usuario", username);

                connection.Open();
                tipoUsuario = (string)command.ExecuteScalar();
            }

            return tipoUsuario;
        }
    }
}
