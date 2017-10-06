using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Pago
    {
        private int Cuota_Codigo;
        private int Empleado_Codigo;
        private int Cliente_Codigo;
        private DateTime Pago_Fecha;
        private DateTime Pago_Hora;
        private double Pago_ImpPago;
        private double Pago_ImpMora;
        private double Pago_ImpAmortizacion;

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

        public int Cuota_Codigo1
        {
            get
            {
                return Cuota_Codigo;
            }

            set
            {
                Cuota_Codigo = value;
            }
        }

        public DateTime Pago_Fecha1
        {
            get
            {
                return Pago_Fecha;
            }

            set
            {
                Pago_Fecha = value;
            }
        }

        public DateTime Pago_Hora1
        {
            get
            {
                return Pago_Hora;
            }

            set
            {
                Pago_Hora = value;
            }
        }

        public double Pago_ImpPago1
        {
            get
            {
                return Pago_ImpPago;
            }

            set
            {
                Pago_ImpPago = value;
            }
        }

        public double Pago_ImpMora1
        {
            get
            {
                return Pago_ImpMora;
            }

            set
            {
                Pago_ImpMora = value;
            }
        }

        public double Pago_ImpAmortizacion1
        {
            get
            {
                return Pago_ImpAmortizacion;
            }

            set
            {
                Pago_ImpAmortizacion = value;
            }
        }
    }
}
