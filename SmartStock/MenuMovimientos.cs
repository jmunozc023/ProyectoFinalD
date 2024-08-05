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
        LogicaMovimiento logica = new LogicaMovimiento();
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

        private void MovimientoEnvButton_Click(object sender, EventArgs e)
        {
            LogIn_BD logIn = new LogIn_BD();
            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridViewMov.SelectedRows[0];

            // Obtener el valor de la celda correspondiente al ID de Producto
            int idProducto = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
            int idUsuario;
            string tipoMovimiento = TipoMovCombo.Text;
            idUsuario =logIn.ID_usuario;
            // Insertar movimiento
            logica.Insertar(idProducto, idUsuario, FechaMov.Value, tipoMovimiento, Convert.ToInt32(CantMovBox.Text), ComentarioMovBox.Text);
            // Actualizar stock
            logica.ActualizarStock(idProducto, Convert.ToInt32(CantMovBox.Text));
            // Actualizar tabla
            MostrarEquipos();
        }
    }
}
