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
    public class DPago
    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataAdapter da;
        private DataTable dt;

        public DPago()
        {
            con = new SqlConnection(Conexion.leerConexion());
        }

        public string insertar(Pago oP)
        {
            try
            {
                comm = new SqlCommand("spInsertaPago", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@CodigoCuota", oP.Cuota_Codigo1);
                comm.Parameters.AddWithValue("@CodigoEmpleado", oP.Empleado_Codigo1);
                comm.Parameters.AddWithValue("@CodigoCliente", oP.Cliente_Codigo1);
                comm.Parameters.AddWithValue("@FechaPago", oP.Pago_Fecha1);
                comm.Parameters.AddWithValue("@HoraPago", oP.Pago_Hora1);
                comm.Parameters.AddWithValue("@ImportePago", oP.Pago_ImpPago1);
                comm.Parameters.AddWithValue("@ImporteMora", oP.Pago_ImpMora1);
                comm.Parameters.AddWithValue("@ImporteAmortizacion", oP.Pago_ImpAmortizacion1);

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
            dt = new DataTable("Pago");
            da = new SqlDataAdapter("spConsultaUnPago", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CodigoCuota", cod);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarTodos()
        {
            dt = new DataTable("Pago");
            da = new SqlDataAdapter("spConsultaTodosPago", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
    }
}

