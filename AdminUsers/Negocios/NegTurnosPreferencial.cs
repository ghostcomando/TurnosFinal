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
    public class NegTurnosPreferencial
    {
        DatTurnosPreferencial ObjNegTurnosPreferencial = new DatTurnosPreferencial();
        public DataSet SeleccionTurnoPreferencial()
        {
            return ObjNegTurnosPreferencial.SeleccionTurnoPreferencial();
        }

        public DataSet ListadoTurnosPreferencial()
        {
            return ObjNegTurnosPreferencial.ListadoTurnosPreferencial();
        }

        public int AgregarTurnoPreferencial(EntTurnosPreferencial ObjEntTurnoPreferencial)
        {
            return ObjNegTurnosPreferencial.AgregarTurnoPreferencial(ObjEntTurnoPreferencial);
        }
    }

}
