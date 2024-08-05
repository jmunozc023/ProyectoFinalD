namespace SmartStock
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            label1 = new Label();
            GestionButton = new Button();
            MovimientosButton = new Button();
            ConsultaButton = new Button();
            ReportesButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            MenuPrincSalirButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(275, 38);
            label1.Name = "label1";
            label1.Size = new Size(243, 46);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // GestionButton
            // 
            GestionButton.BackColor = Color.Chartreuse;
            GestionButton.Location = new Point(57, 253);
            GestionButton.Name = "GestionButton";
            GestionButton.Size = new Size(94, 29);
            GestionButton.TabIndex = 1;
            GestionButton.Text = "Gestion";
            GestionButton.UseVisualStyleBackColor = false;
            GestionButton.Click += GestionButton_Click;
            // 
            // MovimientosButton
            // 
            MovimientosButton.BackColor = Color.Chartreuse;
            MovimientosButton.Location = new Point(246, 253);
            MovimientosButton.Name = "MovimientosButton";
            MovimientosButton.Size = new Size(106, 29);
            MovimientosButton.TabIndex = 1;
            MovimientosButton.Text = "Movimientos";
            MovimientosButton.UseVisualStyleBackColor = false;
            MovimientosButton.Click += MovimientosButton_Click;
            // 
            // ConsultaButton
            // 
            ConsultaButton.BackColor = Color.Chartreuse;
            ConsultaButton.Location = new Point(441, 253);
            ConsultaButton.Name = "ConsultaButton";
            ConsultaButton.Size = new Size(94, 29);
            ConsultaButton.TabIndex = 1;
            ConsultaButton.Text = "Consulta";
            ConsultaButton.UseVisualStyleBackColor = false;
            ConsultaButton.Click += ConsultaButton_Click;
            // 
            // ReportesButton
            // 
            ReportesButton.BackColor = Color.Chartreuse;
            ReportesButton.Location = new Point(629, 253);
            ReportesButton.Name = "ReportesButton";
            ReportesButton.Size = new Size(94, 29);
            ReportesButton.TabIndex = 1;
            ReportesButton.Text = "Reportes";
            ReportesButton.UseVisualStyleBackColor = false;
            ReportesButton.Click += ReportesButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(255, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(441, 135);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(629, 135);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 93);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // MenuPrincSalirButton
            // 
            MenuPrincSalirButton.BackColor = Color.Chartreuse;
            MenuPrincSalirButton.Location = new Point(57, 370);
            MenuPrincSalirButton.Name = "MenuPrincSalirButton";
            MenuPrincSalirButton.Size = new Size(94, 29);
            MenuPrincSalirButton.TabIndex = 1;
            MenuPrincSalirButton.Text = "Salir";
            MenuPrincSalirButton.UseVisualStyleBackColor = false;
            MenuPrincSalirButton.Click += MenuPrincSalirButton_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ReportesButton);
            Controls.Add(ConsultaButton);
            Controls.Add(MovimientosButton);
            Controls.Add(MenuPrincSalirButton);
            Controls.Add(GestionButton);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GestionButton;
        private Button MovimientosButton;
        private Button ConsultaButton;
        private Button ReportesButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button MenuPrincSalirButton;
    }
}