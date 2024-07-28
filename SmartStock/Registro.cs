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
    }

}
