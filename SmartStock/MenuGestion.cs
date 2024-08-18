
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
        Conexion_BD conexion = new Conexion_BD();
        Gestion_BD gestion = new Gestion_BD();
        private string id = null;
        private bool editar = false;
        public MenuGestion()
        {
            InitializeComponent();
            RellenarComboBox();
            RellenarComboBox1();
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
                int equipoID = Convert.ToInt32(row["ID"]);
                Image image = ObtenerImagen(equipoID); // Get the image
                row["Imagen"] = image; // Assign the image to the "Imagen" column
            }
            return dt;
        }

        public Image ObtenerImagen(int equipoID)
        {
            try
            {
                int idEquipo = equipoID;
                using (SqlConnection connection = new SqlConnection("Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Path FROM Imagenes WHERE ID_Equipos = @ID_Equipos", connection))
                    {
                        command.Parameters.AddWithValue("@ID_Equipos", idEquipo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string path = Path.Combine(Application.StartupPath, "Fotos", reader["Path"].ToString());
                                if (File.Exists(path))
                                {
                                    Image image = Image.FromFile(path);
                                    return image;
                                }
                                else
                                {
                                    MessageBox.Show("La imagen no se encuentra en la ubicación especificada: " + path);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            conexion.CerrarConexion();
            return null;
        }

        public void RellenarComboBox()
        {
            conexion.AbrirConexion();
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, Estado FROM Estados", conexion.AbrirConexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.CerrarConexion();
                DataRow fila = dt.NewRow();
                fila["Estado"] = "Seleccione un estado";
                dt.Rows.InsertAt(fila, 0);
                GestionEstadoComboBox.ValueMember = "ID";
                GestionEstadoComboBox.DisplayMember = "Estado";
                GestionEstadoComboBox.DataSource = dt;
            }
        }
        public void RellenarComboBox1()
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT ID, Nombre FROM Categorías", conexion.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.CerrarConexion();
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione una categoría";
            dt.Rows.InsertAt(fila, 0);
            GestionCatComboBox.ValueMember = "ID";
            GestionCatComboBox.DisplayMember = "Nombre";
            GestionCatComboBox.DataSource = dt;

        }
        public void RellenarComboBox2(string ID_Categoria)
        {
            conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT ID, Nombre FROM Subcategorías WHERE ID_Categoria = @ID_Categoria", conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.CerrarConexion();
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione una subcategoría";
            dt.Rows.InsertAt(fila, 0);
            GestionSubCatComboBox.ValueMember = "ID";
            GestionSubCatComboBox.DisplayMember = "Nombre";
            GestionSubCatComboBox.DataSource = dt;
        }
        private void GestionCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GestionCatComboBox.SelectedValue.ToString() != null)
            {
                string ID_Categoria = GestionCatComboBox.SelectedValue.ToString();
                RellenarComboBox2(ID_Categoria);
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
                        SqlCommand cmd = new SqlCommand("INSERT INTO Imagenes (Path, ID_Equipos) VALUES (@imgLocation, @ID_Equipos)", conexion.AbrirConexion());
                        cmd.Parameters.AddWithValue("@imgLocation", imgLocation);
                        cmd.Parameters.AddWithValue("@ID_Equipos", gestion.ObtenerIdEquipo());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Imagen guardada en: " + rutaDestino);
                    Image imagen = Image.FromFile(rutaDestino); // Change the image path to the destination path
                    CarImaPictureBox.Image = imagen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
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

            gestion.Insertar(GestionNombreBox.Text, GestionDescBox.Text, GestionMarcaBox.Text, GestionModBox.Text, fecha, id_Estado, id_Subcategoria, Convert.ToDecimal(GestionPrecBox.Text), Convert.ToInt32(GestionCantBox.Value));
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
            this.Hide();
        }

        private void GestionActualizarButton_Click(object sender, EventArgs e)
        {
            MostrarEquipos();
        }
    }
}
