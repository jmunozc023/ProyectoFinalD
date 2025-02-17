using ConexionSQL;
using Logica;

namespace SmartStock
{
    public partial class LogInMenu : Form
    {
        public LogInMenu()
        {
            InitializeComponent();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = UsuarioBox.Text;
            string password = ContrasenaBox.Text;
            // Instancia de la clase LogIn
            LogicaLogIn logIn = new LogicaLogIn();
            // Si el usuario y la contraseņa son correctos se muestra el menu principal

            if (logIn.Autenticar(username, password))
            {
                MessageBox.Show("Login successful!");
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.FuncionesUsuario(username);
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            // Si el usuario no tiene cuenta se muestra el formulario de registro
            Registro registro = new Registro();
            registro.Show();
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
