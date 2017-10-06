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
    public class DVentanilla
    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataAdapter da;
        private DataTable dt;

        public DVentanilla()
        {
            con = new SqlConnection(Conexion.leerConexion());
        }

        public string insertar(Ventanilla oV)
        {
            try
            {
                comm = new SqlCommand("spInsertaVentanilla", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Ubicacion", oV.Ventanilla_Ubicacion1);
                comm.Parameters.AddWithValue("@TipoAtencion", oV.Ventanilla_TipAtencion1);

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

        public string modificar(Ventanilla oV)
        {
            try
            {
                comm = new SqlCommand("spModificaVentanilla", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@NumeroVentanilla", oV.Ventanilla_Numero1);
                comm.Parameters.AddWithValue("@Ubicacion", oV.Ventanilla_Ubicacion1);
                comm.Parameters.AddWithValue("@TipoAtencion", oV.Ventanilla_TipAtencion1);

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

        public string eliminar(int cod)
        {
            try
            {
                comm = new SqlCommand("spEliminaVentanilla", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@NumeroVentanilla", cod);

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
            dt = new DataTable("Ventanilla");
            da = new SqlDataAdapter("spConsultaUnaVentanilla", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@NumeroVentanilla", cod);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarTodos()
        {
            dt = new DataTable("Ventanilla");
            da = new SqlDataAdapter("spConsultaTodasVentanilla", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarSinEmpleado()
        {
            dt = new DataTable("VentanillaEmpleado");
            da = new SqlDataAdapter("sp_BuscarVentanillaSinEmpleado", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
    }
}
