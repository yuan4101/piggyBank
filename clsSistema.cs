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
        private List<clsAlcancia> atrAlcancias;
        private List<clsUsuario> atrUsuarios;
        private List<clsMoneda> atrMonedas;
        private List<clsBillete> atrBilletes;
        #endregion
        #endregion
        #region Operaciones
        #region Singleton
        public static clsSistema darInstancia()
        {
            if (atrInstancia == null) 
                return atrInstancia = new clsSistema();
            return atrInstancia;
        }
        #endregion
        #region Accesores
        public List<clsAlcancia> darAlcancias() 
        {
            return atrAlcancias;
        }
        #endregion
        #region CRUDS
        #region Registrador
        public bool registrarAlcancia(string prmDivisa, int prmCapMonedas, int prmCapBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            atrAlcancias.Add(new clsAlcancia(prmDivisa, prmCapMonedas, prmCapBilletes, prmDenMonedas, prmDenBilletes));
            return true;
        }
        public bool registrarMoneda(string prmOwnerIDO, string prmIDO, string prmDivisa, int prmDenominacion, int prmAño)
        {
            atrMonedas.Add(new clsMoneda(prmOwnerIDO, prmIDO, prmDivisa, prmDenominacion, prmAño));
            return true;
        }
        public bool registrarBillete(string prmOwnerIDO, string prmSerial, string prmDivisa, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            atrBilletes.Add(new clsBillete(prmOwnerIDO, prmSerial, prmDivisa, prmDenominacion, prmAño, prmMes, prmDia));
            return true;
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
        #region Validaciones
        public bool login(string prmUsuario, string prmContraseña)
        {
            return false;
        }
        #endregion
        #region Testing
        public void generar()
        {
            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda("0", "COP", 100, 1992));
            atrMonedas.Add(new clsMoneda("1", "COP", 500, 1998));
            atrMonedas.Add(new clsMoneda("5", "COP", 200, 1984));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1992, 2, 20));
            atrBilletes.Add(new clsBillete("CDF456", "COP", 500, 1992, 2, 20));
            atrBilletes.Add(new clsBillete("ABC789", "COP", 100000, 2020, 3, 13));

            atrAlcancias = new List<clsAlcancia>();
            atrAlcancias.Add(new clsAlcancia("COP", 10, 12, new List<int> { 100, 500 }, new List<int> { 500, 1000 }));

            atrAlcancias[0].darMonedas().Add(atrMonedas[0]);
            atrAlcancias[0].darMonedas().Add(atrMonedas[1]);
            atrAlcancias[0].darBilletes().Add(atrBilletes[0]);
            atrAlcancias[0].darBilletes().Add(atrBilletes[1]);

            atrAlcancias[0].calcularEstadoCuenta();
        }
        #endregion
        #endregion
    }
}