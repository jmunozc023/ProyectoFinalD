
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
            LogicaGestion logica = new LogicaGestion();
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
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imgLocation = dialog.FileName;
                    CarImaPictureBox.ImageLocation = imgLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void CarImaButton_Click(object sender, EventArgs e)
        {
            ObtenerImagen();
        }

        private byte[] GetImageData(string imagePath)
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    return br.ReadBytes((int)fs.Length);
                }
            }
        }

        private void GestionAgrButton_Click(object sender, EventArgs e)
        {
            // Si el usuario presiona el boton de agregar, se insertan los datos en la base de datos
            try
            {
                string imagePath = CarImaPictureBox.ImageLocation;
                byte[] imageData = GetImageData(imagePath);
                DateTime fecha = FechaGestion.Value;
                if (imageData != null)
                {
                    
                    logica.Insertar(GestionNombreBox.Text, GestionDescBox.Text, GestionMarcaBox.Text, GestionModBox.Text, fecha, imageData, GestionEstadoComboBox.SelectedIndex,  GestionSubCatComboBox.SelectedIndex, Convert.ToDouble(GestionPrecBox.Text));
                }
                else
                {
                    // Manejo de errores cuando la imagen no se puede insertar
                    MessageBox.Show("Error: La imagen no puede ir en blanco.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
