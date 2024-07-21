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

        private void GestionButton_Click(object sender, EventArgs e)
        {
            MenuGestion menuGestion = new MenuGestion();
            menuGestion.Show();
            this.Hide();
        }

        private void MovimientosButton_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportesButton_Click(object sender, EventArgs e)
        {

        }

        private void SalirLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Code to navigate back to the LogIn screen
            LogIn logInScreen = new LogIn();
            logInScreen.Show();
            this.Hide();
        }
    }
}
