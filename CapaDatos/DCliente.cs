using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class DCliente
    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataAdapter da;
        private DataTable dt;

        public DCliente()
        {
            con = new SqlConnection(Conexion.leerConexion());
        }

        public string insertar(Cliente oC)
        {
            try
            {
                comm = new SqlCommand("spInsertaCliente", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Nombres", oC.Cliente_Nombre1);
                comm.Parameters.AddWithValue("@Apellidos", oC.Cliente_Apellido1);
                comm.Parameters.AddWithValue("@Direccion", oC.Cliente_Direccion1);
                comm.Parameters.AddWithValue("@DNI", oC.Cliente_Dni1);
                comm.Parameters.AddWithValue("@RUC", oC.Cliente_Ruc1);
                comm.Parameters.AddWithValue("@FechaIngreso", oC.Cliente_Fec_Ingreso1);
                comm.Parameters.AddWithValue("@SaldoCuenta", oC.Cliente_Saldo1);
                comm.Parameters.AddWithValue("@Activo", oC.Cliente_Activo1);

                comm.Connection.Open();
                comm.ExecuteNonQuery();

                comm.Connection.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string modificar(Cliente oC)
        {
            try
            {
                comm = new SqlCommand("spModificaCliente", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@CodigoCliente", oC.Cliente_Codigo1);
                comm.Parameters.AddWithValue("@Nombres", oC.Cliente_Nombre1);
                comm.Parameters.AddWithValue("@Apellidos", oC.Cliente_Apellido1);
                comm.Parameters.AddWithValue("@Direccion", oC.Cliente_Direccion1);
                comm.Parameters.AddWithValue("@DNI", oC.Cliente_Dni1);
                comm.Parameters.AddWithValue("@RUC", oC.Cliente_Ruc1);
                comm.Parameters.AddWithValue("@FechaIngreso", oC.Cliente_Fec_Ingreso1);
                comm.Parameters.AddWithValue("@SaldoCuenta", oC.Cliente_Saldo1);
                comm.Parameters.AddWithValue("@Activo", oC.Cliente_Activo1);

                comm.Connection.Open();
                comm.ExecuteNonQuery();

                comm.Connection.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable buscarxCodigo(int cod)
        {
            dt = new DataTable("Cliente");
            da = new SqlDataAdapter("spConsultaUnCliente", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CodigoCliente", cod);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarTodos()
        {
            dt = new DataTable("Cliente");
            da = new SqlDataAdapter("spConsultaTodosCliente", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarSinPrestamo()
        {
            dt = new DataTable("ClienteSinPrestamo");
            da = new SqlDataAdapter("sp_BuscarClienteSinPrestamo", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarConPrestamo(int cod)
        {
            dt = new DataTable("ClienteConPrestamo");
            da = new SqlDataAdapter("sp_BuscarClienteConPrestamo", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CodigoCliente", cod);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarTodosConPrestamo()
        {
            dt = new DataTable("ClienteTodoPrestamo");
            da = new SqlDataAdapter("sp_BuscarTodosClienteConPrestamo", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
    }
}
