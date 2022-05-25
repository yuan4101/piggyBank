using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsAlcancia
    {
        #region Atributos
        #region Propios
        private int atrCapacidadMonedas;
        private int atrCapacidadBilletes;
        private string atrDivisa;
        private List<int> atrDenominacionesMonedas = new List<int>();
        private List<int> atrDenominacionesBilletes = new List<int>();
        #endregion
        #region Asociativos
        private clsAlcancia atrAlcancia;
        private List<clsMoneda> atrMonedas = new List<clsMoneda>();
        private List<clsBillete> atrBilletes = new List<clsBillete>();
        #endregion
        #region Derivables
        private int atrSaldoTotal;
        private int atrSaldoMonedas;
        private int atrSaldoBilletes;
        private List<int> atrSaldoDenominacionesMonedas = new List<int>();
        private List<int> atrSaldoDenominacionesBilletes = new List<int>();
        private List<int> atrConteoDenominacionesMonedas = new List<int>();
        private List<int> atrConteoDenominacionesBilletes = new List<int>();
        #endregion
        #endregion
        #region Operaciones
        #region Constructor
        public clsAlcancia() 
        {
        }
        public clsAlcancia(string prmDivisa, int prmCapMonedas, int prmCapBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            //TO DO
            atrDivisa = prmDivisa;
            atrCapacidadMonedas = prmCapMonedas;
            atrCapacidadBilletes = prmCapBilletes;
            atrDenominacionesMonedas = prmDenMonedas;
            atrDenominacionesBilletes = prmDenBilletes;
        }
        #endregion
        #region Accesores
        public List<clsMoneda> darMonedas()
        {
            return atrMonedas;
        }
        public List<clsBillete> darBilletes()
        {
            return atrBilletes;
        }
        public int darCapacidadMonedas()
        {
            return atrCapacidadMonedas;
        }
        public int darCapacidadBilletes()
        {
            return atrCapacidadBilletes;
        }
        public string darDivisa()
        {
            return atrDivisa;
        }
        public List<int> darDenominacionesMonedas()
        {
            return atrDenominacionesMonedas;
        }
        public List<int> darDenominacionesBilletes()
        {
            return atrDenominacionesBilletes;
        }
        public int darSaldoTotal()
        {
            return atrSaldoTotal;
        }
        public int darSaldoMonedas()
        {
            return atrSaldoMonedas;
        }
        public int darSaldoBilletes()
        {
            return atrSaldoBilletes;
        }
        public List<int> darSaldoDenominacionesMonedas()
        {
            return atrSaldoDenominacionesMonedas;
        }
        public List<int> darSaldoDenominacionesBilletes()
        {
            return atrSaldoDenominacionesBilletes;
        }
        public List<int> darConteoDenominacionesBilletes()
        {
            return atrConteoDenominacionesBilletes;
        }
        public List<int> darConteoDenominacionesMonedas()
        {
            return atrConteoDenominacionesMonedas;
        }
        #endregion
        #region Mutadores
        public bool ponerMonedas(List<clsMoneda> prmLista)
        {
            atrMonedas = prmLista;
            return true;
        }
        public bool ponerBilletes(List<clsBillete> prmLista)
        {
            atrBilletes = prmLista;
            return true;
        }
        public bool ponerCapacidadMonedas(int prmValor)
        {
            atrCapacidadMonedas = prmValor;
            return true;
        }
        public bool ponerCapacidadBilletes(int prmValor)
        {
            atrCapacidadBilletes = prmValor;
            return true;
        }
        public bool ponerDivisa(string prmNombre)
        {
            atrDivisa = prmNombre;
            return true;
        }
        public bool ponerDenominacionesMonedas(List<int> prmColeccion)
        {
            atrDenominacionesMonedas = prmColeccion;
            return true;
        }
        public bool ponerDenominacionesBilletes(List<int> prmColeccion)
        {
            atrDenominacionesBilletes = prmColeccion;
            return true;
        }
        public bool calcularEstadoCuenta()
        {
            //TODO : IMPLEMENTAR
            return false;
        }
        #endregion
        #region Transacciones
        public bool consignar(clsMoneda prmItem)
        {
            throw new NotImplementedException();
        }
        public bool consignar(clsBillete prmItem)
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
        #endregion
    }
}
