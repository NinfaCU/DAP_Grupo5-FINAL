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
    public class DEmpleado
    {
        private SqlConnection con;
        private SqlCommand comm;
        private SqlDataAdapter da;
        private DataTable dt;

        public DEmpleado()
        {
            con = new SqlConnection(Conexion.leerConexion());
        }

        public string insertar(Empleado oE)
        {
            try
            {
                {
                    comm = new SqlCommand("spInsertaEmpleado", con);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@NumeroVentanilla", oE.Ventanilla_Codigo1);
                    comm.Parameters.AddWithValue("@Nombres", oE.Empleado_Nombre1);
                    comm.Parameters.AddWithValue("@Apellidos", oE.Empleado_Apellido1);
                    comm.Parameters.AddWithValue("@Direccion", oE.Empleado_Direccion1);
                    comm.Parameters.AddWithValue("@DNI", oE.Empleado_Dni1);
                    comm.Parameters.AddWithValue("@Categoria", oE.Empleado_Categoria1);

                    comm.Connection.Open();
                    comm.ExecuteNonQuery();

                    comm.Connection.Close();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string modificar(Empleado oE)
        {
            try
            {
                comm = new SqlCommand("spModificaEmpleado", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@CodigoEmpleado", oE.Empleado_Codigo1);
                comm.Parameters.AddWithValue("@NumeroVentanilla", oE.Ventanilla_Codigo1);
                comm.Parameters.AddWithValue("@Nombres", oE.Empleado_Nombre1);
                comm.Parameters.AddWithValue("@Apellidos", oE.Empleado_Apellido1);
                comm.Parameters.AddWithValue("@Direccion", oE.Empleado_Direccion1);
                comm.Parameters.AddWithValue("@DNI", oE.Empleado_Dni1);
                comm.Parameters.AddWithValue("@Categoria", oE.Empleado_Categoria1);

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
                comm = new SqlCommand("spEliminaEmpleado", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@CodigoEmpleado", cod);

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
            dt = new DataTable("Empleado");
            da = new SqlDataAdapter("spConsultaUnEmpleado", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CodigoEmpleado", cod);
            da.Fill(dt);
            return dt;
        }

        public DataTable buscarEmpleado_Todos()
        {
            dt = new DataTable("Empleado");
            da = new SqlDataAdapter("spConsultaTodosEmpleado", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
    }
}
