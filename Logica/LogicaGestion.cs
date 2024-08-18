using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQL;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Logica
{
    public class LogicaGestion
    {
        private Gestion_BD gestion = new Gestion_BD();
        Conexion_BD conexion = new Conexion_BD();
        /*public DataTable Mostrar() //Muestra los datos de la tabla Equipos
        {
             DataTable dt = new DataTable();
            dt = gestion.Mostrar();
            dt.Columns.Add("Imagen", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                int equipoID = Convert.ToInt32(row["Id"]);
                string path = ObtenerImagen(equipoID);
                row["Imagen"] = path;
            }
            return dt;
        }
        public string ObtenerImagen(int equipoID)
        {
            try
            {
                int idEquipo = equipoID;
                conexion.AbrirConexion();
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Imagenes WHERE ID_Equipos = @ID_Equipos", conexion.AbrirConexion());
                    command.Parameters.AddWithValue("@ID_Equipos", idEquipo);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string path = Path.Combine(Application.StartupPath, "Fotos", reader["Path"].ToString);
                        if (File.Exists(path))
                        {
                            RegistropictureBox.Image = Image.FromFile(imagePath); // Mostrar la imagen en el PictureBox
                            RegistropictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar la imagen al PictureBox
                        }
                        else
                        {
                            MessageBox.Show("La imagen no se encuentra en la ubicación especificada: " + imagePath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna imagen con el ID especificado en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return "Imagen";
        }*/
        public void Insertar(string nombre, string descripcion, string marca, string modelo, DateTime fecha, int estado,  int subcategoria, decimal precio, int cantidad)
        {
            gestion.Insertar(nombre, descripcion, marca, modelo, fecha, Convert.ToInt32(estado),  Convert.ToInt32(subcategoria), Convert.ToDecimal(precio), Convert.ToInt32(cantidad));
        }
        public void Editar(string nombre, string descripcion, string marca, string modelo, DateTime fecha, int estado, int subcategoria, decimal precio, int cantidad, int id)
        {
            gestion.Editar(nombre, descripcion, marca, modelo, fecha, Convert.ToInt32(estado),  Convert.ToInt32(subcategoria), Convert.ToDecimal(precio), Convert.ToInt32(cantidad), Convert.ToInt32(id));
        }
        public void Eliminar(int id)
        {
            gestion.Eliminar(Convert.ToInt32(id));
        }
    }
}
