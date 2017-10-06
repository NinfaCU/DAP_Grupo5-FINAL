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
    public partial class frmRegPagos : Form
    {
        NCuota oCum = new NCuota();

        public frmRegPagos()
        {
            InitializeComponent();
        }

        //********************ADICIONALES***********************//

        private void limpiar()
        {
            this.cmbCodigo.SelectedIndex = -1;
            this.cmbCliente.SelectedIndex = -1;
            this.cmbEmpleado.SelectedIndex = -1;
            this.dtpFecha.Value = DateTime.Now;
            this.dtpHora.Value = DateTime.Now;
            this.txtTotalCuota.Text = "";
            this.txtMora.Text = "";
            this.txtPago.Text = "";
        }

        private void inicial(bool v)
        {
            this.cmbCodigo.Enabled = v;
            this.cmbCliente.Enabled = v;
            this.cmbEmpleado.Enabled = v;
            this.dtpFecha.Enabled = v;
            this.dtpHora.Enabled = v;
            this.txtTotalCuota.Enabled = v;
            this.txtMora.Enabled = v;
            this.btnBuscar.Enabled = !v;
            this.btnInsertar.Enabled = !v;
            this.btnGuardar.Enabled = v;
        }

        private void llenarCliente()
        {
            this.cmbCliente.DataSource = new NCliente().BuscarTodosConPrestamo();
            this.cmbCliente.ValueMember = "CodigoCliente";
            this.cmbCliente.DisplayMember = "CodigoCliente";
        }

        private void llenarEmpleado()
        {
            this.cmbEmpleado.DataSource = new NEmpleado().buscarEmpleado_All();
            this.cmbEmpleado.ValueMember = "CodigoEmpleado";
            this.cmbEmpleado.DisplayMember = "CodigoEmpleado";
        }

        private void llenarCodigo()
        {
            int codigoC = Convert.ToInt32(this.cmbCliente.SelectedValue.ToString());
            this.cmbCodigo.DataSource = new NCuota().buscarCuota_Codigo(codigoC);
            this.cmbCodigo.ValueMember = "CodigoCuota";
            this.cmbCodigo.DisplayMember = "CodigoCuota";
        }

        //********************FIN***********************//

        private void frmRegPagos_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.inicial(true);
            this.llenarCliente();
            this.llenarEmpleado();
            this.cmbCliente.SelectedIndex = -1;
            this.cmbEmpleado.SelectedIndex = -1;
            this.txtMora.Text = "0";
            this.txtTotalCuota.Enabled = false;
            this.txtMora.Enabled = false;
            this.txtPago.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.btnInsertar.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cmbCliente.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ingrese un Código de Cliente", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.txtTotalCuota.Text = "";
                this.txtTotalCuota.Enabled = true;
                this.txtMora.Enabled = true;
                this.btnGuardar.Enabled = true;
                int codigoC = Convert.ToInt32(this.cmbCliente.SelectedValue.ToString());
                DataTable dt = new NCuota().buscarCuota_Codigo(codigoC);

                foreach (DataRow row in dt.Rows)
                {
                    this.txtTotalCuota.Text = row["ImporteTotalCuota"].ToString();
                }

                double r = Convert.ToDouble(this.txtTotalCuota.Text) + Convert.ToDouble(this.txtMora.Text);
                this.txtPago.Text = r.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NPago oPneg = new NPago();
            NCuota oCneg = new NCuota();

            int codigo = Convert.ToInt32(this.cmbCodigo.SelectedValue.ToString());
            int clientecodigo = Convert.ToInt32(this.cmbCliente.SelectedValue.ToString());
            int empleadocodigo = Convert.ToInt32(this.cmbEmpleado.SelectedValue.ToString());
            DateTime fecha = this.dtpFecha.Value;
            DateTime hora = this.dtpHora.Value;
            double totalcuota = Convert.ToDouble(this.txtTotalCuota.Text);
            double mora = Convert.ToDouble(this.txtMora.Text);
            double pago = Convert.ToDouble(this.txtPago.Text);

            string rpta = oPneg.insertarPago(codigo, empleadocodigo, clientecodigo, fecha, hora, totalcuota, mora, pago);

            if (rpta.Equals("OK"))
            {
                MessageBox.Show(rpta, "Insertar Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rpta, "ERROR al Insertar Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool cancel = true;
            string rpta2 = oCneg.actualizarCuota(codigo, cancel);

            if (rpta2.Equals("OK"))
            {
                MessageBox.Show(rpta2, "Modificar Cuota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rpta2, "ERROR al Modificar Cuota", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.limpiar();
            this.inicial(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.llenarCodigo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
