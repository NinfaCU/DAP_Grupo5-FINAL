using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmReporteVentanilla : Form
    {
        public frmReporteVentanilla()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmReporteVentanilla_Load(object sender, EventArgs e)
        {
            NVentanilla Ven = new NVentanilla();
            this.dgvVentanilla.DataSource = Ven.buscarVentanilla_All();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conecte una Impresora", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
