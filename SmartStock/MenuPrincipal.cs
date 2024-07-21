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
        private void MenuPrincSalirButton_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            logInForm.Show();
            
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
