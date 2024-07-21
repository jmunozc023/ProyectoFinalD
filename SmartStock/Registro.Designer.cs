namespace SmartStock
{
    partial class Registro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            RegistroNomBox = new TextBox();
            RegistroApeBox = new TextBox();
            RegistroCedBox = new TextBox();
            RegistroTelBox = new TextBox();
            RegistroEmaBox = new TextBox();
            RegistroCarBox = new TextBox();
            RegistroButton = new Button();
            SalirRegLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(253, 39);
            label1.Name = "label1";
            label1.Size = new Size(293, 46);
            label1.TabIndex = 0;
            label1.Text = "Registre su cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 115);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 157);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 204);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 1;
            label4.Text = "Cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 248);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 1;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 291);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 1;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(115, 336);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 1;
            label7.Text = "Cargo";
            // 
            // RegistroNomBox
            // 
            RegistroNomBox.Location = new Point(199, 112);
            RegistroNomBox.Name = "RegistroNomBox";
            RegistroNomBox.Size = new Size(385, 27);
            RegistroNomBox.TabIndex = 2;
            // 
            // RegistroApeBox
            // 
            RegistroApeBox.Location = new Point(199, 154);
            RegistroApeBox.Name = "RegistroApeBox";
            RegistroApeBox.Size = new Size(385, 27);
            RegistroApeBox.TabIndex = 2;
            // 
            // RegistroCedBox
            // 
            RegistroCedBox.Location = new Point(199, 201);
            RegistroCedBox.Name = "RegistroCedBox";
            RegistroCedBox.Size = new Size(385, 27);
            RegistroCedBox.TabIndex = 2;
            // 
            // RegistroTelBox
            // 
            RegistroTelBox.Location = new Point(199, 245);
            RegistroTelBox.Name = "RegistroTelBox";
            RegistroTelBox.Size = new Size(385, 27);
            RegistroTelBox.TabIndex = 2;
            // 
            // RegistroEmaBox
            // 
            RegistroEmaBox.Location = new Point(199, 288);
            RegistroEmaBox.Name = "RegistroEmaBox";
            RegistroEmaBox.Size = new Size(385, 27);
            RegistroEmaBox.TabIndex = 2;
            // 
            // RegistroCarBox
            // 
            RegistroCarBox.Location = new Point(199, 333);
            RegistroCarBox.Name = "RegistroCarBox";
            RegistroCarBox.Size = new Size(385, 27);
            RegistroCarBox.TabIndex = 2;
            // 
            // RegistroButton
            // 
            RegistroButton.BackColor = Color.Chartreuse;
            RegistroButton.Location = new Point(342, 384);
            RegistroButton.Name = "RegistroButton";
            RegistroButton.Size = new Size(94, 29);
            RegistroButton.TabIndex = 3;
            RegistroButton.Text = "Registrarse";
            RegistroButton.UseVisualStyleBackColor = false;
            // 
            // SalirRegLink
            // 
            SalirRegLink.AutoSize = true;
            SalirRegLink.Location = new Point(685, 388);
            SalirRegLink.Name = "SalirRegLink";
            SalirRegLink.Size = new Size(38, 20);
            SalirRegLink.TabIndex = 4;
            SalirRegLink.TabStop = true;
            SalirRegLink.Text = "Salir";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SalirRegLink);
            Controls.Add(RegistroButton);
            Controls.Add(RegistroCarBox);
            Controls.Add(RegistroEmaBox);
            Controls.Add(RegistroTelBox);
            Controls.Add(RegistroCedBox);
            Controls.Add(RegistroApeBox);
            Controls.Add(RegistroNomBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox RegistroNomBox;
        private TextBox RegistroApeBox;
        private TextBox RegistroCedBox;
        private TextBox RegistroTelBox;
        private TextBox RegistroEmaBox;
        private TextBox RegistroCarBox;
        private Button RegistroButton;
        private LinkLabel SalirRegLink;
    }
}