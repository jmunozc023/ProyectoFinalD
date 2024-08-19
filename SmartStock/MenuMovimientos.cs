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
using Microsoft.Data.SqlClient;

namespace SmartStock
{
    public partial class MenuMovimientos : Form
    {
        Conexion_BD conexion = new Conexion_BD();
        LogicaMovimiento logica = new LogicaMovimiento();
        SqlCommand SqlCommand;
        public MenuMovimientos()
        {
            InitializeComponent();
            MostrarEquipos();
        }
        private void MostrarEquipos()
        {
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
        private int ObtenerIDUsuario()
        {
            int id = 0;
            try
            {
                conexion.AbrirConexion();
                string query = "SELECT ID_usuario FROM Login WHERE Nombre_usuario = @username";
                SqlCommand = new SqlCommand(query, conexion.AbrirConexion());
                SqlCommand.Parameters.AddWithValue("@username", UsuariotextBox.Text);

                // Ejecutar la consulta y obtener el resultado
                id = (int)SqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Manejar la excepción de alguna manera (por ejemplo, mostrar un mensaje de error)
                MessageBox.Show("Error al obtener el ID del usuario: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexion.CerrarConexion();
            }

            return id;
        }

        private void MovimientoEnvButton_Click(object sender, EventArgs e)
        {
            int idUsuario = ObtenerIDUsuario();
            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridViewMov.SelectedRows[0];

            // Obtener el valor de la celda correspondiente al ID de Producto
            int idProducto = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
            //int idUsuario = logIn.ID_usuario;
            MessageBox.Show(idUsuario.ToString());
            string tipoMovimiento = TipoMovCombo.Text;

            // Insertar movimiento
            logica.Insertar(idProducto, idUsuario, FechaMov.Value, tipoMovimiento, Convert.ToInt32(CantMovBox.Text), ComentarioMovBox.Text);
            // Actualizar stock
            logica.ActualizarStock(idProducto, Convert.ToInt32(CantMovBox.Text));
            // Actualizar tabla
            MostrarEquipos();
        }
    }
}
