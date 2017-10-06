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
    public partial class frmReporteClientePrestamo : Form
    {
        NCliente oCm = new NCliente();
        NCuota oCum = new NCuota();
            
        public frmReporteClientePrestamo()
        {
            InitializeComponent();
        }

        private void llenarCliente()
        {
            this.cmbCliente.DataSource = new NCliente().BuscarTodosConPrestamo();
            this.cmbCliente.ValueMember = "CodigoCliente";
            this.cmbCliente.DisplayMember = "CodigoCliente";
        }

        private void frmReporteClientePrestamo_Load(object sender, EventArgs e)
        {
            this.llenarCliente();
            this.cmbCliente.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigoP = Convert.ToInt32(this.cmbCliente.SelectedValue.ToString());
            this.dgvPrestamo.DataSource = oCm.buscarClienteConPrestamo(codigoP);

            int codigoC = Convert.ToInt32(this.cmbCliente.SelectedValue.ToString());
            this.dgvCuotas.DataSource = oCum.buscarCuota_Codigo(codigoC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conecte una Impresora", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
