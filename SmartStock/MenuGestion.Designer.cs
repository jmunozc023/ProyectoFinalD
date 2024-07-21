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
            ((System.ComponentModel.ISupportInitialize)GestionTablaProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GestionCantBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(228, 39);
            label1.Name = "label1";
            label1.Size = new Size(342, 46);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Productos";
            // 
            // GestionTablaProd
            // 
            GestionTablaProd.AllowUserToOrderColumns = true;
            GestionTablaProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GestionTablaProd.Location = new Point(352, 101);
            GestionTablaProd.Name = "GestionTablaProd";
            GestionTablaProd.RowHeadersWidth = 51;
            GestionTablaProd.Size = new Size(409, 296);
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
            label3.Location = new Point(18, 156);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 202);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 249);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 2;
            label5.Text = "Cantidad";
            // 
            // GestionNombreBox
            // 
            GestionNombreBox.Location = new Point(120, 108);
            GestionNombreBox.Name = "GestionNombreBox";
            GestionNombreBox.Size = new Size(191, 27);
            GestionNombreBox.TabIndex = 3;
            // 
            // GestionDescBox
            // 
            GestionDescBox.Location = new Point(120, 153);
            GestionDescBox.Name = "GestionDescBox";
            GestionDescBox.Size = new Size(191, 27);
            GestionDescBox.TabIndex = 3;
            // 
            // GestionPrecBox
            // 
            GestionPrecBox.Location = new Point(120, 199);
            GestionPrecBox.Name = "GestionPrecBox";
            GestionPrecBox.Size = new Size(191, 27);
            GestionPrecBox.TabIndex = 3;
            // 
            // GestionCantBox
            // 
            GestionCantBox.Location = new Point(120, 247);
            GestionCantBox.Name = "GestionCantBox";
            GestionCantBox.Size = new Size(150, 27);
            GestionCantBox.TabIndex = 4;
            // 
            // GestionAgrButton
            // 
            GestionAgrButton.BackColor = Color.Chartreuse;
            GestionAgrButton.Location = new Point(36, 304);
            GestionAgrButton.Name = "GestionAgrButton";
            GestionAgrButton.Size = new Size(94, 29);
            GestionAgrButton.TabIndex = 5;
            GestionAgrButton.Text = "Agregar";
            GestionAgrButton.UseVisualStyleBackColor = false;
            // 
            // GestionModButton
            // 
            GestionModButton.BackColor = Color.Chartreuse;
            GestionModButton.Location = new Point(160, 304);
            GestionModButton.Name = "GestionModButton";
            GestionModButton.Size = new Size(94, 29);
            GestionModButton.TabIndex = 5;
            GestionModButton.Text = "Modificar";
            GestionModButton.UseVisualStyleBackColor = false;
            // 
            // GestionActualizarButton
            // 
            GestionActualizarButton.BackColor = Color.Chartreuse;
            GestionActualizarButton.Location = new Point(408, 409);
            GestionActualizarButton.Name = "GestionActualizarButton";
            GestionActualizarButton.Size = new Size(94, 29);
            GestionActualizarButton.TabIndex = 5;
            GestionActualizarButton.Text = "Actualizar";
            GestionActualizarButton.UseVisualStyleBackColor = false;
            // 
            // GestionEliminarButton
            // 
            GestionEliminarButton.BackColor = Color.Chartreuse;
            GestionEliminarButton.Location = new Point(604, 409);
            GestionEliminarButton.Name = "GestionEliminarButton";
            GestionEliminarButton.Size = new Size(94, 29);
            GestionEliminarButton.TabIndex = 5;
            GestionEliminarButton.Text = "Eliminar";
            GestionEliminarButton.UseVisualStyleBackColor = false;
            // 
            // MenuGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}