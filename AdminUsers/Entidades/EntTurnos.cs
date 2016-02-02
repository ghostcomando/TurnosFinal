using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntTurnos
    {
        #region Atributos
        private string _Turno;
        private string _Ventanilla;
        private DateTime _FechaHora;
        #endregion

        #region Constructores
        public EntTurnos()
            {
            _Turno = string.Empty;
            _Ventanilla = string.Empty;
            FechaHora = DateTime.Now;
            }
        #endregion

        #region Encapsulamiento
        public string Turno
        {
            get
            {
                return _Turno;
            }

            set
            {
                _Turno = value;
            }
        }

        public string Ventanilla
        {
            get
            {
                return _Ventanilla;
            }

            set
            {
                _Ventanilla = value;
            }
        }

        public DateTime FechaHora
        {
            get
            {
                return _FechaHora;
            }

            set
            {
                _FechaHora = value;
            }
        }
        #endregion
    }
}
