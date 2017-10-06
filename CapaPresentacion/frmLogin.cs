using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void frmLogin_Load(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.txtUsuario.Text=="admin" && this.txtContra.Text == "admin")
            {
                frmMenu frm = new frmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                if(this.txtUsuario.Text == "emp" && this.txtContra.Text == "emp")
                {
                    frmMenuEmp frm = new frmMenuEmp();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
