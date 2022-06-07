using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsBillete : clsMoneda
    {
        #region Atributos
        private int atrMes;
        private int atrDia;
        #endregion
        #region Operaciones
        #region Constructor
        public clsBillete(string prmIDO, string prmDivisa, int prmDenominacion, int prmAño, int prmMes, int prmDia) : base(prmIDO, prmDivisa, prmDenominacion, prmAño)
        {
            atrMes = prmMes;
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
            if (clsParametrizador.esValidoMes(prmValor))
            {
                atrMes = prmValor;
                return true;
            }
            return false;
        }
        public bool ponerDia(int prmValor)
        {
            if (clsParametrizador.esValidoDia(prmValor))
            {
                atrDia = prmValor;
                return true;
            }
            return false;
        }
        public bool ponerSerial(string prmValor)
        {
            atrIDO = prmValor;
            return true;
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
        #endregion
        #endregion
    }
}
