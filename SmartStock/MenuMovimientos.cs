using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using ConexionSQL;

namespace SmartStock
{
    public partial class MenuMovimientos : Form
    {
        public MenuMovimientos()
        {
            InitializeComponent();
            MostrarEquipos();
        }
        private void MostrarEquipos()
        {
            LogicaMovimiento logica = new LogicaMovimiento();
            dataGridViewMov.DataSource = logica.Mostrar();
        }

        private void MovSalirButton_Click_1(object sender, EventArgs e)
        {
            // Si el usuario presiona salir regresa al menu principal
            this.Hide();
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
