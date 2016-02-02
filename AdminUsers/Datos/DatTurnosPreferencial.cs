using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DatTurnosPreferencial: DatConexion
    {
        public DatTurnosPreferencial()
        {
        }

        public DataSet SeleccionTurnoPreferencial()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[SeleccionTurnoPreferencial]";
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch(Exception e)
            {
                throw new Exception("no hay turnos", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet ListadoTurnosPreferencial()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListadoTurnoPreferencial]";
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch(Exception e)
            {
                throw new Exception("no es posible listar los turnos", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

        public int AgregarTurnoPreferencial(EntTurnosPreferencial ObjEntTurnoPreferencial)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("AgregarTurnoPreferencial", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Turno", ObjEntTurnoPreferencial.Turno);
            cmd.Parameters.AddWithValue("@Ventanilla", ObjEntTurnoPreferencial.Ventanilla);
            cmd.Parameters.AddWithValue("@FechaHora", ObjEntTurnoPreferencial.FechaHora);
            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de agregar el turno", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return Resultado;
        }
        
    }
}
