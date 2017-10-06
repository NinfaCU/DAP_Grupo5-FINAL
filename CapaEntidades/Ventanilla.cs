using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ventanilla
    {
        private int Ventanilla_Numero;
        private string Ventanilla_Ubicacion;
        private string Ventanilla_TipAtencion;

        public int Ventanilla_Numero1
        {
            get
            {
                return Ventanilla_Numero;
            }

            set
            {
                Ventanilla_Numero = value;
            }
        }

        public string Ventanilla_Ubicacion1
        {
            get
            {
                return Ventanilla_Ubicacion;
            }

            set
            {
                Ventanilla_Ubicacion = value;
            }
        }

        public string Ventanilla_TipAtencion1
        {
            get
            {
                return Ventanilla_TipAtencion;
            }

            set
            {
                Ventanilla_TipAtencion = value;
            }
        }
    }
}
