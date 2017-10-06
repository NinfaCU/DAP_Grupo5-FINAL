    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        private int Cliente_Codigo;
        private string Cliente_Nombre;
        private string Cliente_Apellido;
        private string Cliente_Direccion;
        private string Cliente_Dni;
        private string Cliente_Ruc;
        private DateTime Cliente_Fec_Ingreso;
        private double Cliente_Saldo;
        private bool Cliente_Activo;

        public int Cliente_Codigo1
        {
            get
            {
                return Cliente_Codigo;
            }

            set
            {
                Cliente_Codigo = value;
            }
        }

        public string Cliente_Nombre1
        {
            get
            {
                return Cliente_Nombre;
            }

            set
            {
                Cliente_Nombre = value;
            }
        }

        public string Cliente_Apellido1
        {
            get
            {
                return Cliente_Apellido;
            }

            set
            {
                Cliente_Apellido = value;
            }
        }

        public string Cliente_Direccion1
        {
            get
            {
                return Cliente_Direccion;
            }

            set
            {
                Cliente_Direccion = value;
            }
        }

        public DateTime Cliente_Fec_Ingreso1
        {
            get
            {
                return Cliente_Fec_Ingreso;
            }

            set
            {
                Cliente_Fec_Ingreso = value;
            }
        }

        public double Cliente_Saldo1
        {
            get
            {
                return Cliente_Saldo;
            }

            set
            {
                Cliente_Saldo = value;
            }
        }

        public bool Cliente_Activo1
        {
            get
            {
                return Cliente_Activo;
            }

            set
            {
                Cliente_Activo = value;
            }
        }

        public string Cliente_Dni1
        {
            get
            {
                return Cliente_Dni;
            }

            set
            {
                Cliente_Dni = value;
            }
        }

        public string Cliente_Ruc1
        {
            get
            {
                return Cliente_Ruc;
            }

            set
            {
                Cliente_Ruc = value;
            }
        }
    }
}
