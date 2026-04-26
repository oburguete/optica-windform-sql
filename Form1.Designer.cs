namespace OpticaWinForms
{
    partial class FrmPedido
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
            Cliente = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            txtAnticipo = new TextBox();
            txtResta = new TextBox();
            cmbMica = new ComboBox();
            cmbTratamiento = new ComboBox();
            cmbArmazon = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtODEsfera = new TextBox();
            txtODCilindro = new TextBox();
            txtODEje = new TextBox();
            txtAdicion = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtOIEje = new MaskedTextBox();
            txtOIEsfera = new TextBox();
            txtOICilindro = new TextBox();
            label18 = new Label();
            txtObservaciones = new TextBox();
            SuspendLayout();
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(8, 18);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(114, 20);
            Cliente.TabIndex = 0;
            Cliente.Text = "Nombre Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 71);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Tipo de Mica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 173);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Tratamiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 219);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Armazon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 282);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 327);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 6;
            label7.Text = "Anticipo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.ScrollBars = ScrollBars.Horizontal;
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(119, 68);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(119, 275);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 9;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 375);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 10;
            label1.Text = "Resta";
            // 
            // txtAnticipo
            // 
            txtAnticipo.Location = new Point(119, 320);
            txtAnticipo.Name = "txtAnticipo";
            txtAnticipo.Size = new Size(125, 27);
            txtAnticipo.TabIndex = 11;
            // 
            // txtResta
            // 
            txtResta.Location = new Point(119, 368);
            txtResta.Name = "txtResta";
            txtResta.ReadOnly = true;
            txtResta.Size = new Size(125, 27);
            txtResta.TabIndex = 12;
            // 
            // cmbMica
            // 
            cmbMica.FormattingEnabled = true;
            cmbMica.Location = new Point(119, 126);
            cmbMica.Name = "cmbMica";
            cmbMica.Size = new Size(151, 28);
            cmbMica.TabIndex = 13;
            // 
            // cmbTratamiento
            // 
            cmbTratamiento.FormattingEnabled = true;
            cmbTratamiento.Location = new Point(119, 166);
            cmbTratamiento.Name = "cmbTratamiento";
            cmbTratamiento.Size = new Size(151, 28);
            cmbTratamiento.TabIndex = 14;
            // 
            // cmbArmazon
            // 
            cmbArmazon.FormattingEnabled = true;
            cmbArmazon.Location = new Point(119, 211);
            cmbArmazon.Name = "cmbArmazon";
            cmbArmazon.Size = new Size(151, 28);
            cmbArmazon.TabIndex = 15;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(346, 318);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(346, 366);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(346, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 25);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 19;
            label8.Text = "OJO DERECHO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(363, 166);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 20;
            label9.Text = "OJO IZQUIERDO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(363, 52);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 21;
            label10.Text = "Esfera";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(363, 78);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 22;
            label11.Text = "Cilindro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(361, 111);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 23;
            label12.Text = "Adicion";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(573, 85);
            label13.Name = "label13";
            label13.Size = new Size(29, 20);
            label13.TabIndex = 24;
            label13.Text = "Eje";
            // 
            // txtODEsfera
            // 
            txtODEsfera.Location = new Point(430, 45);
            txtODEsfera.Name = "txtODEsfera";
            txtODEsfera.Size = new Size(125, 27);
            txtODEsfera.TabIndex = 25;
            // 
            // txtODCilindro
            // 
            txtODCilindro.Location = new Point(430, 78);
            txtODCilindro.Name = "txtODCilindro";
            txtODCilindro.Size = new Size(125, 27);
            txtODCilindro.TabIndex = 26;
            // 
            // txtODEje
            // 
            txtODEje.Location = new Point(618, 83);
            txtODEje.Name = "txtODEje";
            txtODEje.Size = new Size(125, 27);
            txtODEje.TabIndex = 27;
            // 
            // txtAdicion
            // 
            txtAdicion.Location = new Point(432, 116);
            txtAdicion.Name = "txtAdicion";
            txtAdicion.Size = new Size(125, 27);
            txtAdicion.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(363, 202);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 29;
            label14.Text = "Esfera";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(360, 241);
            label15.Name = "label15";
            label15.Size = new Size(61, 20);
            label15.TabIndex = 30;
            label15.Text = "Cilindro";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(584, 245);
            label16.Name = "label16";
            label16.Size = new Size(29, 20);
            label16.TabIndex = 31;
            label16.Text = "Eje";
            // 
            // txtOIEje
            // 
            txtOIEje.Location = new Point(618, 245);
            txtOIEje.Name = "txtOIEje";
            txtOIEje.Size = new Size(125, 27);
            txtOIEje.TabIndex = 33;
            // 
            // txtOIEsfera
            // 
            txtOIEsfera.Location = new Point(438, 205);
            txtOIEsfera.Name = "txtOIEsfera";
            txtOIEsfera.Size = new Size(125, 27);
            txtOIEsfera.TabIndex = 34;
            // 
            // txtOICilindro
            // 
            txtOICilindro.Location = new Point(438, 238);
            txtOICilindro.Name = "txtOICilindro";
            txtOICilindro.Size = new Size(125, 27);
            txtOICilindro.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(580, 124);
            label18.Name = "label18";
            label18.Size = new Size(105, 20);
            label18.TabIndex = 37;
            label18.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(618, 157);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(170, 65);
            txtObservaciones.TabIndex = 38;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtObservaciones);
            Controls.Add(label18);
            Controls.Add(txtOICilindro);
            Controls.Add(txtOIEsfera);
            Controls.Add(txtOIEje);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtAdicion);
            Controls.Add(txtODEje);
            Controls.Add(txtODCilindro);
            Controls.Add(txtODEsfera);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cmbArmazon);
            Controls.Add(cmbTratamiento);
            Controls.Add(cmbMica);
            Controls.Add(txtResta);
            Controls.Add(txtAnticipo);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cliente);
            Name = "FrmPedido";
            Text = "Pedido de Lentes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtPrecio;
        private Label label1;
        private TextBox txtAnticipo;
        private TextBox txtResta;
        private ComboBox cmbMica;
        private ComboBox cmbTratamiento;
        private ComboBox cmbArmazon;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtODEsfera;
        private TextBox txtODCilindro;
        private TextBox txtODEje;
        private TextBox txtAdicion;
        private Label label14;
        private Label label15;
        private Label label16;
        private MaskedTextBox txtOIEje;
        private TextBox txtOIEsfera;
        private TextBox txtOICilindro;
        private Label label18;
        private TextBox txtObservaciones;
    }
}
