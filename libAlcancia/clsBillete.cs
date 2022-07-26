using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appAlcancia.Servicios;

namespace appAlcancia.Dominio
{
    public class clsBillete : clsMoneda, IComparable
    {
        #region Atributos
        private int atrMes;
        private int atrDia;
        #endregion
        #region Operaciones
        #region Constructor
        public clsBillete(string prmIDO, string prmDivisa, int prmDenominacion, int prmAño, int prmMes, int prmDia) 
            : base(prmIDO, prmDivisa, prmDenominacion, prmAño)
        {
            if(clsParametrizador.esValidoMes(prmMes, 1))
                atrMes = prmMes;
            if(clsParametrizador.esValidoDia(prmDia, atrMes))
                atrDia = prmDia;
        }
        public clsBillete() {
        }
        #endregion
        #region Accesores
        public string darSerial()
        {
            return atrIDO;
        }
        public int darMes()
        {
            return atrMes;
        }
        public int darDia()
        {
            return atrDia;
        }
        #endregion
        #region Mutadores
        public bool ponerMes(int prmValor)
        {
            if (clsParametrizador.esValidoMes(prmValor, atrDia))
            {
                atrMes = prmValor;
                return true;
            }
            return false;
        }
        public bool ponerDia(int prmValor)
        {
            if (clsParametrizador.esValidoDia(prmValor, atrMes))
            {
                atrDia = prmValor;
                return true;
            }
            return false;
        }
        #endregion
        #region Testing
        public new void generar()
        {
            atrDia = 4;
            atrMes = 11;
            atrAño = 1990;
            atrIDO = "123";
            atrDenominacion = 1000;
            atrDivisa = "COP";
            atrAlcancia = new clsAlcancia();
        }
        public new int CompareTo(object prmBillete)
        {
            clsBillete varObjeto = (clsBillete)Convert.ChangeType(prmBillete, typeof(clsBillete));
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
