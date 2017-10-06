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
    public class NCliente
    {
        private Cliente oC = new Cliente();
        private DCliente oDC = new DCliente();

        public string insertarCliente(string nombre, string apellido, string direccion, string dni, string ruc, DateTime fecingreso, double saldo, bool activo)
        {
            oC.Cliente_Nombre1 = nombre;
            oC.Cliente_Apellido1 = apellido;
            oC.Cliente_Direccion1 = direccion;
            oC.Cliente_Dni1 = dni;
            oC.Cliente_Ruc1 = ruc;
            oC.Cliente_Fec_Ingreso1 = fecingreso;
            oC.Cliente_Saldo1 = saldo;
            oC.Cliente_Activo1 = activo;
            return oDC.insertar(oC);
        }

        public string actualizarCliente(int cod, string nombre, string apellido, string direccion, string dni, string ruc, DateTime fecingreso, double saldo, bool activo)
        {
            oC.Cliente_Codigo1 = cod;
            oC.Cliente_Nombre1 = nombre;
            oC.Cliente_Apellido1 = apellido;
            oC.Cliente_Direccion1 = direccion;
            oC.Cliente_Dni1 = dni;
            oC.Cliente_Ruc1 = ruc;
            oC.Cliente_Fec_Ingreso1 = fecingreso;
            oC.Cliente_Saldo1 = saldo;
            oC.Cliente_Activo1 = activo;
            return oDC.modificar(oC);
        }

        public System.Data.DataTable buscarCliente_Codigo(int codigo)
        {
            return oDC.buscarxCodigo(codigo);
        }

        public DataTable buscarCliente_All()
        {
            return oDC.buscarTodos();
        }

        public DataTable buscarClienteSinPrestamo()
        {
            return oDC.buscarSinPrestamo();
        }

        public DataTable buscarClienteConPrestamo(int codigo)
        {
            return oDC.buscarConPrestamo(codigo);
        }

        public DataTable BuscarTodosConPrestamo()
        {
            return oDC.buscarTodosConPrestamo();
        }
    }
}
