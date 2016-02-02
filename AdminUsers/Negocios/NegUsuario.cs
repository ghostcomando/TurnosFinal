using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocios
{
    public class NegUsuario
    {
        DatUsuario ObjNegUsuario = new DatUsuario();

        public int ConsultaUsuario(String Accion, EntUsuarios ObjEntUsuario)
        {
            return ObjNegUsuario.ConsultaUsuario(Accion, ObjEntUsuario);
        }

        public DataSet ListadoUsuario()
        {
            return ObjNegUsuario.ListadoUsuario();
        }

        public DataSet SeleccionUsuario(string Cedula)
        {
            return ObjNegUsuario.SeleccionUsuario(Cedula);
        }

        public DataSet LoginUsuario(string Usuario, string Contraseña)
        {
            return ObjNegUsuario.LoginUsuario(Usuario, Contraseña);
        }
    }

    public class NegTipoUsario
    {
        DatTipoUsuario ObjNegTipoUsuario = new DatTipoUsuario();
        public int ConsultaTipoUsuario(string Accion, EntTipoUsuarios ObjEntTipoUsuarios)
        {
            return ObjNegTipoUsuario.ConsultaTipoUsuario(Accion, ObjEntTipoUsuarios);
        }

        public DataTable ListadoTipoUsuario()
        {
            return ObjNegTipoUsuario.ListadoTipoUsuario();
        }

        public DataTable SeleccionTipoUsuario(int IdTipoUsuario)
        {
            return ObjNegTipoUsuario.SeleccionTipoUsuario(IdTipoUsuario);
        }
     }
}
