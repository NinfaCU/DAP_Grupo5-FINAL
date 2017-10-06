using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Prestamo
    {
        private int Prestamo_Codigo;
        private int Cliente_Codigo;
        private int Empleado_Codigo;
        private DateTime Prestamo_Fecha;
        private DateTime Prestamo_Hora;
        private double Prestamo_Monto;
        private int Prestamo_NroCuotas;
        private double Prestamo_MontoInteres;
        private bool Prestamo_Cancelado;
        
        public int Prestamo_Codigo1
        {
            get
            {
                return Prestamo_Codigo;
            }

            set
            {
                Prestamo_Codigo = value;
            }
        }

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

        public int Empleado_Codigo1
        {
            get
            {
                return Empleado_Codigo;
            }

            set
            {
                Empleado_Codigo = value;
            }
        }

        public DateTime Prestamo_Fecha1
        {
            get
            {
                return Prestamo_Fecha;
            }

            set
            {
                Prestamo_Fecha = value;
            }
        }

        public double Prestamo_Monto1
        {
            get
            {
                return Prestamo_Monto;
            }

            set
            {
                Prestamo_Monto = value;
            }
        }

        public int Prestamo_NroCuotas1
        {
            get
            {
                return Prestamo_NroCuotas;
            }

            set
            {
                Prestamo_NroCuotas = value;
            }
        }

        public double Prestamo_MontoInteres1
        {
            get
            {
                return Prestamo_MontoInteres;
            }

            set
            {
                Prestamo_MontoInteres = value;
            }
        }

        public DateTime Prestamo_Hora1
        {
            get
            {
                return Prestamo_Hora;
            }

            set
            {
                Prestamo_Hora = value;
            }
        }

        public bool Prestamo_Cancelado1
        {
            get
            {
                return Prestamo_Cancelado;
            }

            set
            {
                Prestamo_Cancelado = value;
            }
        }
    }
}
