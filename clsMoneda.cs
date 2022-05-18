using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsMoneda
    {
        #region Atributos
        #region IDO
        protected string atrIDO;
        #endregion
        #region Propios
        protected int atrDenominacion;
        protected int atrAño;
        #endregion
        #region Asociativos
        protected clsAlcancia atrAlcancia;
        #endregion
        #endregion
        #region Operaciones
        #region Constructor
        public clsMoneda(string prmIDO, int prmDenominacion, int prmAño)
        {
            atrIDO = prmIDO;
            atrDenominacion = prmDenominacion;
            atrAño = prmAño;
        }
        #endregion
        #region Accesores
        public int darDenominacion()
        {
            return atrDenominacion;
        }
        public int darAño()
        {
            return atrAño;
        }
        public string darIDO()
        {
            return atrIDO;
        }
        #endregion
        #region Mutadores
        public bool ponerDenominacion(int prmValor)
        {
            atrDenominacion = prmValor;
            return true;
        }
        public bool ponerAño(int prmValor)
        {
            atrAño = prmValor;
            return true;
        }
        #endregion
        #region Testing
        public void generar()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
