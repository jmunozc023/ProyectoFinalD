
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
        }

        private void MenuGestion_Load(object sender, EventArgs e)
        {
            MostrarEquipos();
        }
        private void MostrarEquipos()
        {
            LogicaGestion logica = new LogicaGestion();
            GestionTablaProd.DataSource = logica.Mostrar();
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
                GestionEstadoComboBox.Items.Add(categoria);
            }
        }
        public void RellenarComboBox2()
        {
            Conexion_ComboBox conexion = new Conexion_ComboBox();
            List<string> subcategorias = conexion.ObtenerSubcategorias();
            foreach (string subcategoria in subcategorias)
            {
                GestionEstadoComboBox.Items.Add(subcategoria);
            }

        }

        public void CarImaButton_Click(object sender, EventArgs e)
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
        SqlConnection connection = new SqlConnection("Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        string Nombre = GestionNombreBox.Text;
        string Descripcion = GestionDescBox.Text;
        string Marca = GestionMarcaBox.Text;
        string Modelo = GestionModBox.Text;
        DateTime Fecha = FechaGestion.Value;
        string estado = GestionEstadoComboBox.SelectedItem.ToString();
        string categoria = GestionCatComboBox.SelectedIndex.ToString();
        string subcategoria = GestionSubCatComboBox.SelectedIndex.ToString();
        string imgLocation = CarImaPictureBox.ImageLocation;
        byte[] imageData = GetImageData(imgLocation);
        // Primero, insertamos los datos en la tabla Equipos
        string query = "INSERT INTO Equipos (Nombre, Descripcion, Marca, Modelo, Fecha_ingreso, Estado, Categoria, Subcategoria, Imagen) OUTPUT INSERTED.ID_producto VALUES (@Nombre, @Descripcion, @Marca, @Modelo, @Fecha_ingreso, @Estado, @Categoria, @Subcategoria, @Imagen)";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Nombre", Nombre);
        command.Parameters.AddWithValue("@Descripcion", Descripcion);
        command.Parameters.AddWithValue("@Marca", Marca);
        command.Parameters.AddWithValue("@Modelo", Modelo);
        command.Parameters.AddWithValue("@Fecha_ingreso", Fecha);
        command.Parameters.AddWithValue("@Estado", estado);
        command.Parameters.AddWithValue("@Categoria", categoria);
        command.Parameters.AddWithValue("@Subcategoria", subcategoria);
        command.Parameters.AddWithValue("@Imagen", imageData);
        command.ExecuteNonQuery();
        connection.Close();
        MessageBox.Show("Equipo registrado exitosamente");
    }


    }
}
