using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void tsmVentanillas_Click(object sender, EventArgs e)
        {
            frmMantVentanillas frm = new  frmMantVentanillas   ();

            frm.Show();
        }

        private void tsmEmpleados_Click(object sender, EventArgs e)
        {
            frmMantEmpleados frm = new  frmMantEmpleados ();

            frm.Show();
        }

        private void tsmClientesAlDia_Click(object sender, EventArgs e)
        {
            frmReporte frm = new frmReporte();

            frm.Show();
        }

        private void ventanillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentanilla frm = new frmReporteVentanilla();
            frm.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEmpleado frm = new frmReporteEmpleado();
            frm.Show();
        }

        private void clienesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCliente fr = new frmReporteCliente();
            fr.Show();
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteClientePrestamo f = new frmReporteClientePrestamo();
            f.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
