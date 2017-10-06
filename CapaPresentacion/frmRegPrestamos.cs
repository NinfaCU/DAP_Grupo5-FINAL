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
    public partial class frmRegPrestamos : Form
    {
        private bool existeP = false;
        public int numprest = 1;
        static public int a = 1;

        public frmRegPrestamos()
        {
            InitializeComponent();
        }

        //********************ADICIONALES***********************//

        private void limpiar()
        {
            this.txtCodigo.Text = "";
            this.cmbEmpleado.SelectedIndex = -1;
            this.cmbCliente.SelectedIndex = -1;
            this.dtpFechaPrestamo.Value = DateTime.Now;
            this.dtpHora.Value = DateTime.Now;
            this.txtMontoPrestado.Text = "0";
            this.nudCuotas.Value = 12;
            this.txtMontoInteres.Text = "";
        }

        public void inicial()
        {
            this.txtCodigo.Enabled = true;
            this.cmbEmpleado.Enabled = false;
            this.cmbCliente.Enabled = false;
            this.dtpFechaPrestamo.Enabled = false;
            this.dtpHora.Enabled = false;
            this.txtMontoPrestado.Enabled = false;
            this.nudCuotas.Enabled = false;
            this.txtMontoInteres.Enabled = false;
            this.btnBuscar.Enabled = true;
            this.btnInsertar.Enabled = true;
            this.btnGuardar.Enabled = false;
        }

        private void llenarEmpleado()
        {
            this.cmbEmpleado.DataSource = new NEmpleado().buscarEmpleado_All();
            this.cmbEmpleado.ValueMember = "CodigoEmpleado";
            this.cmbEmpleado.DisplayMember = "CodigoEmpleado";
        }

        private void llenarCliente()
        {
            this.cmbCliente.DataSource = new NCliente().buscarClienteSinPrestamo();
            this.cmbCliente.ValueMember = "CodigoCliente";
            this.cmbCliente.DisplayMember = "CodigoCliente";
        }

        private void llenarTodoCliente()
        {
            this.cmbCliente.DataSource = new NCliente().buscarCliente_All();
            this.cmbCliente.ValueMember = "CodigoCliente";
            this.cmbCliente.DisplayMember = "CodigoCliente";
        }

        //********************FIN***********************//

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.cmbCliente.Enabled = true;
            this.cmbEmpleado.Enabled = true;
            this.dtpFechaPrestamo.Enabled = true;
            this.dtpHora.Enabled = true;
            this.txtMontoInteres.Enabled = false;
            this.txtMontoPrestado.Enabled = true;
            this.nudCuotas.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnBuscar.Enabled = false;
            this.btnInsertar.Enabled = false;
            this.llenarEmpleado();
            this.llenarCliente();
            this.existeP = false;
            this.limpiar();
        }

        private void txtMontoPrestado_TextChanged(object sender, EventArgs e)
        {
            double IM, MI;
            IM = (0.015) * Convert.ToDouble(this.txtMontoPrestado.Text);
            MI = IM * (Convert.ToDouble(this.nudCuotas.Value));
            string MIt = Convert.ToString(MI);
            this.txtMontoInteres.Text = MIt;
        }

        private void nudCuotas_ValueChanged(object sender, EventArgs e)
        {
            double IM, MI;
            IM = (0.015) * Convert.ToDouble(this.txtMontoPrestado.Text);
            MI = IM * (Convert.ToDouble(this.nudCuotas.Value));
            string MIt = Convert.ToString(MI);
            this.txtMontoInteres.Text = MIt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.cmbEmpleado.SelectedIndex==-1 || this.cmbCliente.SelectedIndex==-1 || this.txtMontoInteres.Text==null || this.txtMontoPrestado.Text==null)
            {
                MessageBox.Show("Ingrese Campos Faltantes", "Error al Guardar Préstamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //******************Prestamo******************

                double mc, im, ift, tc;
                NPrestamo oPneg = new NPrestamo();
                NCuota oCneg = new NCuota();

                int empleadocodigo = Convert.ToInt32(this.cmbEmpleado.SelectedValue.ToString());
                int clientecodigo = Convert.ToInt32(this.cmbCliente.SelectedValue.ToString());
                DateTime fecha = this.dtpFechaPrestamo.Value;
                DateTime hora = this.dtpHora.Value;
                double montoprestado = Convert.ToDouble(this.txtMontoPrestado.Text);
                int nrocuotas = Convert.ToInt32(this.nudCuotas.Value);
                double montointeres = Convert.ToDouble(this.txtMontoInteres.Text);
                bool cancelado = false;

                string rpta = oPneg.insertarPrestamo(clientecodigo, empleadocodigo, fecha, hora, montoprestado, nrocuotas, montointeres, cancelado);

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Préstamo Registrado", "Guardar Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //******************Cuotas******************

                    mc = Convert.ToDouble(txtMontoPrestado.Text) / Convert.ToDouble(nudCuotas.Value);
                    im = 0.015 * Convert.ToDouble(txtMontoPrestado.Text);
                    ift = 0.00082 * mc;
                    tc = mc + im + ift;
                    bool canceladocuota = false;

                    string rpta2 = "";

                    for (int i = 0; i < Convert.ToInt32(nudCuotas.Value); i++)
                    {
                        rpta2 = oCneg.insertarCuota(a, fecha, mc, im, ift, tc, canceladocuota);
                    }

                    if (rpta2.Equals("OK"))
                    {
                        MessageBox.Show("Cuota Registrada", "Guardar Cuota", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(rpta2, "Error al Guardar Cuota", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    a++;
                }
                else
                {
                    MessageBox.Show(rpta, "Error al Guardar Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.limpiar();
                this.inicial();
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == null)
            {
                MessageBox.Show("Ingrese un Códgio", "Buscar Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                inicial();
            }
            else
            {
                int codigo = Convert.ToInt32(this.txtCodigo.Text);

                DataTable dt = new NPrestamo().buscarPrestamo_Codigo(codigo);
                this.existeP = false;

                foreach (DataRow row in dt.Rows)
                {
                    this.txtCodigo.Text = row["CodigoPrestamo"].ToString();
                    this.llenarEmpleado();
                    this.cmbEmpleado.SelectedValue = row["CodigoEmpleado"].ToString();
                    this.llenarTodoCliente();
                    this.cmbCliente.SelectedValue = row["CodigoCliente"].ToString();
                    this.dtpFechaPrestamo.Value = Convert.ToDateTime(row["FechaPrestamo"].ToString());
                    this.dtpHora.Value = Convert.ToDateTime(row["Hora"].ToString());
                    this.txtMontoPrestado.Text = row["MontoPrestamo"].ToString();
                    this.nudCuotas.Value = Convert.ToDecimal(row["NroCuotas"].ToString());
                    this.txtMontoInteres.Text = row["MontoInteres"].ToString();
                    existeP = true;
                    break;
                }

                if (existeP)
                {
                    this.inicial();
                }
                else
                {
                    MessageBox.Show("No existe el Préstamo con ese Códgio", "Buscar Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    inicial();
                }
            }
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMontoPrestado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMontoInteres_KeyPress(object sender, KeyPressEventArgs e)
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
