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
        protected string atrDivisa;
        #endregion
        #region Asociativos
        protected clsAlcancia atrAlcancia;
        #endregion
        #endregion
        #region Operaciones
        #region Constructor
        public clsMoneda() { }
        public clsMoneda(string prmIDO, string prmDivisa,int prmDenominacion, int prmAño)
        {
            atrIDO = prmIDO;
            atrDenominacion = prmDenominacion;
            atrAño = prmAño;
            atrDivisa = prmDivisa;
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
        public string darDivisa() 
        {
            return atrDivisa;
        }
        public clsAlcancia darAlcancia() 
        {
            return atrAlcancia;
        }
        #endregion
        #region Mutadores
        public bool ponerDenominacion(int prmValor)
        {
            if (clsParametrizador.esValidoRangoDenominacion(prmValor))
            {
                atrDenominacion = prmValor;
                return true;
            }
            return false;
        }
        public bool ponerAño(int prmValor)
        {
            if (clsParametrizador.esValidoAno(prmValor))
            {
                atrAño = prmValor;
                return true;
            }
            return false;
        }
        public bool ponerDivisa(string prmDivisa)
        {
            atrDivisa = prmDivisa;
            return true;
        }
        public bool ponerAlcancia(clsAlcancia prmObjeto) 
        {
            atrAlcancia = prmObjeto;
            return true;
        }
        #endregion
        #region Testing
        public void generar()
        {
            atrIDO = "123";
            atrDenominacion = 1000;
            atrAño = 1993;
            atrDivisa = "COP";
            atrAlcancia = new clsAlcancia();
        }
        #endregion
        #endregion
    }
}
