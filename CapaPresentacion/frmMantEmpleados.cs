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
    public partial class frmMantEmpleados : Form
    {
        private bool existeE = false;
        public frmMantEmpleados()
        {
            InitializeComponent();
        }

        //********************ADICIONALES***********************//

        private void limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtDireccion.Text = "";
            this.txtDNI.Text = "";
            this.cmbCategoria.SelectedIndex = -1;
            this.cmbVentanilla.SelectedIndex = -1;
        }

        private void inicial()
        {
            this.txtCodigo.Enabled = true;
            this.txtNombres.Enabled = false;
            this.txtApellidos.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtDNI.Enabled = false;
            this.cmbCategoria.Enabled = false;
            this.cmbVentanilla.Enabled = false;
            this.btnBuscar.Enabled = true;
            this.btnInsertar.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.txtCodigo.Focus();
        }

        private void llenarVentanillas()
        {
            this.cmbVentanilla.DataSource = new NVentanilla().buscarVentanillaSinEmpleado();
            this.cmbVentanilla.ValueMember = "NumeroVentanilla";
            this.cmbVentanilla.DisplayMember = "NumeroVentanilla";
        }
        
        private void habilitar(bool v)
        {
            this.txtCodigo.Enabled = !v;
            this.txtNombres.Enabled = v;
            this.txtApellidos.Enabled = v;
            this.txtDireccion.Enabled = v;
            this.txtDNI.Enabled = v;
            this.cmbCategoria.Enabled = v;
            this.cmbVentanilla.Enabled = v;
        }

        //********************FIN***********************//

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(true);
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.btnInsertar.Enabled = false;
            this.llenarVentanillas();
            this.existeE = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombres.Text == null || this.txtApellidos.Text == null || this.txtDireccion.Text == null || this.txtDNI.TextLength != 8 || this.cmbCategoria.SelectedIndex == -1 || this.cmbVentanilla.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese Campos Faltantes", "Error al Guardar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NEmpleado oEneg = new NEmpleado();

                int numventanilla = Convert.ToInt32(this.cmbVentanilla.SelectedValue.ToString());
                string nombre = this.txtNombres.Text;
                string apellido = this.txtApellidos.Text;
                string direccion = this.txtDireccion.Text;
                string dni = this.txtDNI.Text;
                string categoria = this.cmbCategoria.SelectedItem.ToString();

                string rpta = oEneg.insertarEmpleado(numventanilla, nombre, apellido, direccion, dni, categoria);

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Empleado Registrado", "Guardar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(rpta, "Error al Guardar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.limpiar();
                this.inicial();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (existeE)
            {
                if (this.txtNombres.Text == null || this.txtApellidos.Text == null || this.txtDireccion.Text == null || this.txtDNI.TextLength != 8 || this.cmbCategoria.SelectedIndex == -1 || this.cmbVentanilla.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese Campos Faltantes", "Error al Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NEmpleado oEneg = new NEmpleado();
                    int numero = Convert.ToInt32(this.txtCodigo.Text);
                    int numventanilla = Convert.ToInt32(this.cmbVentanilla.SelectedValue.ToString());
                    string nombre = this.txtNombres.Text;
                    string apellido = this.txtApellidos.Text;
                    string direccion = this.txtDireccion.Text;
                    string dni = this.txtDNI.Text;
                    string categoria = this.cmbCategoria.SelectedItem.ToString();

                    string rpta = oEneg.actualizarEmpleado(numero, numventanilla, nombre, apellido, direccion, dni, categoria);
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Empleado Modificado", "Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(rpta, "Error al Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limpiar();
                    inicial();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == null)
            {
                MessageBox.Show("Ingrese un Códgio", "Buscar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                inicial();
            }
            else
            {
                int codigo = Convert.ToInt32(this.txtCodigo.Text);

                DataTable dt = new NEmpleado().buscarEmpleado_Codigo(codigo);
                this.existeE = false;

                foreach (DataRow row in dt.Rows)
                {
                    this.txtCodigo.Text = row["CodigoEmpleado"].ToString();
                    this.txtNombres.Text = row["Nombres"].ToString();
                    this.txtApellidos.Text = row["Apellidos"].ToString();
                    this.txtDireccion.Text = row["Direccion"].ToString();
                    this.txtDNI.Text = row["DNI"].ToString();
                    this.cmbCategoria.SelectedItem = row["Categoria"].ToString();
                    llenarVentanillas();
                    this.cmbVentanilla.SelectedValue = row["NumeroVentanilla"].ToString();
                    this.existeE = true;
                    break;
                }

                if (existeE)
                {
                    this.btnBuscar.Enabled = false;
                    this.btnGuardar.Enabled = false;
                    this.btnEliminar.Enabled = true;
                    this.btnModificar.Enabled = true;
                    this.btnInsertar.Enabled = false;
                    habilitar(true);
                }
                else
                {
                    MessageBox.Show("No existe un Empleado con ese códgio", "Buscar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    inicial();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (existeE)
            {
                NEmpleado oEneg = new NEmpleado();
                int numero = Convert.ToInt32(this.txtCodigo.Text);

                string rpta = oEneg.eliminarEmpleado(numero);
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Empelado Eliminado", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(rpta, "Error al Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                limpiar();
                inicial();
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
    }
}
