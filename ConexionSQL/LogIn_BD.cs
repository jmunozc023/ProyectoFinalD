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
        public int ID_usuario { get; set; }
        public bool Autenticar(string username, string password)
        {
            bool isValid = false;
            string query = "SELECT COUNT(*) FROM LogIn WHERE Nombre_usuario = @Nombre_usuario AND Contraseña = @Contraseña";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            command.Parameters.AddWithValue("@Nombre_usuario", username);
            command.Parameters.AddWithValue("@Contraseña", password);
            conexion.AbrirConexion();
            int count = (int)command.ExecuteScalar();
            isValid = (count > 0);
            ObtenerID(username);
            conexion.CerrarConexion();
            return isValid;
        }
        public string ObtenerTipoUsuario(string username)
        {
            string tipoUsuario = "";
            string query = "SELECT U.Cargo AS TipoUsuario FROM SmartStock.dbo.Usuarios AS U JOIN SmartStock.dbo.Login as L ON L.ID_usuario = U.ID_usuario WHERE L.Nombre_Usuario = @Nombre_usuario";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            command.Parameters.AddWithValue("@Nombre_usuario", username);
            conexion.AbrirConexion();
            tipoUsuario = (string)command.ExecuteScalar();
            conexion.CerrarConexion();
            return tipoUsuario;
        }
        public int ObtenerID(string username)
        {
            string query = "SELECT ID_usuario FROM LogIn WHERE Nombre_usuario = @Nombre_usuario";
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            command.Parameters.AddWithValue("@Nombre_usuario", username);
            conexion.AbrirConexion();
            ID_usuario = (int)command.ExecuteScalar();
            conexion.CerrarConexion();
            return ID_usuario;
        }
    }
}
