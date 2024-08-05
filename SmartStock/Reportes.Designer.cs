namespace SmartStock
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ActualizarReporteButton = new Button();
            SalirReporteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(985, 613);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(490, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 46);
            label1.TabIndex = 1;
            label1.Text = "Reporte";
            // 
            // ActualizarReporteButton
            // 
            ActualizarReporteButton.BackColor = Color.Chartreuse;
            ActualizarReporteButton.Location = new Point(67, 692);
            ActualizarReporteButton.Name = "ActualizarReporteButton";
            ActualizarReporteButton.Size = new Size(94, 29);
            ActualizarReporteButton.TabIndex = 2;
            ActualizarReporteButton.Text = "Actualizar";
            ActualizarReporteButton.UseVisualStyleBackColor = false;
            ActualizarReporteButton.Click += ActualizarReporteButton_Click;
            // 
            // SalirReporteButton
            // 
            SalirReporteButton.BackColor = Color.Chartreuse;
            SalirReporteButton.Location = new Point(958, 692);
            SalirReporteButton.Name = "SalirReporteButton";
            SalirReporteButton.Size = new Size(94, 29);
            SalirReporteButton.TabIndex = 3;
            SalirReporteButton.Text = "Salir";
            SalirReporteButton.UseVisualStyleBackColor = false;
            SalirReporteButton.Click += SalirReporteButton_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1133, 767);
            Controls.Add(SalirReporteButton);
            Controls.Add(ActualizarReporteButton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Reportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button ActualizarReporteButton;
        private Button SalirReporteButton;
    }
}