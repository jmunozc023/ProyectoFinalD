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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            LogicaConsulta logicaConsulta = new LogicaConsulta();
            DataTable dt = new DataTable();
            dt = logicaConsulta.FiltrarPorIdYEstado(Convert.ToInt32(ConsultaCodProdTB.Text), ConsultaEstComboBox.Text);
            ConsultaDataView.DataSource = dt;
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

        private void ConsultaSalirButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
