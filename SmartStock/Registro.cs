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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SmartStock
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
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
        private void RegistroSalirButton_Click(object sender, EventArgs e)
        {
            // Si el usuario selecciona salir, regresa a la pantalla de LogIn
            LogInMenu logInForm = new LogInMenu();
            logInForm.Show();
            this.Hide();
        }
        private void RegistroButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=JOSE-LAPTOP\\MSSQLSERVER1;Initial Catalog=SmartStock;Trusted_Connection=True;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            string Nombre = RegistroNomBox.Text;
            string Apellido = RegistroApeBox.Text;
            string Email = RegistroEmaBox.Text;
            string Telefono = RegistroTelBox.Text;
            string Direccion = RegistroDirBox.Text;
            string Cargo = RegistroCarBox.Text;
            string UserName = RegistroUserNBox.Text;
            string Password = RegistroPasswBox.Text;

            // Primero, insertamos los datos en la tabla Usuarios
            string query = "INSERT INTO Usuarios (Nombre, Apellido, Email, Telefono, Direccion, Cargo) OUTPUT INSERTED.ID_usuario VALUES (@Nombre, @Apellido, @Email, @Telefono, @Direccion, @Cargo)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Apellido", Apellido);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Telefono", Telefono);
            command.Parameters.AddWithValue("@Direccion", Direccion);
            command.Parameters.AddWithValue("@Cargo", Cargo);

            connection.Open();
            int newUserId = (int)command.ExecuteScalar();

            // A continuación, insertamos los datos en la tabla LogIn, utilizando el ID_usuario obtenido
            string query2 = "INSERT INTO LogIn (ID_usuario, Nombre_usuario, Contraseña, Fecha_creacion) VALUES (@ID_usuario, @Nombre_usuario, @Contraseña, @Fecha_creacion)";
            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@ID_usuario", newUserId);
            command2.Parameters.AddWithValue("@Nombre_usuario", UserName);
            command2.Parameters.AddWithValue("@Contraseña", Password);
            command2.Parameters.AddWithValue("@Fecha_creacion", DateTime.Now);

            command2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Usuario registrado exitosamente");
        }
    }

}
