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
    public class DPrestamo
    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataAdapter da;
        private DataTable dt;

        public DPrestamo()
        {
            con = new SqlConnection(Conexion.leerConexion());
        }

        public string insertar(Prestamo oP)
        {
            try
            {
                comm = new SqlCommand("spInsertaPrestamo", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@CodigoCliente", oP.Cliente_Codigo1);
                comm.Parameters.AddWithValue("@CodigoEmpleado", oP.Empleado_Codigo1);
                comm.Parameters.AddWithValue("@FechaPrestamo", oP.Prestamo_Fecha1);
                comm.Parameters.AddWithValue("@Hora", oP.Prestamo_Hora1);
                comm.Parameters.AddWithValue("@MontoPrestamo", oP.Prestamo_Monto1);
                comm.Parameters.AddWithValue("@NroCuotas", oP.Prestamo_NroCuotas1);
                comm.Parameters.AddWithValue("@MontoInteres", oP.Prestamo_MontoInteres1);
                comm.Parameters.AddWithValue("@Cancelado", oP.Prestamo_Cancelado1);

                comm.Connection.Open();
                comm.ExecuteNonQuery();

                
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable buscarxCodigo(int cod)
        {
            dt = new DataTable("Prestamo");
            da = new SqlDataAdapter("spConsultaUnPrestamo", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CodigoPrestamo", cod);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarTodos()
        {
            dt = new DataTable("Prestamo");
            da = new SqlDataAdapter("spConsultaTodosPrestamo", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
    }
}
