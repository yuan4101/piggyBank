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
        private clsAlcancia atrAlcancia;
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
        #region Transacciones
        public bool consignarMoneda(string prmIDO)
        {
            throw new NotImplementedException();
        }
        public bool consignarBillete(string prmSerial)
        {
            throw new NotImplementedException();
        }
        public bool retirarMoneda(string prmIDO)
        {
            throw new NotImplementedException();
        }
        public bool retirarBillete(string prmSerial)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Testing
        public void generar()
        {
            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda("0", 100, 1992));
            atrMonedas.Add(new clsMoneda("1", 500, 1998));
            atrMonedas.Add(new clsMoneda("5", 200, 1984));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete("ABC123", 1000, 1992, 2, 20));
            atrBilletes.Add(new clsBillete("CDF456", 500, 1992, 2, 20));
            atrBilletes.Add(new clsBillete("ABC789", 100000, 2020, 3, 13));

            atrAlcancia = new clsAlcancia("COP", 10, 12, new List<int> { 100, 500 }, new List<int> { 500, 1000 });

            atrAlcancia.darMonedas().Add(atrMonedas[0]);
            atrAlcancia.darMonedas().Add(atrMonedas[1]);
            atrAlcancia.darBilletes().Add(atrBilletes[0]);
            atrAlcancia.darBilletes().Add(atrBilletes[1]);

            atrAlcancia.calcularEstadoCuenta();
        }
        #endregion
        #endregion
    }
}