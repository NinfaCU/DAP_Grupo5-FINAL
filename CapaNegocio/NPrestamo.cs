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
    public class NPrestamo
    {
        private Prestamo oP = new Prestamo();
        private DPrestamo oDP = new DPrestamo();

        public string insertarPrestamo(int clientecodigo, int empleadocodigo, DateTime fecha, DateTime hora, double monto, int nrocuotas, double montointeres, bool cancelado)
        {
            oP.Cliente_Codigo1 = clientecodigo;
            oP.Empleado_Codigo1 = empleadocodigo;
            oP.Prestamo_Fecha1 = fecha;
            oP.Prestamo_Hora1 = hora;
            oP.Prestamo_Monto1 = monto;
            oP.Prestamo_NroCuotas1 = nrocuotas;
            oP.Prestamo_MontoInteres1 = montointeres;
            oP.Prestamo_Cancelado1 = cancelado;
            return oDP.insertar(oP);
        }

        public System.Data.DataTable buscarPrestamo_Codigo(int codigo)
        {
            return oDP.buscarxCodigo(codigo);
        }

        public DataTable buscarPrestamo_All()
        {
            return oDP.buscarTodos();
        }
    }
}
