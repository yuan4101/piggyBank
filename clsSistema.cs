using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsSistema
    {
        #region Atributos
        #region Singleton
        private static clsSistema atrInstancia;
        #endregion
        #region Asociativos
        private List<clsMoneda> atrMonedas;
        private List<clsBillete> atrBilletes;
        #endregion
        #endregion
        #region Operaciones
        #region Singleton
        public static clsSistema darInstancia()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDS
        #region Registrador
        public bool registrarAlcancia(string prmDivisa, int prmCapMonedas, int prmCapBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            throw new NotImplementedException();
        }
        public bool registrarMoneda(string prmIDO, int prmDenominacion, int prmAño)
        {
            throw new NotImplementedException();
        }
        public bool registrarBillete(string prmSerial, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Actualizador
        public bool actualizarAlcancia(string prmDivisa, int prmCapMonedas, int prmCapBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            throw new NotImplementedException();
        }
        public bool actualizarMoneda(string prmIDO, int prmDenominacion, int prmAño)
        {
            throw new NotImplementedException();
        }
        public bool actualizarBillete(string prmSerial, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Eliminador
        public bool eliminarAlcancia()
        {
            throw new NotImplementedException();
        }
        public bool eliminarMoneda(string prmIDO)
        {
            throw new NotImplementedException();
        }
        public bool eliminarBillete(string prmSerial)
        {
            throw new NotImplementedException();
        }
        #endregion
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