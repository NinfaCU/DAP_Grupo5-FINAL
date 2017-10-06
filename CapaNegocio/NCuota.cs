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
    public class NCuota
    {
        private Cuota oC = new Cuota();
        private DCuota oDC = new DCuota();

        public string insertarCuota(int prestamocodigo, DateTime fecha, double MontoCap, double InteresMensual, double CuotaItf, double totalcuota, bool cancelado)
        {
            oC.Prestamo_Codigo1 = prestamocodigo;
            oC.Cuota_Fecha1 = fecha;
            oC.Cuota_MontoCap1 = MontoCap;
            oC.Cuota_InteresMensual1 = InteresMensual;
            oC.Cuota_Itf1 = CuotaItf;
            oC.Cuota_ImpTotalCuota1 = totalcuota;
            oC.Cuota_Cancelado1 = cancelado;
            return oDC.insertar(oC);
        }

        public string actualizarCuota(int codigocuota, bool cancelado)
        {
            oC.Cuota_Codigo1 = codigocuota;
            oC.Cuota_Cancelado1 = cancelado;
            return oDC.modificar(oC);
        }

        public System.Data.DataTable buscarCuota_Codigo(int codigo)
        {
            return oDC.buscarxCodigo(codigo);
        }

        public DataTable buscarCuota_All()
        {
            return oDC.buscarTodos();
        }
    }
}
