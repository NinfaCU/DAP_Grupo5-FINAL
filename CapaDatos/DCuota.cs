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
    public class DCuota
    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataAdapter da;
        private DataTable dt;

        public DCuota()
        {
            con = new SqlConnection(Conexion.leerConexion());
        }

        public string insertar(Cuota oC)
        {
            try
            {
                comm = new SqlCommand("spInsertaCuota", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@CodigoPrestamo", oC.Prestamo_Codigo1);
                comm.Parameters.AddWithValue("@FechaCuota", oC.Cuota_Fecha1);
                comm.Parameters.AddWithValue("@MontoCapital", oC.Cuota_MontoCap1);
                comm.Parameters.AddWithValue("@InteresMensual", oC.Cuota_InteresMensual1);
                comm.Parameters.AddWithValue("@ITF", oC.Cuota_Itf1);
                comm.Parameters.AddWithValue("@ImporteTotalCuota", oC.Cuota_ImpTotalCuota1);
                comm.Parameters.AddWithValue("@Cancelado", oC.Cuota_Cancelado1);

                comm.Connection.Open();
                comm.ExecuteNonQuery();

                if (comm.Connection.State == ConnectionState.Open)
                {
                    comm.Connection.Close();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable buscarxCodigo(int cod)
        {
            dt = new DataTable("Cuota");
            da = new SqlDataAdapter("spConsultaUnaCuota", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CodigoCliente", cod);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarTodos()
        {
            dt = new DataTable("Cuota");
            da = new SqlDataAdapter("spConsultaTodasCuota", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public string modificar(Cuota oC)
        {
            try
            {
                comm = new SqlCommand("Modificar_Cuota", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@CodigoCuota", oC.Cuota_Codigo1);
                comm.Parameters.AddWithValue("@Cancelado", oC.Cuota_Cancelado1);

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
    }
}
