namespace SmartStock
{
    partial class LogInMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInMenu));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UsuarioBox = new TextBox();
            ContrasenaBox = new TextBox();
            LogInButton = new Button();
            pictureBox1 = new PictureBox();
            CrearCuentaButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(260, 39);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 154);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 196);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 1;
            label3.Text = "Contraseña";
            // 
            // UsuarioBox
            // 
            UsuarioBox.Location = new Point(165, 151);
            UsuarioBox.Name = "UsuarioBox";
            UsuarioBox.Size = new Size(173, 27);
            UsuarioBox.TabIndex = 2;
            // 
            // ContrasenaBox
            // 
            ContrasenaBox.Location = new Point(165, 193);
            ContrasenaBox.Name = "ContrasenaBox";
            ContrasenaBox.PasswordChar = '∙';
            ContrasenaBox.Size = new Size(173, 27);
            ContrasenaBox.TabIndex = 2;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.Chartreuse;
            LogInButton.Location = new Point(200, 247);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(94, 29);
            LogInButton.TabIndex = 3;
            LogInButton.Text = "Ingresar";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(422, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CrearCuentaButton
            // 
            CrearCuentaButton.BackColor = Color.Chartreuse;
            CrearCuentaButton.Location = new Point(54, 434);
            CrearCuentaButton.Name = "CrearCuentaButton";
            CrearCuentaButton.Size = new Size(117, 29);
            CrearCuentaButton.TabIndex = 3;
            CrearCuentaButton.Text = "Crear Cuenta";
            CrearCuentaButton.UseVisualStyleBackColor = false;
            CrearCuentaButton.Click += CrearCuentaButton_Click;
            // 
            // LogInMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(640, 531);
            Controls.Add(pictureBox1);
            Controls.Add(CrearCuentaButton);
            Controls.Add(LogInButton);
            Controls.Add(ContrasenaBox);
            Controls.Add(UsuarioBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogInMenu";
            Text = "SmartStock";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsuarioBox;
        private TextBox ContrasenaBox;
        private Button LogInButton;
        private PictureBox pictureBox1;
        private Button CrearCuentaButton;
    }
}
