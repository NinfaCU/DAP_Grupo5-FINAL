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
    public class NEmpleado
    {   
        private Empleado oE = new Empleado();
        private DEmpleado oDE = new DEmpleado();

        public string insertarEmpleado(int numventanilla, string nombre, string apellido, string direccion, string dni, string categoria)
        {
            oE.Ventanilla_Codigo1 = numventanilla;
            oE.Empleado_Nombre1 = nombre;
            oE.Empleado_Apellido1 = apellido;
            oE.Empleado_Direccion1 = direccion;
            oE.Empleado_Dni1 = dni;
            oE.Empleado_Categoria1 = categoria;
            return oDE.insertar(oE);
        }

        public string actualizarEmpleado(int numempleado, int numventanilla, string nombre, string apellido, string direccion, string dni, string categoria)
        {
            oE.Empleado_Codigo1 = numempleado;
            oE.Ventanilla_Codigo1 = numventanilla;
            oE.Empleado_Nombre1 = nombre;
            oE.Empleado_Apellido1 = apellido;
            oE.Empleado_Direccion1 = direccion;
            oE.Empleado_Dni1 = dni;
            oE.Empleado_Categoria1 = categoria;
            return oDE.modificar(oE);
        }

        public string eliminarEmpleado(int codigo)
        {
            return oDE.eliminar(codigo);
        }

        public System.Data.DataTable buscarEmpleado_Codigo(int codigo)
        {
            return oDE.buscarxCodigo(codigo);
        }

        public DataTable buscarEmpleado_All()
        {
            return oDE.buscarEmpleado_Todos();
        }
    }
}
