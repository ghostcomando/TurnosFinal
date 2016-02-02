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
    public class DatTurnos : DatConexion
    {
        public DatTurnos()
        {
        }
        public DataSet SeleccionTurno()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[SeleccionTurno]";
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
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

        public DataSet ListadoTurnos()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListadoTurnosAll]";
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
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

        public int AgregarTurno(EntTurnos ObjEntTurno)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("AgregarTurno", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Turno", ObjEntTurno.Turno);
            cmd.Parameters.AddWithValue("@Ventanilla", ObjEntTurno.Ventanilla);
            cmd.Parameters.AddWithValue("@FechaHora", ObjEntTurno.FechaHora);
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
