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
    public partial class frmReporteCliente : Form
    {
        public frmReporteCliente()
        {
            InitializeComponent();
        }

        private void frmReporteCliente_Load(object sender, EventArgs e)
        {
            NCliente cli = new NCliente();
            this.dgvCliente.DataSource = cli.buscarCliente_All();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conecte una Impresora", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
