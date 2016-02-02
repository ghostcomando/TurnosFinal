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
    public class DatUsuario : DatConexion
    {
        public DatUsuario()
        {
        }

        public int ConsultaUsuario(String Accion, EntUsuarios ObjEntUsuario)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("ConsultaUsuario", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", Accion);
            cmd.Parameters.AddWithValue("@Cedula", ObjEntUsuario.Cedula);
            cmd.Parameters.AddWithValue("@PrimerNombre", ObjEntUsuario.PrimerNombre);
            cmd.Parameters.AddWithValue("@SegundoNombre", ObjEntUsuario.SegundoNombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", ObjEntUsuario.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", ObjEntUsuario.SegundoApellido);
            cmd.Parameters.AddWithValue("@Usuario", ObjEntUsuario.LoginUsuario);
            cmd.Parameters.AddWithValue("@TipoUsuario", ObjEntUsuario.TipoUsuario);
            cmd.Parameters.AddWithValue("@Contraseña", ObjEntUsuario.Contraseña);
            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de agregar, eliminar o modicar usuario", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return Resultado;
        }

        public DataSet ListadoUsuario()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListadoUsuario]";
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("no es posible listar los usuarios", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet SeleccionUsuario(string Cedula)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[SeleccionUsuario]";
                cmd.Parameters.AddWithValue("@Cedula", Cedula);
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("error en cedula", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet LoginUsuario(string Usuario, string Contraseña)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[LoginUsuario]";
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@COntraseña", Contraseña);
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("error en usuario o contraseña", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }
    }

    public class DatTipoUsuario : DatConexion
    {
        public int ConsultaTipoUsuario(string Accion, EntTipoUsuarios ObjEntTipoUsuarios)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", Accion);
            cmd.Parameters.AddWithValue("@IdTipoUsuario", ObjEntTipoUsuarios.IdTipoUsuario);
            cmd.Parameters.AddWithValue("@TipoUsuario", ObjEntTipoUsuarios.TipoUsuario);

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new Exception("No es posible agregar, eliminar o modificar un tipo de usuario", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return Resultado;
        }

        public DataTable ListadoTipoUsuario()
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListadoTipoUsuario]";
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception("no es posible listar los tipos de usuarios", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }

        public DataTable SeleccionTipoUsuario(int IdTipoUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[SeleccionTipoUsuario]";
                cmd.Parameters.AddWithValue("@IdTipoUsuario", IdTipoUsuario);

                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception("error en la seleccion del tipo de usuario", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return dt;
        }
    }
}
