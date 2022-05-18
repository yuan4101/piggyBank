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
        public clsBillete(string prmIDO, int prmDenominacion, int prmAño, int prmMes, int prmDia) : base(prmIDO, prmDenominacion, prmAño)
        {
            atrMes = prmMes;
            atrDia = prmDia;
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
            atrMes = prmValor;
            return true;
        }
        public bool  ponerDia(int prmValor)
        {
            atrDia = prmValor;
            return true;
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
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
