namespace CapaPresentacion
{
    partial class frmRegPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegPrestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMontoPrestado = new System.Windows.Forms.TextBox();
            this.txtMontoInteres = new System.Windows.Forms.TextBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.nudCuotas = new System.Windows.Forms.NumericUpDown();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto Prestado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro de Cuotas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto Interes";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(153, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtMontoPrestado
            // 
            this.txtMontoPrestado.Enabled = false;
            this.txtMontoPrestado.Location = new System.Drawing.Point(153, 236);
            this.txtMontoPrestado.Name = "txtMontoPrestado";
            this.txtMontoPrestado.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPrestado.TabIndex = 8;
            this.txtMontoPrestado.TextChanged += new System.EventHandler(this.txtMontoPrestado_TextChanged);
            this.txtMontoPrestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPrestado_KeyPress);
            // 
            // txtMontoInteres
            // 
            this.txtMontoInteres.Enabled = false;
            this.txtMontoInteres.Location = new System.Drawing.Point(153, 332);
            this.txtMontoInteres.Name = "txtMontoInteres";
            this.txtMontoInteres.Size = new System.Drawing.Size(100, 20);
            this.txtMontoInteres.TabIndex = 11;
            this.txtMontoInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoInteres_KeyPress);
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Enabled = false;
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(153, 155);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaPrestamo.TabIndex = 35;
            // 
            // nudCuotas
            // 
            this.nudCuotas.Enabled = false;
            this.nudCuotas.Location = new System.Drawing.Point(153, 284);
            this.nudCuotas.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudCuotas.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCuotas.Name = "nudCuotas";
            this.nudCuotas.Size = new System.Drawing.Size(99, 20);
            this.nudCuotas.TabIndex = 36;
            this.nudCuotas.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCuotas.ValueChanged += new System.EventHandler(this.nudCuotas_ValueChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(295, 66);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 22);
            this.btnInsertar.TabIndex = 38;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(295, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 22);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(153, 195);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(100, 20);
            this.dtpHora.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cliente Codigo";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(153, 110);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(100, 21);
            this.cmbCliente.TabIndex = 44;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(153, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 23);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Empleado Código";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.Enabled = false;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(153, 68);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(100, 21);
            this.cmbEmpleado.TabIndex = 47;
            // 
            // frmRegPrestamos
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 417);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.nudCuotas);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.txtMontoInteres);
            this.Controls.Add(this.txtMontoPrestado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.nudCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMontoPrestado;
        private System.Windows.Forms.TextBox txtMontoInteres;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.NumericUpDown nudCuotas;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEmpleado;
    }
}