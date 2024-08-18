
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
            GestionTablaProd.DataSource = logica.Mostrar();
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
            ObtenerImagen();
        }

        private void GestionAgrButton_Click(object sender, EventArgs e)
        {
            // Si el usuario presiona el boton de agregar, se insertan los datos en la base de datos
            DateTime fecha = Convert.ToDateTime(FechaGestion.Text);
            logica.Insertar(GestionNombreBox.Text, GestionDescBox.Text, GestionMarcaBox.Text, GestionModBox.Text, fecha, GestionEstadoComboBox.SelectedIndex,  GestionSubCatComboBox.SelectedIndex, Convert.ToDecimal(GestionPrecBox.Text), Convert.ToInt32(GestionCantBox));
        
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
