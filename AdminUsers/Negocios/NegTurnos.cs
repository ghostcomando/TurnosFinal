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
    public class NegTurnos
    {
        DatTurnos ObjNegTurnos = new DatTurnos();
        public DataSet SeleccionTurno()
        {
            return ObjNegTurnos.SeleccionTurno();
        }

        public DataSet ListadoTurnos()
        {
            return ObjNegTurnos.ListadoTurnos();
        }

        public int AgregarTurno(EntTurnos ObjEntTurno)
        {
            return ObjNegTurnos.AgregarTurno(ObjEntTurno);
        }
    }

}
