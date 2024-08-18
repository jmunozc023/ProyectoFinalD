
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Logica;
using ConexionSQL;


namespace SmartStock
{
    public partial class MenuGestion : Form
    {
        LogicaGestion logica = new LogicaGestion();
        Conexion_BD conexion = new Conexion_BD();
        Gestion_BD gestion = new Gestion_BD();
        private string id = null;
        private bool editar = false;
        public MenuGestion()
        {
            InitializeComponent();
            RellenarComboBox();
            RellenarComboBox1();
            RellenarComboBox2();
            MostrarEquipos();
        }
        private void MostrarEquipos()
        {
            GestionTablaProd.DataSource = Mostrar();
        }

        public DataTable Mostrar() //Muestra los datos de la tabla Equipos
        {
            DataTable dt = new DataTable();
            dt = gestion.Mostrar();
            dt.Columns.Add("Imagen", typeof(Image)); // Change the column type to Image
            foreach (DataRow row in dt.Rows)
            {
                int equipoID = Convert.ToInt32(row["Id"]);
                Image image = ObtenerImagen(equipoID); // Get the image
                row["Imagen"] = image; // Assign the image to the "Imagen" column
            }
            return dt;
        }
        public Image ObtenerImagen(int equipoID) // Change the return type to Image
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
                        string path = Path.Combine(Application.StartupPath, "Fotos", reader["Path"].ToString());
                        if (File.Exists(path))
                        {
                            Image image = Image.FromFile(path); // Load the image from file
                            return image; // Return the image
                        }
                        else
                        {
                            MessageBox.Show("La imagen no se encuentra en la ubicación especificada: " + path);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna imagen con el ID especificado en la base de datos.");
                    }
                    conexion.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return null; // Return null if image not found or error occurred
        }

        public void RellenarComboBox()
        {
            Conexion_ComboBox conexion = new Conexion_ComboBox();
            List<string> estados = conexion.ObtenerEstados();
            foreach (string estado in estados)
            {
                GestionEstadoComboBox.Items.Add(estado);
            }
        }
        public void RellenarComboBox1()
        {
            Conexion_ComboBox conexion = new Conexion_ComboBox();
            List<string> categorias = conexion.ObtenerCategorias();
            foreach (string categoria in categorias)
            {
                GestionCatComboBox.Items.Add(categoria);
            }
        }
        public void RellenarComboBox2()
        {
            Conexion_ComboBox conexion = new Conexion_ComboBox();
            List<string> subcategorias = conexion.ObtenerSubcategorias();
            foreach (string subcategoria in subcategorias)
            {
                GestionSubCatComboBox.Items.Add(subcategoria);
            }

        }
        public void ObtenerImagen()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string imgLocation = Path.GetFileName(dialog.FileName);
                    string destino = Path.Combine(Application.StartupPath, "Fotos");
                    if (!Directory.Exists(destino))
                    {
                        Directory.CreateDirectory(destino);
                    }
                    string rutaDestino = Path.Combine(destino, imgLocation);
                    File.Copy(dialog.FileName, rutaDestino, true);
                    conexion.AbrirConexion();
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Imagenes (Path, ID_Equipo) VALUES (@imgLocation, @ID_Equipo)");
                        cmd.Parameters.AddWithValue("@imgLocation", imgLocation);
                        cmd.Parameters.AddWithValue("@ID_Equipo", gestion.ObtenerIdEquipo());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Imagen guardada en: " + rutaDestino);
                    Image imagen = Image.FromFile(imgLocation);
                    CarImaPictureBox.Image = imagen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                conexion.CerrarConexion();

            }
        }
        public void CarImaButton_Click(object sender, EventArgs e)
        {
            //ObtenerImagen();
        }
        public int idEstado()
        {
            int id = 0;
            conexion.AbrirConexion();
            string query = "SELECT ID FROM Estados WHERE Estado = @Estado";
            using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Estado", GestionEstadoComboBox.Text);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            conexion.CerrarConexion();
            return id;
        }
        public int idSubcategoria()
        {
            int id = 0;
            conexion.AbrirConexion();
            string query = "SELECT ID FROM Subcategorías WHERE Nombre = @Nombre";
            using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Nombre", GestionSubCatComboBox.Text);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            conexion.CerrarConexion();
            return id;
        }
        public int idCategoria()
        {
            int id = 0;
            conexion.AbrirConexion();
            string query = "SELECT ID FROM Categorías WHERE Nombre = @Nombre";
            using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Nombre", GestionCatComboBox.Text);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            conexion.CerrarConexion();
            return id;
        }

        private void GestionAgrButton_Click(object sender, EventArgs e)
        {
            // Si el usuario presiona el boton de agregar, se insertan los datos en la base de datos
            DateTime fecha = Convert.ToDateTime(FechaGestion.Text);
            int id_Estado = idEstado();
            int id_Subcategoria = idSubcategoria();
            int id_Categoria = idCategoria();

            logica.Insertar(GestionNombreBox.Text, GestionDescBox.Text, GestionMarcaBox.Text, GestionModBox.Text, fecha, id_Estado, id_Subcategoria, Convert.ToDecimal(GestionPrecBox.Text), Convert.ToInt32(GestionCantBox.Value));
            ObtenerImagen();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Si el usuario cierra la ventana se cierra la aplicacion
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void GestionSalirButton_Click(object sender, EventArgs e)
        {
            // Si el usuario presiona salir regresa al menu principal
            this.Close();
        }

    }
}
