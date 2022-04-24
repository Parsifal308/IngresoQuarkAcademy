namespace ExamenQuarkAcademy
{
    partial class VistaTienda
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Direccion_Label = new System.Windows.Forms.Label();
            this.Tienda_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Historial_Label = new System.Windows.Forms.Label();
            this.CodVendedor_Label = new System.Windows.Forms.Label();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Cantidad_TextBox = new System.Windows.Forms.TextBox();
            this.PrecioUnit_TextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PrecioCant_Label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Premium_RadioButton = new System.Windows.Forms.RadioButton();
            this.Standard_RadioButton = new System.Windows.Forms.RadioButton();
            this.Calidad_Label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.StockDisponible_Label = new System.Windows.Forms.Label();
            this.Stock_Label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Pantalon_RadioButton = new System.Windows.Forms.RadioButton();
            this.Camisa_RadioButton = new System.Windows.Forms.RadioButton();
            this.Chupin_CheckBox = new System.Windows.Forms.CheckBox();
            this.Mao_CheckBox = new System.Windows.Forms.CheckBox();
            this.MangaCorta_CheckBox = new System.Windows.Forms.CheckBox();
            this.Prenda_Label = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Total_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cotizar_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 65);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Direccion_Label);
            this.panel2.Controls.Add(this.Tienda_Label);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 33);
            this.panel2.TabIndex = 2;
            // 
            // Direccion_Label
            // 
            this.Direccion_Label.AutoSize = true;
            this.Direccion_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Direccion_Label.ForeColor = System.Drawing.Color.Indigo;
            this.Direccion_Label.Location = new System.Drawing.Point(233, 8);
            this.Direccion_Label.Name = "Direccion_Label";
            this.Direccion_Label.Size = new System.Drawing.Size(139, 21);
            this.Direccion_Label.TabIndex = 1;
            this.Direccion_Label.Text = "Direccion Tienda";
            // 
            // Tienda_Label
            // 
            this.Tienda_Label.AutoSize = true;
            this.Tienda_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tienda_Label.ForeColor = System.Drawing.Color.Indigo;
            this.Tienda_Label.Location = new System.Drawing.Point(10, 8);
            this.Tienda_Label.Name = "Tienda_Label";
            this.Tienda_Label.Size = new System.Drawing.Size(129, 21);
            this.Tienda_Label.TabIndex = 0;
            this.Tienda_Label.Text = "Nombre Tienda";
            this.Tienda_Label.Click += new System.EventHandler(this.Tienda_Label_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Historial_Label);
            this.panel3.Controls.Add(this.CodVendedor_Label);
            this.panel3.Controls.Add(this.Nombre_Label);
            this.panel3.Location = new System.Drawing.Point(12, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 45);
            this.panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(176, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "|";
            // 
            // Historial_Label
            // 
            this.Historial_Label.AutoSize = true;
            this.Historial_Label.Location = new System.Drawing.Point(308, 15);
            this.Historial_Label.Name = "Historial_Label";
            this.Historial_Label.Size = new System.Drawing.Size(121, 15);
            this.Historial_Label.TabIndex = 2;
            this.Historial_Label.Text = "Historial Cotizaciones";
            this.Historial_Label.Click += new System.EventHandler(this.Historial_Label_Click);
            // 
            // CodVendedor_Label
            // 
            this.CodVendedor_Label.AutoSize = true;
            this.CodVendedor_Label.Location = new System.Drawing.Point(192, 15);
            this.CodVendedor_Label.Name = "CodVendedor_Label";
            this.CodVendedor_Label.Size = new System.Drawing.Size(99, 15);
            this.CodVendedor_Label.TabIndex = 1;
            this.CodVendedor_Label.Text = "Codigo Vendedor";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Location = new System.Drawing.Point(10, 15);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(160, 15);
            this.Nombre_Label.TabIndex = 0;
            this.Nombre_Label.Text = "Nombre y Apellido Vendedor";
            this.Nombre_Label.Click += new System.EventHandler(this.Nombre_Label_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 280);
            this.panel4.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.Cantidad_TextBox);
            this.panel8.Controls.Add(this.PrecioUnit_TextBox);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.PrecioCant_Label);
            this.panel8.Location = new System.Drawing.Point(220, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(192, 94);
            this.panel8.TabIndex = 3;
            // 
            // Cantidad_TextBox
            // 
            this.Cantidad_TextBox.Location = new System.Drawing.Point(107, 64);
            this.Cantidad_TextBox.Name = "Cantidad_TextBox";
            this.Cantidad_TextBox.Size = new System.Drawing.Size(44, 23);
            this.Cantidad_TextBox.TabIndex = 4;
            // 
            // PrecioUnit_TextBox
            // 
            this.PrecioUnit_TextBox.Location = new System.Drawing.Point(107, 31);
            this.PrecioUnit_TextBox.Name = "PrecioUnit_TextBox";
            this.PrecioUnit_TextBox.Size = new System.Drawing.Size(44, 23);
            this.PrecioUnit_TextBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "$";
            // 
            // PrecioCant_Label
            // 
            this.PrecioCant_Label.AutoSize = true;
            this.PrecioCant_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrecioCant_Label.Location = new System.Drawing.Point(1, 9);
            this.PrecioCant_Label.Name = "PrecioCant_Label";
            this.PrecioCant_Label.Size = new System.Drawing.Size(190, 19);
            this.PrecioCant_Label.TabIndex = 0;
            this.PrecioCant_Label.Text = "Precio Unitario y Cantidad:";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Premium_RadioButton);
            this.panel7.Controls.Add(this.Standard_RadioButton);
            this.panel7.Controls.Add(this.Calidad_Label);
            this.panel7.Location = new System.Drawing.Point(19, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 94);
            this.panel7.TabIndex = 2;
            // 
            // Premium_RadioButton
            // 
            this.Premium_RadioButton.AutoSize = true;
            this.Premium_RadioButton.Location = new System.Drawing.Point(63, 63);
            this.Premium_RadioButton.Name = "Premium_RadioButton";
            this.Premium_RadioButton.Size = new System.Drawing.Size(74, 19);
            this.Premium_RadioButton.TabIndex = 2;
            this.Premium_RadioButton.TabStop = true;
            this.Premium_RadioButton.Text = "Premium";
            this.Premium_RadioButton.UseVisualStyleBackColor = true;
            this.Premium_RadioButton.CheckedChanged += new System.EventHandler(this.Premium_RadioButton_CheckedChanged);
            // 
            // Standard_RadioButton
            // 
            this.Standard_RadioButton.AutoSize = true;
            this.Standard_RadioButton.Location = new System.Drawing.Point(63, 34);
            this.Standard_RadioButton.Name = "Standard_RadioButton";
            this.Standard_RadioButton.Size = new System.Drawing.Size(72, 19);
            this.Standard_RadioButton.TabIndex = 1;
            this.Standard_RadioButton.TabStop = true;
            this.Standard_RadioButton.Text = "Standard";
            this.Standard_RadioButton.UseVisualStyleBackColor = true;
            this.Standard_RadioButton.CheckedChanged += new System.EventHandler(this.Standard_RadioButton_CheckedChanged);
            // 
            // Calidad_Label
            // 
            this.Calidad_Label.AutoSize = true;
            this.Calidad_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calidad_Label.Location = new System.Drawing.Point(12, 12);
            this.Calidad_Label.Name = "Calidad_Label";
            this.Calidad_Label.Size = new System.Drawing.Size(137, 19);
            this.Calidad_Label.TabIndex = 0;
            this.Calidad_Label.Text = "Calidad de Prenda:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.StockDisponible_Label);
            this.panel6.Controls.Add(this.Stock_Label);
            this.panel6.Location = new System.Drawing.Point(19, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(393, 42);
            this.panel6.TabIndex = 1;
            // 
            // StockDisponible_Label
            // 
            this.StockDisponible_Label.AutoSize = true;
            this.StockDisponible_Label.Location = new System.Drawing.Point(233, 12);
            this.StockDisponible_Label.Name = "StockDisponible_Label";
            this.StockDisponible_Label.Size = new System.Drawing.Size(65, 15);
            this.StockDisponible_Label.TabIndex = 1;
            this.StockDisponible_Label.Text = "Cantidad X";
            this.StockDisponible_Label.Click += new System.EventHandler(this.StockDisponible_Label_Click);
            // 
            // Stock_Label
            // 
            this.Stock_Label.AutoSize = true;
            this.Stock_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Stock_Label.Location = new System.Drawing.Point(12, 12);
            this.Stock_Label.Name = "Stock_Label";
            this.Stock_Label.Size = new System.Drawing.Size(282, 19);
            this.Stock_Label.TabIndex = 0;
            this.Stock_Label.Text = "Unidades de Stock Disponibles: __________";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Pantalon_RadioButton);
            this.panel5.Controls.Add(this.Camisa_RadioButton);
            this.panel5.Controls.Add(this.Chupin_CheckBox);
            this.panel5.Controls.Add(this.Mao_CheckBox);
            this.panel5.Controls.Add(this.MangaCorta_CheckBox);
            this.panel5.Controls.Add(this.Prenda_Label);
            this.panel5.Location = new System.Drawing.Point(19, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 112);
            this.panel5.TabIndex = 0;
            // 
            // Pantalon_RadioButton
            // 
            this.Pantalon_RadioButton.AutoSize = true;
            this.Pantalon_RadioButton.Location = new System.Drawing.Point(37, 70);
            this.Pantalon_RadioButton.Name = "Pantalon_RadioButton";
            this.Pantalon_RadioButton.Size = new System.Drawing.Size(72, 19);
            this.Pantalon_RadioButton.TabIndex = 5;
            this.Pantalon_RadioButton.TabStop = true;
            this.Pantalon_RadioButton.Text = "Pantalon";
            this.Pantalon_RadioButton.UseVisualStyleBackColor = true;
            this.Pantalon_RadioButton.CheckedChanged += new System.EventHandler(this.Pantalon_RadioButton_CheckedChanged);
            // 
            // Camisa_RadioButton
            // 
            this.Camisa_RadioButton.AutoSize = true;
            this.Camisa_RadioButton.Location = new System.Drawing.Point(37, 28);
            this.Camisa_RadioButton.Name = "Camisa_RadioButton";
            this.Camisa_RadioButton.Size = new System.Drawing.Size(64, 19);
            this.Camisa_RadioButton.TabIndex = 4;
            this.Camisa_RadioButton.TabStop = true;
            this.Camisa_RadioButton.Text = "Camisa";
            this.Camisa_RadioButton.UseVisualStyleBackColor = true;
            this.Camisa_RadioButton.CheckedChanged += new System.EventHandler(this.Camisa_RadioButton_CheckedChanged);
            // 
            // Chupin_CheckBox
            // 
            this.Chupin_CheckBox.AutoSize = true;
            this.Chupin_CheckBox.Location = new System.Drawing.Point(172, 70);
            this.Chupin_CheckBox.Name = "Chupin_CheckBox";
            this.Chupin_CheckBox.Size = new System.Drawing.Size(65, 19);
            this.Chupin_CheckBox.TabIndex = 3;
            this.Chupin_CheckBox.Text = "Chupin";
            this.Chupin_CheckBox.UseVisualStyleBackColor = true;
            this.Chupin_CheckBox.CheckedChanged += new System.EventHandler(this.Chupin_CheckBox_CheckedChanged);
            // 
            // Mao_CheckBox
            // 
            this.Mao_CheckBox.AutoSize = true;
            this.Mao_CheckBox.Location = new System.Drawing.Point(288, 29);
            this.Mao_CheckBox.Name = "Mao_CheckBox";
            this.Mao_CheckBox.Size = new System.Drawing.Size(87, 19);
            this.Mao_CheckBox.TabIndex = 2;
            this.Mao_CheckBox.Text = "Cuello Mao";
            this.Mao_CheckBox.UseVisualStyleBackColor = true;
            this.Mao_CheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // MangaCorta_CheckBox
            // 
            this.MangaCorta_CheckBox.AutoSize = true;
            this.MangaCorta_CheckBox.Location = new System.Drawing.Point(172, 29);
            this.MangaCorta_CheckBox.Name = "MangaCorta_CheckBox";
            this.MangaCorta_CheckBox.Size = new System.Drawing.Size(95, 19);
            this.MangaCorta_CheckBox.TabIndex = 1;
            this.MangaCorta_CheckBox.Text = "Manga Corta";
            this.MangaCorta_CheckBox.UseVisualStyleBackColor = true;
            this.MangaCorta_CheckBox.CheckedChanged += new System.EventHandler(this.MangaCorta_CheckBox_CheckedChanged);
            // 
            // Prenda_Label
            // 
            this.Prenda_Label.AutoSize = true;
            this.Prenda_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Prenda_Label.Location = new System.Drawing.Point(12, 10);
            this.Prenda_Label.Name = "Prenda_Label";
            this.Prenda_Label.Size = new System.Drawing.Size(57, 19);
            this.Prenda_Label.TabIndex = 0;
            this.Prenda_Label.Text = "Prenda";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.Total_Label);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.Cotizar_Button);
            this.panel9.Location = new System.Drawing.Point(12, 459);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(430, 60);
            this.panel9.TabIndex = 5;
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total_Label.Location = new System.Drawing.Point(293, 17);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(42, 21);
            this.Total_Label.TabIndex = 2;
            this.Total_Label.Text = "Total";
            this.Total_Label.Click += new System.EventHandler(this.label15_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(220, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "$_______________";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Cotizar_Button
            // 
            this.Cotizar_Button.BackColor = System.Drawing.Color.Indigo;
            this.Cotizar_Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cotizar_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cotizar_Button.Location = new System.Drawing.Point(10, 3);
            this.Cotizar_Button.Name = "Cotizar_Button";
            this.Cotizar_Button.Size = new System.Drawing.Size(204, 52);
            this.Cotizar_Button.TabIndex = 0;
            this.Cotizar_Button.Text = "Cotizar";
            this.Cotizar_Button.UseVisualStyleBackColor = false;
            this.Cotizar_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 531);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaTienda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VistaTienda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label Tienda_Label;
        private Label Direccion_Label;
        private Panel panel3;
        private Label Nombre_Label;
        private Label label7;
        private Label Historial_Label;
        private Label CodVendedor_Label;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel9;
        private Button Cotizar_Button;
        private Label label8;
        private CheckBox MangaCorta_CheckBox;
        private Label Prenda_Label;
        private CheckBox Mao_CheckBox;
        private RadioButton Camisa_RadioButton;
        private CheckBox Chupin_CheckBox;
        private Label Stock_Label;
        private RadioButton Pantalon_RadioButton;
        private RadioButton Standard_RadioButton;
        private Label Calidad_Label;
        private TextBox Cantidad_TextBox;
        private TextBox PrecioUnit_TextBox;
        private Label label14;
        private Label label13;
        private Label PrecioCant_Label;
        private RadioButton Premium_RadioButton;
        private Label Total_Label;
        private Label StockDisponible_Label;
    }
}