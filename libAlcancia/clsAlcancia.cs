﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appAlcancia.Servicios;

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
            if (ponerDivisa(prmLista[0].darDivisa()))
                if (!verificaDivisaLista(prmLista))
                    return false;
            if (atrCapacidadMonedas < atrCapacidadMonedas + atrMonedas.Count)
                atrMonedas.AddRange(prmLista);
            calcularEstadoCuenta();
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
            if (atrDivisa != null)
                return false;
            atrDivisa = prmNombre;
            return calcularEstadoCuenta();
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
            calcularSaldoTotal();
            return false;
        }
        #endregion
        #region Utilitario
        private void calcularSaldoTotal()
        {
            for (int varIndex = 0; varIndex < atrMonedas.Count; varIndex++)
            {
                atrSaldoTotal += atrMonedas[varIndex].darDenominacion();
            }
            for (int varIndex = 0; varIndex < atrBilletes.Count; varIndex++)
            {
                atrSaldoTotal += atrBilletes[varIndex].darDenominacion();
            }
        }
        private bool verificaDivisaLista(List<clsMoneda> prmLista)
        {
            for (int varIndex = 0; varIndex < prmLista.Count; varIndex++)
            {
                if (!prmLista[varIndex].darDivisa().Equals(atrDivisa))
                    return false;
            }
            return true;
        }
        #endregion
        #region Transacciones
        public bool consignar(clsMoneda prmItem)
        {
            if (atrMonedas.Count() == atrCapacidadMonedas)
                return false;

            int varDenominacion = prmItem.darDenominacion();

            if (clsParametrizador.esValidoRangoDenominacion(varDenominacion))
            {
                atrMonedas.Add(prmItem);

                if (atrDenominacionesMonedas.Contains(varDenominacion))
                {
                    int varIndice = atrDenominacionesMonedas.IndexOf(varDenominacion);
                    atrConteoDenominacionesMonedas[varIndice]++;
                    atrSaldoDenominacionesMonedas[varIndice] += varDenominacion;
                }
                else
                    return false;

                atrSaldoMonedas += varDenominacion;
                atrSaldoTotal = atrSaldoMonedas + atrSaldoBilletes;
                return true;
            }
            return false;
        }
        public bool consignar(clsBillete prmItem)
        {
            if (atrBilletes.Count() == atrCapacidadBilletes)
                return false;

            int varDenominacion =  prmItem.darDenominacion();

            if (clsParametrizador.esValidoRangoDenominacion(varDenominacion))
            {
                atrBilletes.Add(prmItem);

                if (atrDenominacionesBilletes.Contains(varDenominacion))
                {
                    int varIndice = atrDenominacionesBilletes.IndexOf(varDenominacion);
                    atrConteoDenominacionesBilletes[varIndice]++;
                    atrSaldoDenominacionesBilletes[varIndice] += varDenominacion;
                }
                else
                    return false;
                
                atrSaldoBilletes += varDenominacion;
                atrSaldoTotal = atrSaldoMonedas + atrSaldoBilletes;
                return true;
            }
            return false;
        }
        public clsMoneda retirarMoneda(string prmIDO)
        {
            clsMoneda varMoneda = buscarMoneda(prmIDO);
            if (varMoneda == null)
                return null;

            atrMonedas.Remove(varMoneda);
            int varDenominacion = varMoneda.darDenominacion();
            int varIndice = atrDenominacionesMonedas.IndexOf(varDenominacion);
            atrConteoDenominacionesMonedas[varIndice]--;
            atrSaldoDenominacionesMonedas[varIndice] -= varDenominacion;
            atrSaldoMonedas -= varDenominacion;
            atrSaldoTotal = atrSaldoMonedas + atrSaldoBilletes;
            return varMoneda;
        }
        public clsBillete retirarBillete(string prmSerial)
        {
            clsBillete varBillete = buscarBillete(prmSerial);
            if (varBillete == null)
                return null;

            atrBilletes.Remove(varBillete);
            int varDenominacion = varBillete.darDenominacion();
            int varIndice = atrDenominacionesBilletes.IndexOf(varDenominacion);
            atrConteoDenominacionesBilletes[varIndice]--;
            atrSaldoDenominacionesBilletes[varIndice] -= varDenominacion;
            atrSaldoBilletes -= varDenominacion;
            atrSaldoTotal = atrSaldoMonedas + atrSaldoBilletes;
            return varBillete;
        }
        #endregion
        #region MyRegion
        public clsMoneda buscarMoneda(string prmIDO)
        {
            foreach (var varItem in atrMonedas)
            {
                if (varItem.darIDO() == prmIDO)
                    return varItem;
            }
            return null;
        }
        public clsBillete buscarBillete(string prmSerial)
        {
            foreach (var varItem in atrBilletes)
            {
                if (varItem.darSerial() == prmSerial)
                    return varItem;
            }
            return null;
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
            atrBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));            //Se modifico el orden del add (Primero la denominacion de 5000 y luego la de 2000)
            atrBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
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