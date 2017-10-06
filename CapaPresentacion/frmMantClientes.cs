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
    public partial class frmMantClientes : Form
    {
        private bool existeC = false;
        public frmMantClientes()
        {
            InitializeComponent();
        }

        //********************ADICIONALES***********************//

        public void limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtDireccion.Text = "";
            this.txtDNI.Text = "";
            this.txtRUC.Text = "";
            this.dtpFechaIngreso.Value = DateTime.Now;
            this.txtSaldoCuenta.Text = "";
        }

        public void inicial()
        {
            this.txtCodigo.Enabled = true;
            this.txtNombres.Enabled = false;
            this.txtApellidos.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtDNI.Enabled = false;
            this.txtRUC.Enabled = false;
            this.dtpFechaIngreso.Enabled = false;
            this.txtSaldoCuenta.Enabled = false;
            this.btnBuscar.Enabled = true;
            this.btnInsertar.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtCodigo.Focus();
        }

        //********************FIN***********************//

        private bool act;
        
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtNombres.Enabled = true;
            this.txtApellidos.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.txtDNI.Enabled = true;
            this.txtRUC.Enabled = true;
            this.dtpFechaIngreso.Enabled = true;
            this.txtSaldoCuenta.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnInsertar.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.txtNombres.Focus();
            this.existeC = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(this.txtNombres.Text==null || this.txtApellidos.Text==null || this.txtDireccion.Text==null || this.txtSaldoCuenta.Text==null || this.txtRUC.TextLength!=11 || this.txtDNI.TextLength != 8)
            {
                MessageBox.Show("Campos Faltantes", "Error al Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NCliente oCneg = new NCliente();

                string nombre = this.txtNombres.Text;
                string apellido = this.txtApellidos.Text;
                string direccion = this.txtDireccion.Text;
                string dni = this.txtDNI.Text;
                string ruc = this.txtRUC.Text;
                DateTime ingreso = this.dtpFechaIngreso.Value;
                double saldo = Convert.ToDouble(this.txtSaldoCuenta.Text);
                bool activo = true;

                string rpta = oCneg.insertarCliente(nombre, apellido, direccion, dni, ruc, ingreso, saldo, activo);

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Cliente Registrado", "Insertar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(rpta, "Error al Insertar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.limpiar();
                this.inicial();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (existeC)
            {
                if (this.txtNombres.Text == null && this.txtApellidos.Text == null && this.txtDireccion.Text == null && this.txtSaldoCuenta.Text == null && this.txtRUC.TextLength != 11 && this.txtDNI.TextLength != 8)
                {
                    MessageBox.Show("Ingrese Campos Válidos", "Error al Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NCliente oCneg = new NCliente();
                    int numero = Convert.ToInt32(this.txtCodigo.Text);
                    string nombre = this.txtNombres.Text;
                    string apellido = this.txtApellidos.Text;
                    string direccion = this.txtDireccion.Text;
                    string dni = this.txtDNI.Text;
                    string ruc = this.txtRUC.Text;
                    DateTime ingreso = this.dtpFechaIngreso.Value;
                    double saldo = Convert.ToDouble(this.txtSaldoCuenta.Text);
                    bool activo = true;

                    string rpta = oCneg.actualizarCliente(numero, nombre, apellido, direccion, dni, ruc, ingreso, saldo, activo);
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Cliente Modificado", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(rpta, "Error al Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limpiar();
                    inicial();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (existeC)
            {
                if (act==true)
                {
                    NCliente oCneg = new NCliente();
                    int numero = Convert.ToInt32(this.txtCodigo.Text);
                    string nombre = this.txtNombres.Text;
                    string apellido = this.txtApellidos.Text;
                    string direccion = this.txtDireccion.Text;
                    string dni = this.txtDNI.Text;
                    string ruc = this.txtRUC.Text;
                    DateTime ingreso = this.dtpFechaIngreso.Value;
                    double saldo = Convert.ToDouble(this.txtSaldoCuenta.Text);
                    bool activo = false;

                    string rpta = oCneg.actualizarCliente(numero, nombre, apellido, direccion, dni, ruc, ingreso, saldo, activo);
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Baja/Alta Cliente", "Baja Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(rpta, "ERROR al dar de Baja al Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limpiar();
                    inicial();
                }
                else
                {
                    NCliente oCneg = new NCliente();
                    int numero = Convert.ToInt32(this.txtCodigo.Text);
                    string nombre = this.txtNombres.Text;
                    string apellido = this.txtApellidos.Text;
                    string direccion = this.txtDireccion.Text;
                    string dni = this.txtDNI.Text;
                    string ruc = this.txtRUC.Text;
                    DateTime ingreso = this.dtpFechaIngreso.Value;
                    double saldo = Convert.ToDouble(this.txtSaldoCuenta.Text);
                    bool activo = true;

                    string rpta = oCneg.actualizarCliente(numero, nombre, apellido, direccion, dni, ruc, ingreso, saldo, activo);
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show(rpta, "Baja Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(rpta, "ERROR al dar de Baja al Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limpiar();
                    inicial();
                }
            }
        }

        private void frmMantClientes_Load(object sender, EventArgs e)
        {
            dtpFechaIngreso.Value = new DateTime(2014, 08, 17);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == null)
            {
                MessageBox.Show("Ingrese un Códgio", "Buscar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inicial();
            }
            else
            {
                int codigo = Convert.ToInt32(this.txtCodigo.Text);

                DataTable dt = new NCliente().buscarCliente_Codigo(codigo);
                this.existeC = false;

                foreach (DataRow row in dt.Rows)
                {
                    this.txtCodigo.Text = row["CodigoCliente"].ToString();
                    this.txtNombres.Text = row["Nombres"].ToString();
                    this.txtApellidos.Text = row["Apellidos"].ToString();
                    this.txtDireccion.Text = row["Direccion"].ToString();
                    this.txtDNI.Text = row["DNI"].ToString();
                    this.txtRUC.Text = row["RUC"].ToString();
                    this.dtpFechaIngreso.Value = Convert.ToDateTime(row["FechaIngreso"].ToString());
                    this.txtSaldoCuenta.Text = row["SaldoCuenta"].ToString();
                    this.act = Convert.ToBoolean(row["Activo"].ToString());
                    existeC = true;
                    break;
                }

                if (existeC)
                {
                    this.txtCodigo.Enabled = false;
                    this.txtNombres.Enabled = true;
                    this.txtApellidos.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.txtDNI.Enabled = true;
                    this.txtRUC.Enabled = true;
                    this.dtpFechaIngreso.Enabled = true;
                    this.txtSaldoCuenta.Enabled = true;
                    this.btnBuscar.Enabled = false;
                    this.btnGuardar.Enabled = false;
                    this.btnEliminar.Enabled = true;
                    this.btnModificar.Enabled = true;
                    this.btnInsertar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No existe un Cliente con ese Códgio", "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSaldoCuenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
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

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
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
