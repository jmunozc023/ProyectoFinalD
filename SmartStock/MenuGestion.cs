﻿
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartStock
{
    public partial class MenuGestion : Form
    {
        public MenuGestion()
        {
            InitializeComponent();
            RellenarComboBox();
            RellenarComboBox1();
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
            SqlConnection connection = new SqlConnection("Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            string query = "SELECT Estado FROM Estados";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string estado = reader.GetString(0); // Suponiendo que el nombre del campo en la tabla Estados es "NombreEstado"
                GestionEstadoComboBox.Items.Add(estado);
            }
            connection.Close();

        }
        public void RellenarComboBox1()
        {
            SqlConnection connection = new SqlConnection("Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            string query = "SELECT Nombre FROM Categorías";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string categoria = reader.GetString(0); // Suponiendo que el nombre del campo en la tabla Estados es "NombreEstado"
                GestionCatComboBox.Items.Add(categoria);
            }
            connection.Close();

        }public void RellenarComboBox2()
        {
            SqlConnection connection = new SqlConnection("Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            string query = "SELECT Nombre FROM Subcategorías";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string subcategoria = reader.GetString(0); // Suponiendo que el nombre del campo en la tabla Estados es "NombreEstado"
                GestionSubCatComboBox.Items.Add(subcategoria);
            }
            connection.Close();

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
       
        
        private void GestionAgrButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            string Nombre = GestionNombreBox.Text;
            string Descripcion = GestionDescBox.Text;
            string Marca = GestionMarcaBox.Text;
            string Modelo = GestionModBox.Text;
            DateTime Fecha = FechaGestion.Value;
            string estado = GestionEstadoComboBox.SelectedIndex.ToString();
            string categoria = GestionCatComboBox.SelectedIndex.ToString();
            string subcategoria = GestionSubCatComboBox.SelectedIndex.ToString();
            string imgLocation = CarImaPictureBox.ImageLocation;
            

        }


    }
}
