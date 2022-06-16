using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcanciaX.Dominio
{
    public class clsUsuario
    {
        #region Atributos
        #region Propios
        protected string atrIDO;
        protected string atrNombre;
        protected string atrUsuario;
        protected string atrConstraseña;
        protected List<clsMoneda> atrMonedas = new List<clsMoneda>();
        protected List<clsBillete> atrBilletes = new List<clsBillete>();
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
        public clsUsuario() { }
        #endregion
        #region Accesores
        public string darIDO()
        {
            return atrIDO;
        }
        public string darNombre()
        {
            return atrNombre;
        }
        #endregion
        #region Mutadores
        public bool agregarMoneda(clsMoneda prmMoneda)
        {
            atrMonedas.Add(prmMoneda);
            return true;
        }
        public bool agregarBillete(clsBillete prmBillete)
        {
            atrBilletes.Add(prmBillete);
            return true;
        }
        #endregion
        #region Validacion
        public bool validarCredenciales(string prmUsuario, string prmContraseña)
        {
            if (prmUsuario == atrUsuario && prmContraseña == atrConstraseña)
                return true;
            return false;
        }
        #endregion
        #region 

        #endregion
        #endregion
    }
}
