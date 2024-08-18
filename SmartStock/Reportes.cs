using Logica;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void ActualizarReporteButton_Click(object sender, EventArgs e)
        {
            MenuGestion logicaGestion = new MenuGestion();
            DataTable dt = new DataTable();
            dt = logicaGestion.Mostrar();
            dataGridView1.DataSource = dt;
        }

        private void SalirReporteButton_Click(object sender, EventArgs e)
        {
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
