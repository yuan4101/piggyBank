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
        protected clsUsuario atrUsuario;
        #endregion
        #endregion
        #region Operaciones
        #region Constructor
        public clsMoneda() { }
        public clsMoneda(clsUsuario prmOwnerIDO, string prmIDO, string prmDivisa,int prmDenominacion, int prmAño)
        {
            atrUsuario = prmOwnerIDO;
            atrIDO = prmIDO;
            atrDivisa = prmDivisa;
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
        public override string ToString()
        {
            string varString = "";
            varString = varString + "Identificador: " + atrIDO + "\n";
            varString = varString + "Denominacion: " + atrDenominacion + "\n";
            varString = varString + "Divisa: " + atrDivisa + "\n";
            varString = varString + "Año: " + atrAño + "\n";
            return varString;
        }
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
