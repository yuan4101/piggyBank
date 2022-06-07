using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsUsuario
    {
        #region Atributos
        #region Propios
        protected string atrIDO;
        protected string atrNombre;
        protected string atrUsuario;
        protected string atrConstraseña;
        #endregion
        #endregion
        #region Operaciones
        #region Constructor
        public clsUsuario (string prmIDO, string prmNombre, string prmUsuario, string prmContraseña)
        {
            atrIDO = prmIDO;
            atrNombre = prmNombre;
            atrUsuario = prmUsuario;
            atrConstraseña = prmContraseña;
        }
        #endregion
        #region Accesores

        #endregion
        #region Mutadores

        #endregion
        #region 

        #endregion
        #endregion
    }
}
