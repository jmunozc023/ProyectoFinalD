namespace SmartStock
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
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
