using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartStock
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public void FuncionesUsuario(string username)
        {
            LogIn logIn = new LogIn();
            // Si el usuario es administrador se muestra el menu principal sin restricciones
            if (logIn.ObtenerTipoUsuario(username) == "Administrador")
            {
                MessageBox.Show("Acceso Total");
            }
            // Si el usuario es de cualquier otro tipo se muestra el menu principal con restricciones
            else
            {
                GestionButton.Enabled = false;
                MessageBox.Show("Acceso Limitado");
            }
        }
        private void GestionButton_Click(object sender, EventArgs e)
        {
            // Ingresar a pantalla de Gestion
            MenuGestion menuGestion = new MenuGestion();
            menuGestion.Show();
            this.Hide();
        }
        private void MenuPrincSalirButton_Click(object sender, EventArgs e)
        {
            // Si el usuario selecciona salir, regresa a la pantalla de LogIn
            LogInMenu logInForm = new LogInMenu();
            logInForm.Show();
            
            this.Hide();
        }    

        private void MovimientosButton_Click(object sender, EventArgs e)
        {
            MenuMovimientos menuMovimientos = new MenuMovimientos();
            menuMovimientos.Show();
            this.Hide();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportesButton_Click(object sender, EventArgs e)
        {

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
    }
}
