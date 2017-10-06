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
    public class NVentanilla
    {
        private Ventanilla oV = new Ventanilla();
        private DVentanilla oDV = new DVentanilla();
        public string insertarVentanilla(string ubicacion, string tipo)
        {
            oV.Ventanilla_Ubicacion1 = ubicacion;
            oV.Ventanilla_TipAtencion1 = tipo;
            return oDV.insertar(oV);
        }

        public string actualizarVentanilla(int codigo, string ubicacion, string tipo)
        {
            oV.Ventanilla_Numero1 = codigo;
            oV.Ventanilla_Ubicacion1 = ubicacion;
            oV.Ventanilla_TipAtencion1 = tipo;
            return oDV.modificar(oV);
        }

        public string eliminarVentanilla(int codigo)
        {
            return oDV.eliminar(codigo);
        }

        public System.Data.DataTable buscarVentanilla_Codigo(int codigo)
        {
            return oDV.buscarxCodigo(codigo);
        }

        public DataTable buscarVentanilla_All()
        {
            return oDV.buscarTodos();
        }

        public DataTable buscarVentanillaSinEmpleado()
        {
            return oDV.buscarSinEmpleado();
        }
    }
}
