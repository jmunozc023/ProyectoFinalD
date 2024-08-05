namespace SmartStock
{
    partial class Consulta
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
            ConsultaDataView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ConsultaCodProdTB = new TextBox();
            ConsultaEstComboBox = new ComboBox();
            ConsultaButton = new Button();
            ConsultaSalirButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ConsultaDataView).BeginInit();
            SuspendLayout();
            // 
            // ConsultaDataView
            // 
            ConsultaDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConsultaDataView.Location = new Point(57, 78);
            ConsultaDataView.Name = "ConsultaDataView";
            ConsultaDataView.RowHeadersWidth = 51;
            ConsultaDataView.Size = new Size(1249, 681);
            ConsultaDataView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 772);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 1;
            label1.Text = "Codigo de Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(613, 20);
            label2.Name = "label2";
            label2.Size = new Size(164, 46);
            label2.TabIndex = 2;
            label2.Text = "Consultas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 813);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 1;
            label3.Text = "Estado";
            // 
            // ConsultaCodProdTB
            // 
            ConsultaCodProdTB.Location = new Point(206, 769);
            ConsultaCodProdTB.Name = "ConsultaCodProdTB";
            ConsultaCodProdTB.Size = new Size(154, 27);
            ConsultaCodProdTB.TabIndex = 3;
            // 
            // ConsultaEstComboBox
            // 
            ConsultaEstComboBox.FormattingEnabled = true;
            ConsultaEstComboBox.Items.AddRange(new object[] { "Activo", "Inactivo", "Dañado", "Descontinuado", "Desaparecido" });
            ConsultaEstComboBox.Location = new Point(128, 805);
            ConsultaEstComboBox.Name = "ConsultaEstComboBox";
            ConsultaEstComboBox.Size = new Size(232, 28);
            ConsultaEstComboBox.TabIndex = 4;
            // 
            // ConsultaButton
            // 
            ConsultaButton.BackColor = Color.Chartreuse;
            ConsultaButton.Location = new Point(57, 853);
            ConsultaButton.Name = "ConsultaButton";
            ConsultaButton.Size = new Size(143, 29);
            ConsultaButton.TabIndex = 5;
            ConsultaButton.Text = "Realizar Consulta";
            ConsultaButton.UseVisualStyleBackColor = false;
            // 
            // ConsultaSalirButton
            // 
            ConsultaSalirButton.BackColor = Color.Chartreuse;
            ConsultaSalirButton.Location = new Point(1212, 853);
            ConsultaSalirButton.Name = "ConsultaSalirButton";
            ConsultaSalirButton.Size = new Size(94, 29);
            ConsultaSalirButton.TabIndex = 6;
            ConsultaSalirButton.Text = "Salir";
            ConsultaSalirButton.UseVisualStyleBackColor = false;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1358, 920);
            Controls.Add(ConsultaSalirButton);
            Controls.Add(ConsultaButton);
            Controls.Add(ConsultaEstComboBox);
            Controls.Add(ConsultaCodProdTB);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ConsultaDataView);
            Name = "Consulta";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)ConsultaDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ConsultaDataView;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ConsultaCodProdTB;
        private ComboBox ConsultaEstComboBox;
        private Button ConsultaButton;
        private Button ConsultaSalirButton;
    }
}