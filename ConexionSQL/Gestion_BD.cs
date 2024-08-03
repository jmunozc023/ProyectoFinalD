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
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEquipos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string nombre, string marca, string modelo, string estado, DateTime fecha, byte imagen, int subcategoria, float precio )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarEquipos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Modelo", modelo);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@Imagen", imagen);
            comando.Parameters.AddWithValue("@Subcategoria", subcategoria);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(string nombre, string marca, string modelo, string estado, DateTime fecha, byte imagen, int subcategoria, float precio, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEquipos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@Modelo", modelo);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@Imagen", imagen);
            comando.Parameters.AddWithValue("@Subcategoria", subcategoria);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEquipos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
