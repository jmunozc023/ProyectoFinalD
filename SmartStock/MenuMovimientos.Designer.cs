namespace SmartStock
{
    partial class MenuMovimientos
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
            dataGridViewMov = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MovimientoBox = new TextBox();
            CantMovBox = new TextBox();
            FechaMov = new DateTimePicker();
            ComentarioMovBox = new MaskedTextBox();
            MovimientoEnvButton = new Button();
            MovSalirButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMov).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(249, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 46);
            label1.TabIndex = 0;
            label1.Text = "Menu Movimientos";
            // 
            // dataGridViewMov
            // 
            dataGridViewMov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMov.Location = new Point(39, 58);
            dataGridViewMov.Name = "dataGridViewMov";
            dataGridViewMov.RowHeadersWidth = 51;
            dataGridViewMov.Size = new Size(718, 239);
            dataGridViewMov.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 321);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo de movimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 361);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 404);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 2;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 444);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 2;
            label5.Text = "Comentario";
            // 
            // MovimientoBox
            // 
            MovimientoBox.Location = new Point(189, 318);
            MovimientoBox.Name = "MovimientoBox";
            MovimientoBox.Size = new Size(201, 27);
            MovimientoBox.TabIndex = 3;
            // 
            // CantMovBox
            // 
            CantMovBox.Location = new Point(189, 358);
            CantMovBox.Name = "CantMovBox";
            CantMovBox.Size = new Size(201, 27);
            CantMovBox.TabIndex = 4;
            // 
            // FechaMov
            // 
            FechaMov.Location = new Point(114, 399);
            FechaMov.Name = "FechaMov";
            FechaMov.Size = new Size(276, 27);
            FechaMov.TabIndex = 5;
            // 
            // ComentarioMovBox
            // 
            ComentarioMovBox.Location = new Point(132, 441);
            ComentarioMovBox.Name = "ComentarioMovBox";
            ComentarioMovBox.Size = new Size(258, 27);
            ComentarioMovBox.TabIndex = 6;
            // 
            // MovimientoEnvButton
            // 
            MovimientoEnvButton.BackColor = Color.Chartreuse;
            MovimientoEnvButton.Location = new Point(526, 321);
            MovimientoEnvButton.Name = "MovimientoEnvButton";
            MovimientoEnvButton.Size = new Size(94, 29);
            MovimientoEnvButton.TabIndex = 7;
            MovimientoEnvButton.Text = "Enviar";
            MovimientoEnvButton.UseVisualStyleBackColor = false;
            // 
            // MovSalirButton
            // 
            MovSalirButton.BackColor = Color.Chartreuse;
            MovSalirButton.Location = new Point(654, 475);
            MovSalirButton.Name = "MovSalirButton";
            MovSalirButton.Size = new Size(94, 29);
            MovSalirButton.TabIndex = 8;
            MovSalirButton.Text = "Salir";
            MovSalirButton.UseVisualStyleBackColor = false;
            MovSalirButton.Click += this.MovSalirButton_Click_1;
            // 
            // MenuMovimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(MovSalirButton);
            Controls.Add(MovimientoEnvButton);
            Controls.Add(ComentarioMovBox);
            Controls.Add(FechaMov);
            Controls.Add(CantMovBox);
            Controls.Add(MovimientoBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewMov);
            Controls.Add(label1);
            Name = "MenuMovimientos";
            Text = "MovimientosMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMov).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewMov;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox MovimientoBox;
        private TextBox CantMovBox;
        private DateTimePicker FechaMov;
        private MaskedTextBox ComentarioMovBox;
        private Button MovimientoEnvButton;
        private Button MovSalirButton;
    }
}