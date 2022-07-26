using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appAlcancia.Servicios;

namespace appAlcancia.Dominio
{
    public class clsMoneda : IComparable
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
            
            if (clsParametrizador.esValidoAño(prmAño))
                atrAño = prmAño;
            else
                throw new FormatException();

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
            if (clsParametrizador.esValidoRangoDenominacion(prmValor) && atrAlcancia == null)
            {
                atrDenominacion = prmValor;
                return true;
            }
            return false;
        }
        public bool ponerAño(int prmValor)
        {
            if (clsParametrizador.esValidoAño(prmValor))
            {
                atrAño = prmValor;
                return true;
            }
            return false;
        }
        public bool ponerDivisa(string prmDivisa)
        {
            if (atrAlcancia == null)
            {
                atrDivisa = prmDivisa;
                return true;
            }
            return false;
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
        #region Comparadores
        public int CompareTo(object obj)
        {
            clsMoneda varObjeto = (clsMoneda)Convert.ChangeType(obj, typeof(clsMoneda));
            if (atrIDO == varObjeto.atrIDO && atrDivisa == varObjeto.atrDivisa && atrDenominacion == varObjeto.atrDenominacion && atrAño == varObjeto.atrAño)
                return 0;
            if (atrDenominacion > varObjeto.atrDenominacion)
                return 1;
            return -1;
        }
        #endregion
        #endregion
    }
}
