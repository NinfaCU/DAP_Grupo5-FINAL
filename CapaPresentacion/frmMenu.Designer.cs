namespace CapaPresentacion
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentanillas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportar = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMantenimiento,
            this.tsmReportar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVentanillas,
            this.tsmEmpleados});
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(62, 20);
            this.tsmMantenimiento.Text = "Registro";
            // 
            // tsmVentanillas
            // 
            this.tsmVentanillas.Name = "tsmVentanillas";
            this.tsmVentanillas.Size = new System.Drawing.Size(152, 22);
            this.tsmVentanillas.Text = "Ventanillas";
            this.tsmVentanillas.Click += new System.EventHandler(this.tsmVentanillas_Click);
            // 
            // tsmEmpleados
            // 
            this.tsmEmpleados.Name = "tsmEmpleados";
            this.tsmEmpleados.Size = new System.Drawing.Size(152, 22);
            this.tsmEmpleados.Text = "Empleados";
            this.tsmEmpleados.Click += new System.EventHandler(this.tsmEmpleados_Click);
            // 
            // tsmReportar
            // 
            this.tsmReportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanillasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.clienesToolStripMenuItem,
            this.préstamosToolStripMenuItem});
            this.tsmReportar.Name = "tsmReportar";
            this.tsmReportar.Size = new System.Drawing.Size(64, 20);
            this.tsmReportar.Text = "Reportar";
            // 
            // ventanillasToolStripMenuItem
            // 
            this.ventanillasToolStripMenuItem.Name = "ventanillasToolStripMenuItem";
            this.ventanillasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventanillasToolStripMenuItem.Text = "Ventanillas";
            this.ventanillasToolStripMenuItem.Click += new System.EventHandler(this.ventanillasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // clienesToolStripMenuItem
            // 
            this.clienesToolStripMenuItem.Name = "clienesToolStripMenuItem";
            this.clienesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienesToolStripMenuItem.Text = "Clientes";
            this.clienesToolStripMenuItem.Click += new System.EventHandler(this.clienesToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            this.préstamosToolStripMenuItem.Click += new System.EventHandler(this.préstamosToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA FINANCIERO “LOS LEGALES”";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 519);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupo 5: Chiroque G. - Caballero C. - Neyra O. - Ramos S.";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA FINANCIERO “LOS LEALES”";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmVentanillas;
        private System.Windows.Forms.ToolStripMenuItem tsmEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsmReportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ventanillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
    }
}