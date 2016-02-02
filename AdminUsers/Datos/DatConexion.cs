using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
   public class DatConexion
    {
        public SqlConnection Conexion;

        public DatConexion()
        {
            Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["TurnosconnectionString"].ConnectionString);
        }

        public void AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed)
                {
                    Conexion.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al abrir la conexion con la base de datos", e);
            }

        }

        public void CerrarConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al cerrar la conexion con la base de datos", e);
            }

        }

    }
}
