using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class EntUsuarios
    {
        #region Atributos
        private string _Cedula;
        private string _PrimerNombre;
        private string _SegundoNombre;
        private string _PrimerApellido;
        private string _SegundoApellido;
        private string _Usuario;
        private string _TipoUsuario;
        private string _Contraseña;

        
        #endregion

        #region Constructores
        public EntUsuarios()
        {
            _Cedula = string.Empty;
            _PrimerNombre = string.Empty;
            _SegundoNombre = string.Empty;
            _PrimerApellido = string.Empty;
            _SegundoApellido = string.Empty;
            _Usuario = string.Empty;
            TipoUsuario = string.Empty;
            _Contraseña = string.Empty;

        }
        #endregion

        #region Encapsulamiento
        public string Cedula
        {
            get
            {
                return _Cedula;
            }

            set
            {
                _Cedula = value;
            }
        }

        public string PrimerNombre
        {
            get
            {
                return _PrimerNombre;
            }

            set
            {
                _PrimerNombre = value;
            }
        }

        public string SegundoNombre
        {
            get
            {
                return _SegundoNombre;
            }

            set
            {
                _SegundoNombre = value;
            }
        }

        public string PrimerApellido
        {
            get
            {
                return _PrimerApellido;
            }

            set
            {
                _PrimerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return _SegundoApellido;
            }

            set
            {
                _SegundoApellido = value;
            }
        }


        public string LoginUsuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }


        public string Contraseña
        {
            get
            {
                return _Contraseña;
            }

            set
            {
                _Contraseña = value;
            }
        }

        public string TipoUsuario
        {
            get
            {
                return _TipoUsuario;
            }

            set
            {
                _TipoUsuario = value;
            }
        }

        #endregion

    }

    public class EntTipoUsuarios
    {
        #region Atributos
        private int _IdTipoUsuario;
        private string _TipoUsuario;
        #endregion

        #region Constructores
        public EntTipoUsuarios()
        {
            _IdTipoUsuario = 0;
            _TipoUsuario = string.Empty;
        }

       
    #endregion

    #region Encapsulamiento
    public int IdTipoUsuario
    {
        get
        {
            return _IdTipoUsuario;
        }

        set
        {
            _IdTipoUsuario = value;
        }

        
    }

        public string TipoUsuario
        {
            get
            {
                return _TipoUsuario;
            }

            set
            {
                _TipoUsuario = value;
            }
        }
    }
    #endregion
}
