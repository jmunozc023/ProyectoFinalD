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
using System.Reflection.Metadata;
using System.Drawing.Printing;
using System.Drawing;
using System.Drawing.Imaging;

namespace SmartStock
{
    public partial class Reportes : Form
    {
        private PrintDocument Document = new PrintDocument();
        public Reportes()
        {
            InitializeComponent();
            Document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
        }
        void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 6);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 150;
            int Offset = 25;
            //imprimir el titulo del documento
            g.DrawString("Reporte de Productos", new Font("Arial", 12), brush, new Point(250, 10));
            //imprimir la fecha del documento
            g.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12), brush, new Point(250, 30));

            //imprimir el data grid view en el documento como una imagen
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            g.DrawImage(bm, new Point(startX, startY));

            Image imagen = Image.FromFile("C:\\Users\\josep\\Downloads\\c-sharp.png");
            RectangleF rectangle = new RectangleF(10, 10, 100, 100);
            g.DrawImage(imagen, rectangle);
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

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            Document.Print();
        }

        private void Verbutton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = Document;
            ((Form)printPreviewDialog).WindowState = FormWindowState.Maximized;
            printPreviewDialog.Show();
        }
    }
}
