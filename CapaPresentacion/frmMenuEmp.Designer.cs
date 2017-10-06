namespace CapaPresentacion
{
    partial class frmMenuEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuEmp));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnRepoCliente = new System.Windows.Forms.Button();
            this.btnRepoPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(45, 29);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 69);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(368, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnPrestamo.Image")));
            this.btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrestamo.Location = new System.Drawing.Point(195, 29);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(75, 69);
            this.btnPrestamo.TabIndex = 2;
            this.btnPrestamo.Text = "Préstamo";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagos.Location = new System.Drawing.Point(343, 29);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(75, 69);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnRepoCliente
            // 
            this.btnRepoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRepoCliente.Image")));
            this.btnRepoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRepoCliente.Location = new System.Drawing.Point(120, 140);
            this.btnRepoCliente.Name = "btnRepoCliente";
            this.btnRepoCliente.Size = new System.Drawing.Size(75, 81);
            this.btnRepoCliente.TabIndex = 4;
            this.btnRepoCliente.Text = "Reportar Cliente";
            this.btnRepoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRepoCliente.UseVisualStyleBackColor = true;
            this.btnRepoCliente.Click += new System.EventHandler(this.btnRepoCliente_Click);
            // 
            // btnRepoPrestamo
            // 
            this.btnRepoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepoPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnRepoPrestamo.Image")));
            this.btnRepoPrestamo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRepoPrestamo.Location = new System.Drawing.Point(271, 140);
            this.btnRepoPrestamo.Name = "btnRepoPrestamo";
            this.btnRepoPrestamo.Size = new System.Drawing.Size(75, 81);
            this.btnRepoPrestamo.TabIndex = 5;
            this.btnRepoPrestamo.Text = "Reportar Prestamos";
            this.btnRepoPrestamo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRepoPrestamo.UseVisualStyleBackColor = true;
            this.btnRepoPrestamo.Click += new System.EventHandler(this.btnRepoPrestamo_Click);
            // 
            // frmMenuEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 303);
            this.Controls.Add(this.btnRepoPrestamo);
            this.Controls.Add(this.btnRepoCliente);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmMenuEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA FINANCIERO \"LOS LEALES\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnRepoCliente;
        private System.Windows.Forms.Button btnRepoPrestamo;
    }
}