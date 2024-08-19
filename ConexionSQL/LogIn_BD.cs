using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQL
{
    public class LogIn_BD
    {
        private Conexion_BD conexion = new Conexion_BD();
        public int ID_usuario { get; private set; }

        public bool Autenticar(string username, string password)
        {
            bool isValid = false;
            string query = "SELECT ID FROM LogIn WHERE Nombre_usuario = @Nombre_usuario AND Contraseña = @Contraseña";

            // Abre la conexión una vez para toda la operación
            SqlConnection con = conexion.AbrirConexion();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Nombre_usuario", username);
            command.Parameters.AddWithValue("@Contraseña", password);

            // Ejecuta el comando y verifica si existe un resultado (si es un usuario válido)
            object result = command.ExecuteScalar();
            if (result != null)
            {
                isValid = true;
                ID_usuario = (int)result; // Almacena el ID del usuario
            }

            conexion.CerrarConexion();
            return isValid;
        }

        public string ObtenerTipoUsuario(string username)
        {
            string tipoUsuario = "";
            string query = "SELECT U.Cargo AS TipoUsuario FROM SmartStock.dbo.Usuarios AS U JOIN SmartStock.dbo.Login as L ON L.ID_usuario = U.ID_usuario WHERE L.Nombre_Usuario = @Nombre_usuario";

            // Abre la conexión una vez para toda la operación
            SqlConnection con = conexion.AbrirConexion();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Nombre_usuario", username);

            tipoUsuario = (string)command.ExecuteScalar();

            conexion.CerrarConexion();
            return tipoUsuario;
        }

        public int ObtenerID(string username)
        {
            string query = "SELECT ID FROM LogIn WHERE Nombre_usuario = @Nombre_usuario";

            // Abre la conexión una vez para toda la operación
            SqlConnection con = conexion.AbrirConexion();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Nombre_usuario", username);

            ID_usuario = (int)command.ExecuteScalar();

            conexion.CerrarConexion();
            return ID_usuario;
        }
    }
}
