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
    public partial class frmReporteEmpleado : Form
    {
        public frmReporteEmpleado()
        {
            InitializeComponent();
        }

        private void frmReporteEmpleado_Load(object sender, EventArgs e)
        {
            NEmpleado oEm = new NEmpleado();
            this.dgvEmpleado.DataSource = oEm.buscarEmpleado_All();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conecte una Impresora", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
