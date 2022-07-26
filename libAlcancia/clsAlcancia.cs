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
        public clsAlcancia() {}
        public clsAlcancia(string prmDivisa, int prmCapMonedas, int prmCapBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
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
            //TO DO
            atrMonedas = prmLista;
            return true;
        }
        public bool ponerBilletes(List<clsBillete> prmLista)
        {
            //TO DO
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
        #region Testing
        public void generar() 
        {
            atrDivisa = "COP";
            #region Monedas
            atrCapacidadMonedas = 10;
            atrDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            atrSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100, 0 };
            atrConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1, 0 };
            atrSaldoMonedas = 3500;                                                         //Se agrego saldoMonedas

            atrMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            atrMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            atrMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            atrMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            atrMonedas.Add(new clsMoneda("6", "COP", 200, 1992));
            atrMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            atrMonedas.Add(new clsMoneda("8", "COP", 100, 1988));

            foreach (clsMoneda varObjeto in atrMonedas)
                varObjeto.ponerAlcancia(this);

            #endregion
            #region Billetes
            atrCapacidadBilletes = 10;
            atrDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };          //Modificado: Swap position 5000 <> 2000
            atrSaldoDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };     //Modificado: Swap position 5000 <> 2000
            atrConteoDenominacionesBilletes = new List<int> { 1, 1, 1, 1 };                 //Modificado: (denominacionesMonedas) to (denominacionesBilletes)
            atrSaldoBilletes = 18000;                                                       //Se agrego saldoBilletes

            atrBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            atrBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            atrBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));
            atrBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));

            foreach (clsBillete varObjeto in atrBilletes)
                varObjeto.ponerAlcancia(this);

            atrSaldoTotal = 21500;                                                          //Se agrego saldoTotal

            #endregion

        }
        public void generar2()
        {
            atrCapacidadMonedas = 22;
            atrCapacidadBilletes = 11;

            #region Universo Monedas
            atrDenominacionesMonedas = new List<int> { 100, 200, 500 };
            atrSaldoDenominacionesMonedas = new List<int> { 1100, 600, 3000 };
            atrConteoDenominacionesMonedas = new List<int> { 11, 3, 6 };
            atrSaldoMonedas = 4700;
            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda("0", "COP", 100, 2011));
            atrMonedas.Add(new clsMoneda("1", "COP", 100, 1999));
            atrMonedas.Add(new clsMoneda("2", "COP", 100, 2010));
            atrMonedas.Add(new clsMoneda("3", "COP", 100, 2000));
            atrMonedas.Add(new clsMoneda("4", "COP", 100, 2009));
            atrMonedas.Add(new clsMoneda("5", "COP", 100, 2010));
            atrMonedas.Add(new clsMoneda("6", "COP", 100, 1999));
            atrMonedas.Add(new clsMoneda("7", "COP", 100, 2010));
            atrMonedas.Add(new clsMoneda("8", "COP", 100, 2000));
            atrMonedas.Add(new clsMoneda("9", "COP", 100, 2009));
            atrMonedas.Add(new clsMoneda("10", "COP", 100, 2010));

            atrMonedas.Add(new clsMoneda("11", "COP", 200, 2010));
            atrMonedas.Add(new clsMoneda("12", "COP", 200, 2011));
            atrMonedas.Add(new clsMoneda("13", "COP", 200, 2010));

            atrMonedas.Add(new clsMoneda("14", "COP", 500, 2010));
            atrMonedas.Add(new clsMoneda("15", "COP", 500, 2011));
            atrMonedas.Add(new clsMoneda("16", "COP", 500, 2010));
            atrMonedas.Add(new clsMoneda("17", "COP", 500, 2010));
            atrMonedas.Add(new clsMoneda("18", "COP", 500, 2011));
            atrMonedas.Add(new clsMoneda("19", "COP", 500, 2010));
            #endregion
            #region Universo Billetes
            atrDenominacionesBilletes = new List<int> { 1000, 2000, 5000 };
            atrSaldoDenominacionesBilletes = new List<int> { 3000, 10000, 5000 };
            atrConteoDenominacionesBilletes = new List<int> { 3, 5, 1 };
            atrSaldoBilletes = 18000;

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete("ABC123", "COP", 1000, 2010, 11, 4));
            atrBilletes.Add(new clsBillete("ABC456", "COP", 1000, 2011, 8, 17));
            atrBilletes.Add(new clsBillete("ABC789", "COP", 1000, 2009, 12, 27));

            atrBilletes.Add(new clsBillete("DEF789", "COP", 2000, 2009, 12, 27));
            atrBilletes.Add(new clsBillete("GHI789", "COP", 2000, 2009, 12, 27));
            atrBilletes.Add(new clsBillete("NMO789", "COP", 2000, 2009, 12, 27));
            atrBilletes.Add(new clsBillete("PQR789", "COP", 2000, 2011, 12, 27));
            atrBilletes.Add(new clsBillete("XYZ789", "COP", 2000, 2019, 12, 27));

            atrBilletes.Add(new clsBillete("AAX123", "COP", 5000, 2019, 11, 30));
            #endregion

            atrSaldoTotal = 22700;
        }
        #endregion
        #endregion
    }
}
