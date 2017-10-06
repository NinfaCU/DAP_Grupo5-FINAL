using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class frmMenuEmp : Form
    {
        public frmMenuEmp()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmMantClientes frm = new frmMantClientes();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            frmRegPrestamos frm = new frmRegPrestamos();
            frm.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            frmRegPagos frm = new frmRegPagos();
            frm.Show();
        }

        private void btnRepoCliente_Click(object sender, EventArgs e)
        {
            frmReporteCliente fr = new frmReporteCliente();
            fr.Show();
        }

        private void btnRepoPrestamo_Click(object sender, EventArgs e)
        {
            frmReporteClientePrestamo f = new frmReporteClientePrestamo();
            f.Show();
        }
    }
}
