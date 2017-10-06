using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cuota
    {
        private int Cuota_Codigo;
        private int Prestamo_Codigo;
        private DateTime Cuota_Fecha;
        private double Cuota_MontoCap;
        private double Cuota_InteresMensual;
        private double Cuota_Itf;
        private double Cuota_ImpTotalCuota;
        private bool Cuota_Cancelado;

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

        public DateTime Cuota_Fecha1
        {
            get
            {
                return Cuota_Fecha;
            }

            set
            {
                Cuota_Fecha = value;
            }
        }

        public double Cuota_MontoCap1
        {
            get
            {
                return Cuota_MontoCap;
            }

            set
            {
                Cuota_MontoCap = value;
            }
        }

        public double Cuota_InteresMensual1
        {
            get
            {
                return Cuota_InteresMensual;
            }

            set
            {
                Cuota_InteresMensual = value;
            }
        }

        public double Cuota_Itf1
        {
            get
            {
                return Cuota_Itf;
            }

            set
            {
                Cuota_Itf = value;
            }
        }

        public double Cuota_ImpTotalCuota1
        {
            get
            {
                return Cuota_ImpTotalCuota;
            }

            set
            {
                Cuota_ImpTotalCuota = value;
            }
        }

        public bool Cuota_Cancelado1
        {
            get
            {
                return Cuota_Cancelado;
            }

            set
            {
                Cuota_Cancelado = value;
            }
        }
    }
}
