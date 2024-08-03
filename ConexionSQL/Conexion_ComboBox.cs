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
    public class Conexion_ComboBox
    {
        private Conexion_BD conexion = new Conexion_BD();

      
        public List<string> ObtenerEstados()
        {
            List<string> estados = new List<string>();
            conexion.AbrirConexion();
            {
                string query = "SELECT Estado FROM Estados";
                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string estado = reader.GetString(0);
                    estados.Add(estado);
                }
            }
            conexion.CerrarConexion();
            return estados;
        }
        public List<string> ObtenerCategorias()
        {
            List<string> categorias = new List<string>();
            conexion.AbrirConexion();
            {
                string query = "SELECT Nombre FROM Categorías";
                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string marca = reader.GetString(0);
                    categorias.Add(marca);
                }
            }
            conexion.CerrarConexion();
            return categorias;
        }
        public List<string> ObtenerSubcategorias()
        {
            List<string> subcategorias = new List<string>();
            conexion.AbrirConexion();
            {
                string query = "SELECT Nombre FROM Subcategorías";
                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string modelo = reader.GetString(0);
                    subcategorias.Add(modelo);
                }
            }
            conexion.CerrarConexion();
            return subcategorias;
        }
    }
}
