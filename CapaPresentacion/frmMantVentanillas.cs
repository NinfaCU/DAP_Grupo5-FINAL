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
    public partial class frmMantVentanillas : Form
    {
        private bool existe = false;
        public frmMantVentanillas()
        {
            InitializeComponent();
        }

        //********************ADICIONALES***********************//
        private void limpiar()
        {
            this.txtNumero.Text = "";
            this.txtUbicacion.Text = "";
            this.cmbTipo.SelectedIndex = -1;
        }

        public void inicial()
        {
            this.txtNumero.Enabled = true;
            this.txtUbicacion.Enabled = false;
            this.cmbTipo.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnBuscar.Enabled = true;
            this.btnInsertar.Enabled = true;
            this.txtNumero.Focus();
        }

        //********************FIN***********************//

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.txtUbicacion.Enabled = true;
            this.cmbTipo.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.txtNumero.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnInsertar.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.txtUbicacion.Focus();
            this.existe = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text==null || this.txtUbicacion.Text== null || this.cmbTipo.SelectedIndex==-1)
            {
                MessageBox.Show("Ingrese Campos Faltantes", "Error al Guardar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NVentanilla oVneg = new NVentanilla();

                string ubicacion = this.txtUbicacion.Text.ToUpper();
                string tipo = this.cmbTipo.SelectedItem.ToString();

                string rpta = oVneg.insertarVentanilla(ubicacion, tipo);

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Ventanilla Registrada", "Guardar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(rpta, "Error al Guardar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.limpiar();
                this.inicial();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text == null)
            {
                MessageBox.Show("Ingrese un Número", "Buscar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                inicial();
            }
            else
            {
                int codigo = Convert.ToInt32(this.txtNumero.Text);

                DataTable dt = new NVentanilla().buscarVentanilla_Codigo(codigo);
                this.existe = false;

                foreach (DataRow row in dt.Rows)
                {
                    this.txtNumero.Text = row["NumeroVentanilla"].ToString();
                    this.txtUbicacion.Text = row["Ubicacion"].ToString();
                    this.cmbTipo.SelectedItem = row["TipoAtencion"].ToString();
                    existe = true;
                    break;
                }

                if (existe)
                {
                    this.txtNumero.Enabled = false;
                    this.txtUbicacion.Enabled = true;
                    this.cmbTipo.Enabled = true;
                    this.btnBuscar.Enabled = false;
                    this.btnGuardar.Enabled = false;
                    this.btnEliminar.Enabled = true;
                    this.btnModificar.Enabled = true;
                    this.btnInsertar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No existe una Ventanilla con ese códgio", "Buscar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    inicial();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (existe)
            {
                if(this.txtNumero.Text == null || this.txtUbicacion.Text == null || this.cmbTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese Campos Faltantes", "Error al Modficiar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NVentanilla oVneg = new NVentanilla();
                    int numero = Convert.ToInt32(this.txtNumero.Text);
                    string ubicacion = this.txtUbicacion.Text.ToUpper();
                    string tipo = this.cmbTipo.SelectedItem.ToString();

                    string rpta = oVneg.actualizarVentanilla(numero, ubicacion, tipo);
                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Ventanilla Modificada", "Modificar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(rpta, "Error al Modificar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limpiar();
                    inicial();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (existe)
            {
                NVentanilla oVneg = new NVentanilla();
                int numero = Convert.ToInt32(this.txtNumero.Text);

                string rpta = oVneg.eliminarVentanilla(numero);
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show(rpta, "Eliminar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(rpta, "Error al Eliminar Ventanilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                limpiar();
                inicial();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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
