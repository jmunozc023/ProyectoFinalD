namespace SmartStock
{
    partial class MenuGestion
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
            GestionTablaProd = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GestionNombreBox = new TextBox();
            GestionDescBox = new TextBox();
            GestionPrecBox = new TextBox();
            GestionCantBox = new NumericUpDown();
            GestionAgrButton = new Button();
            GestionModButton = new Button();
            GestionActualizarButton = new Button();
            GestionEliminarButton = new Button();
            GestionSalirButton = new Button();
            CarImaButton = new Button();
            CarImaPictureBox = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            GestionModBox = new TextBox();
            GestionMarcaBox = new TextBox();
            FechaGestion = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            GestionEstadoComboBox = new ComboBox();
            GestionCatComboBox = new ComboBox();
            GestionSubCatComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GestionTablaProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GestionCantBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarImaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(398, 21);
            label1.Name = "label1";
            label1.Size = new Size(342, 46);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Productos";
            // 
            // GestionTablaProd
            // 
            GestionTablaProd.AllowUserToOrderColumns = true;
            GestionTablaProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GestionTablaProd.Location = new Point(447, 88);
            GestionTablaProd.Name = "GestionTablaProd";
            GestionTablaProd.RowHeadersWidth = 51;
            GestionTablaProd.Size = new Size(618, 729);
            GestionTablaProd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 111);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 298);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 337);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 2;
            label5.Text = "Cantidad";
            // 
            // GestionNombreBox
            // 
            GestionNombreBox.Location = new Point(123, 104);
            GestionNombreBox.Name = "GestionNombreBox";
            GestionNombreBox.Size = new Size(191, 27);
            GestionNombreBox.TabIndex = 3;
            // 
            // GestionDescBox
            // 
            GestionDescBox.Location = new Point(122, 142);
            GestionDescBox.Name = "GestionDescBox";
            GestionDescBox.Size = new Size(191, 27);
            GestionDescBox.TabIndex = 3;
            // 
            // GestionPrecBox
            // 
            GestionPrecBox.Location = new Point(123, 295);
            GestionPrecBox.Name = "GestionPrecBox";
            GestionPrecBox.Size = new Size(188, 27);
            GestionPrecBox.TabIndex = 3;
            // 
            // GestionCantBox
            // 
            GestionCantBox.Location = new Point(123, 335);
            GestionCantBox.Name = "GestionCantBox";
            GestionCantBox.Size = new Size(147, 27);
            GestionCantBox.TabIndex = 4;
            // 
            // GestionAgrButton
            // 
            GestionAgrButton.BackColor = Color.Chartreuse;
            GestionAgrButton.Location = new Point(17, 754);
            GestionAgrButton.Name = "GestionAgrButton";
            GestionAgrButton.Size = new Size(94, 29);
            GestionAgrButton.TabIndex = 5;
            GestionAgrButton.Text = "Agregar";
            GestionAgrButton.UseVisualStyleBackColor = false;
            GestionAgrButton.Click += GestionAgrButton_Click;
            // 
            // GestionModButton
            // 
            GestionModButton.BackColor = Color.Chartreuse;
            GestionModButton.Location = new Point(141, 754);
            GestionModButton.Name = "GestionModButton";
            GestionModButton.Size = new Size(94, 29);
            GestionModButton.TabIndex = 5;
            GestionModButton.Text = "Modificar";
            GestionModButton.UseVisualStyleBackColor = false;
            // 
            // GestionActualizarButton
            // 
            GestionActualizarButton.BackColor = Color.Chartreuse;
            GestionActualizarButton.Location = new Point(486, 823);
            GestionActualizarButton.Name = "GestionActualizarButton";
            GestionActualizarButton.Size = new Size(94, 29);
            GestionActualizarButton.TabIndex = 5;
            GestionActualizarButton.Text = "Actualizar";
            GestionActualizarButton.UseVisualStyleBackColor = false;
            GestionActualizarButton.Click += GestionActualizarButton_Click;
            // 
            // GestionEliminarButton
            // 
            GestionEliminarButton.BackColor = Color.Chartreuse;
            GestionEliminarButton.Location = new Point(268, 754);
            GestionEliminarButton.Name = "GestionEliminarButton";
            GestionEliminarButton.Size = new Size(94, 29);
            GestionEliminarButton.TabIndex = 5;
            GestionEliminarButton.Text = "Eliminar";
            GestionEliminarButton.UseVisualStyleBackColor = false;
            // 
            // GestionSalirButton
            // 
            GestionSalirButton.BackColor = Color.Chartreuse;
            GestionSalirButton.Location = new Point(13, 872);
            GestionSalirButton.Name = "GestionSalirButton";
            GestionSalirButton.Size = new Size(94, 29);
            GestionSalirButton.TabIndex = 6;
            GestionSalirButton.Text = "Salir";
            GestionSalirButton.UseVisualStyleBackColor = false;
            GestionSalirButton.Click += GestionSalirButton_Click;
            // 
            // CarImaButton
            // 
            CarImaButton.BackColor = Color.Chartreuse;
            CarImaButton.Location = new Point(301, 660);
            CarImaButton.Name = "CarImaButton";
            CarImaButton.Size = new Size(120, 29);
            CarImaButton.TabIndex = 7;
            CarImaButton.Text = "Cargar Imagen";
            CarImaButton.UseVisualStyleBackColor = false;
            CarImaButton.Click += CarImaButton_Click;
            // 
            // CarImaPictureBox
            // 
            CarImaPictureBox.Location = new Point(20, 513);
            CarImaPictureBox.Name = "CarImaPictureBox";
            CarImaPictureBox.Size = new Size(275, 176);
            CarImaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CarImaPictureBox.TabIndex = 8;
            CarImaPictureBox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 179);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 9;
            label6.Text = "Modelo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 222);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 9;
            label7.Text = "Marca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 264);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 9;
            label8.Text = "Fecha de compra";
            // 
            // GestionModBox
            // 
            GestionModBox.Location = new Point(123, 179);
            GestionModBox.Name = "GestionModBox";
            GestionModBox.Size = new Size(191, 27);
            GestionModBox.TabIndex = 10;
            // 
            // GestionMarcaBox
            // 
            GestionMarcaBox.Location = new Point(122, 219);
            GestionMarcaBox.Name = "GestionMarcaBox";
            GestionMarcaBox.Size = new Size(191, 27);
            GestionMarcaBox.TabIndex = 11;
            // 
            // FechaGestion
            // 
            FechaGestion.CustomFormat = "yyyy-MM-dd";
            FechaGestion.Format = DateTimePickerFormat.Custom;
            FechaGestion.Location = new Point(141, 259);
            FechaGestion.Name = "FechaGestion";
            FechaGestion.Size = new Size(173, 27);
            FechaGestion.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 373);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 13;
            label9.Text = "Categoria";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 413);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 13;
            label10.Text = "Sub-categoria";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 450);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 13;
            label11.Text = "Estado";
            // 
            // GestionEstadoComboBox
            // 
            GestionEstadoComboBox.FormattingEnabled = true;
            GestionEstadoComboBox.Location = new Point(123, 447);
            GestionEstadoComboBox.Name = "GestionEstadoComboBox";
            GestionEstadoComboBox.Size = new Size(151, 28);
            GestionEstadoComboBox.TabIndex = 16;
            // 
            // GestionCatComboBox
            // 
            GestionCatComboBox.FormattingEnabled = true;
            GestionCatComboBox.Location = new Point(123, 370);
            GestionCatComboBox.Name = "GestionCatComboBox";
            GestionCatComboBox.Size = new Size(151, 28);
            GestionCatComboBox.TabIndex = 17;
            GestionCatComboBox.SelectedIndexChanged += GestionCatComboBox_SelectedIndexChanged;
            // 
            // GestionSubCatComboBox
            // 
            GestionSubCatComboBox.FormattingEnabled = true;
            GestionSubCatComboBox.Location = new Point(123, 410);
            GestionSubCatComboBox.Name = "GestionSubCatComboBox";
            GestionSubCatComboBox.Size = new Size(151, 28);
            GestionSubCatComboBox.TabIndex = 18;
            // 
            // MenuGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1100, 930);
            Controls.Add(GestionSubCatComboBox);
            Controls.Add(GestionCatComboBox);
            Controls.Add(GestionEstadoComboBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(FechaGestion);
            Controls.Add(GestionMarcaBox);
            Controls.Add(GestionModBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(CarImaPictureBox);
            Controls.Add(CarImaButton);
            Controls.Add(GestionSalirButton);
            Controls.Add(GestionEliminarButton);
            Controls.Add(GestionActualizarButton);
            Controls.Add(GestionModButton);
            Controls.Add(GestionAgrButton);
            Controls.Add(GestionCantBox);
            Controls.Add(GestionPrecBox);
            Controls.Add(GestionDescBox);
            Controls.Add(GestionNombreBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GestionTablaProd);
            Controls.Add(label1);
            Name = "MenuGestion";
            Text = "MenuGestion";
            ((System.ComponentModel.ISupportInitialize)GestionTablaProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)GestionCantBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarImaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView GestionTablaProd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox GestionNombreBox;
        private TextBox GestionDescBox;
        private TextBox GestionPrecBox;
        private NumericUpDown GestionCantBox;
        private Button GestionAgrButton;
        private Button GestionModButton;
        private Button GestionActualizarButton;
        private Button GestionEliminarButton;
        private Button GestionSalirButton;
        private Button CarImaButton;
        private PictureBox CarImaPictureBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox GestionModBox;
        private TextBox GestionMarcaBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox GestionEstadoComboBox;
        private ComboBox GestionCatComboBox;
        private ComboBox GestionSubCatComboBox;
        public DateTimePicker FechaGestion;
    }
}