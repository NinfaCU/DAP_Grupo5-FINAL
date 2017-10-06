using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class NPago
    {
        private Pago oP = new Pago();
        private DPago oDP = new DPago();

        public string insertarPago(int CodigoCuota, int CodigoEmpleado, int CodigoCliente, DateTime FechaPago, DateTime HoraPago, double ImportePago, double ImporteMora, double ImporteAmortizacion)
        {
            oP.Cuota_Codigo1 = CodigoCuota;
            oP.Empleado_Codigo1 = CodigoEmpleado;
            oP.Cliente_Codigo1 = CodigoCliente;
            oP.Pago_Fecha1 = FechaPago;
            oP.Pago_Hora1 = HoraPago;
            oP.Pago_ImpPago1 = ImportePago;
            oP.Pago_ImpMora1 = ImporteMora;
            oP.Pago_ImpAmortizacion1 = ImporteAmortizacion;
            return oDP.insertar(oP);
        }

        public System.Data.DataTable buscarPago_Codigo(int codigo)
        {
            return oDP.buscarxCodigo(codigo);
        }

        public DataTable buscarPago_All()
        {
            return oDP.buscarTodos();
        }
    }
}