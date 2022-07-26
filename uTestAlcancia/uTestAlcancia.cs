using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace appAlcancia.Servicios.Pruebas
    {
    [TestClass]
    public class uTestAlcancia
        {
        #region Atributos de Prueba
        private clsAlcancia testAlcancia;
        private clsMoneda testMoneda;
        private clsBillete testBillete;
        private List<clsMoneda> testMonedas;
        private List<clsMoneda> testMonedas2;
        private List<clsBillete> testBilletes;
        private List<int> testDenominacionesMonedas;
        private List<int> testDenominacionesMonedas2;
        private List<int> testDenominacionesBilletes;
        private List<int> testDenominacionesBilletes2;
        private List<int> testSaldoDenominacionesMonedas;
        private List<int> testSaldoDenominacionesMonedas2;
        private List<int> testSaldoDenominacionesBilletes;
        private List<int> testSaldoDenominacionesBilletes2;
        private List<int> testConteoDenominacionesMonedas;
        private List<int> testConteoDenominacionesMonedas2;
        private List<int> testConteoDenominacionesBilletes;
        private List<int> testConteoDenominacionesBilletes2;
        #endregion
        #region Pobladores Colecciones Espejo
        public void poblarColeccionesEspejoCasoNormal()
            {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 200, 1992));
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));
            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100 }; //Se elimina denominacion "50"
            testSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100 }; //Se elimina saldo denominacion "0"
            testConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1 }; //Se elimina conteo denominacion "0"

            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testSaldoDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testConteoDenominacionesBilletes = new List<int> { 1, 1, 1, 1 };
            #endregion
            }
        public void poblarColeccionesEspejoCasoDistintaDivisa()
        {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "EUR", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 200, 1992));
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));
            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100, 0 };
            testConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1, 0 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "USD", 5000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testSaldoDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testConteoDenominacionesBilletes = new List<int> { 1, 1, 1, 1 };
            #endregion
        }
        public void poblarColeccionesEspejoCasoDenominacionesRechazadas()
            {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 250, 1992));
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));
            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "COP", 25000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            #endregion
            }
        public void poblarColeccionesEspejoIgualDivisaCasoOtrosDineros()
            {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 200, 1992));
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));
            testMonedas.Add(new clsMoneda("12", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("24", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("40", "COP", 50, 1990));

            testMonedas2 = new List<clsMoneda>();
            testMonedas2.Add(new clsMoneda("12", "COP", 1000, 1990));
            testMonedas2.Add(new clsMoneda("24", "COP", 1000, 1992));
            testMonedas2.Add(new clsMoneda("40", "COP", 50, 1990));
            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testSaldoDenominacionesMonedas = new List<int> { 4000, 1000, 400, 100, 50 };
            testConteoDenominacionesMonedas = new List<int> { 4, 2, 2, 1, 1 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testSaldoDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testConteoDenominacionesBilletes = new List<int> { 1, 1, 1, 1 };
            #endregion
            }
        public void poblarColeccionesEspejoCasoDistintaDivisaOtrosDineros()
            {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 200, 1992));
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));
            testMonedas.Add(new clsMoneda("12", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("24", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("40", "COP", 50, 1990));

            testMonedas2 = new List<clsMoneda>();
            testMonedas2.Add(new clsMoneda("12", "COP", 1000, 1990));
            testMonedas2.Add(new clsMoneda("24", "EUR", 1000, 1992));
            testMonedas2.Add(new clsMoneda("40", "COP", 50, 1990));
            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100, 0 };
            testConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1, 0 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testSaldoDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testConteoDenominacionesBilletes = new List<int> { 1, 1, 1, 1 };
            #endregion
            }
        public void poblarColeccionesEspejoCasoDenominacionesRechazadasOtrosDineros()
            {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 200, 1992)); // Cambio: 250 a 200 
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));
            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testMonedas2 = new List<clsMoneda>();
            testMonedas2.Add(new clsMoneda("12", "COP", 1000, 1990));
            testMonedas2.Add(new clsMoneda("24", "COP", 1000, 1992));
            testMonedas2.Add(new clsMoneda("40", "COP", 20, 1990));
            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100, 0 };
            testConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1, 0 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "COP", 25000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            #endregion
            }
        public void poblarColeccionesEspejoCasoMasDenominaciones()
            {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 200, 1992));
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));

            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100, 0 };
            testConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1, 0 };

            testDenominacionesMonedas2 = new List<int> { 1000, 500, 200, 100, 50, 20 };
            testSaldoDenominacionesMonedas2 = new List<int> { 2000, 1000, 400, 100, 0, 0 };
            testConteoDenominacionesMonedas2 = new List<int> { 2, 2, 2, 1, 0, 0 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testSaldoDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testConteoDenominacionesBilletes = new List<int> { 1, 1, 1, 1 };
            #endregion
            }
        public void poblarColeccionesEspejoCasoMenosDenominacionesConSaldos()
            {
            #region Monedas
            testMonedas = new List<clsMoneda>();
            testMonedas.Add(new clsMoneda("1", "COP", 1000, 1990));
            testMonedas.Add(new clsMoneda("2", "COP", 1000, 1992));
            testMonedas.Add(new clsMoneda("3", "COP", 500, 1990));
            testMonedas.Add(new clsMoneda("4", "COP", 500, 1998));
            testMonedas.Add(new clsMoneda("6", "COP", 200, 1992));
            testMonedas.Add(new clsMoneda("7", "COP", 200, 1984));
            testMonedas.Add(new clsMoneda("8", "COP", 100, 1988));

            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100, 0 };
            testConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1, 0 };

            testDenominacionesMonedas2 = new List<int> { 500, 200, 100, 50 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));
            testDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testSaldoDenominacionesBilletes = new List<int> { 1000, 5000, 2000, 10000 };
            testConteoDenominacionesBilletes = new List<int> { 1, 1, 1, 1 };
            #endregion
            }
        #endregion
        #region Test Accesores
        [TestMethod]
        public void uTestDarMonedas()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            Assert.IsNotNull(testAlcancia.darMonedas());
            Assert.AreEqual(7, testAlcancia.darMonedas().Count);
            for (int varIterador = 0; varIterador < testMonedas.Count; varIterador++)
                Assert.AreEqual(0, testMonedas[varIterador].CompareTo(testAlcancia.darMonedas()[varIterador]));
            #endregion
            }
        [TestMethod]
        public void uTestDarBilletes()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            Assert.IsNotNull(testAlcancia.darBilletes());
            Assert.AreEqual(4, testAlcancia.darBilletes().Count);
            for (int varIterador = 0; varIterador < testBilletes.Count; varIterador++)
                Assert.AreEqual(0, testBilletes[varIterador].CompareTo(testAlcancia.darBilletes()[varIterador]));
            #endregion
            }
        [TestMethod]
        public void uTestDarCapacidadMonedas()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(10, testAlcancia.darCapacidadMonedas());
            #endregion
            }
        [TestMethod]
        public void uTestDarCapacidadBilletes()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(10, testAlcancia.darCapacidadBilletes());
            #endregion
            }
        [TestMethod]
        public void uTestDarDivisa()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            #endregion
            }
        [TestMethod]
        public void uTestDarDenominacionesMonedas()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            for (int i = 0; i < testDenominacionesMonedas.Count; i++)
                Assert.AreEqual(testDenominacionesMonedas[i], testAlcancia.darDenominacionesMonedas()[i]);
            #endregion
            }
        [TestMethod]
        public void uTestDarDenominacionesBilletes()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            for (int i = 0; i < testDenominacionesBilletes.Count; i++)
                Assert.AreEqual(testDenominacionesBilletes[i], testAlcancia.darDenominacionesBilletes()[i]);
            #endregion
            }
        [TestMethod]
        public void uTestDarSaldoTotal()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(21500, testAlcancia.darSaldoTotal());
            #endregion
            }
        [TestMethod]
        public void uTestDarSaldoMonedas()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());
            #endregion
            }
        [TestMethod]
        public void uTestDarSaldoBilletes()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());
            #endregion
            }
        [TestMethod]
        public void uTestDarSaldoDenominacionesMonedas()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            for (int i = 0; i < testSaldoDenominacionesMonedas.Count; i++)
                Assert.AreEqual(testSaldoDenominacionesMonedas[i], testAlcancia.darSaldoDenominacionesMonedas()[i]);
            #endregion
            }
        [TestMethod]
        public void uTestDarSaldoDenominacionesBilletes()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            for (int i = 0; i < testSaldoDenominacionesBilletes.Count; i++)
                Assert.AreEqual(testSaldoDenominacionesBilletes[i], testAlcancia.darSaldoDenominacionesBilletes()[i]);
            #endregion
            }
        [TestMethod]
        public void uTestDarConteoDenominacionesMonedas()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            for (int i = 0; i < testConteoDenominacionesMonedas.Count; i++)
                Assert.AreEqual(testConteoDenominacionesMonedas[i], testAlcancia.darConteoDenominacionesMonedas()[i]);
            #endregion
            }
        [TestMethod]
        public void uTestDarConteoDenominacionesBilletes()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            for (int i = 0; i < testConteoDenominacionesBilletes.Count; i++)
                Assert.AreEqual(testConteoDenominacionesBilletes[i], testAlcancia.darConteoDenominacionesBilletes()[i]);
            #endregion
            }
        #endregion
        #region Test Mutadores
        #region Poner Monedas
        [TestMethod]
        public void testPonerMonedasIgualDivisaConAlcanciaVacia()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            poblarColeccionesEspejoCasoNormal();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerMonedas(testMonedas));
            #region Comprobaciones Alcancia
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(3500, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(testMonedas.Count, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());
            CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas());
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas, testAlcancia.darConteoDenominacionesMonedas());
            foreach (clsMoneda testMoneda in testAlcancia.darMonedas())
                Assert.AreEqual(testAlcancia, testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(0, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
            }
        [TestMethod]
        public void testPonerMonedasDistintaDivisaConAlcanciaVacia()
        {
            #region Configurar
            testAlcancia = new clsAlcancia();
            poblarColeccionesEspejoCasoDistintaDivisa();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerMonedas(testMonedas));
            #region Comprobaciones  Alcancia
            Assert.IsNull(testAlcancia.darDivisa());
            Assert.AreEqual(0, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(0, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(0, testAlcancia.darSaldoMonedas());
            Assert.AreEqual(0, testAlcancia.darMonedas().Count);
            Assert.AreEqual(0, testAlcancia.darDenominacionesMonedas().Count);
            Assert.AreEqual(0, testAlcancia.darSaldoDenominacionesMonedas().Count);
            Assert.AreEqual(0, testAlcancia.darConteoDenominacionesMonedas().Count);

            foreach (clsMoneda testMoneda in testAlcancia.darMonedas())
                Assert.AreEqual(testAlcancia, testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(0, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
        }
        [TestMethod]
        public void testPonerMonedasIgualDivisaConAlcanciaVaciaConfigurada()
            {
            #region Configurar
            poblarColeccionesEspejoCasoNormal();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerMonedas(testMonedas));
            #region Comprobaciones Alcancía
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(3500, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(testMonedas.Count, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());
            CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas());
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas, testAlcancia.darConteoDenominacionesMonedas());
            foreach (clsMoneda testMoneda in testAlcancia.darMonedas())
                Assert.AreEqual(testAlcancia, testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(5, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
            }
        [TestMethod]
        public void testPonerMonedasDistintaDivisaConAlcanciaVaciaConfigurada()
            {
            #region Configurar
            poblarColeccionesEspejoCasoDistintaDivisa();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerMonedas(testMonedas));
            #region Comprobaciones Alcancia
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(0, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(12, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(0, testAlcancia.darSaldoMonedas());
            Assert.AreEqual(0, testAlcancia.darMonedas().Count);
            Assert.AreEqual(5, testAlcancia.darDenominacionesMonedas().Count);
            Assert.AreEqual(5, testAlcancia.darSaldoDenominacionesMonedas().Count);
            Assert.AreEqual(5, testAlcancia.darConteoDenominacionesMonedas().Count);
            foreach (clsMoneda testMoneda in testMonedas)
                Assert.AreEqual(null, testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones  Billetes
            Assert.AreEqual(5, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
            }
        [TestMethod]
        public void testPonerMonedasDenominacionRechazadaConAlcanciaVaciaConfigurada()
            {
            #region Configurar
            poblarColeccionesEspejoCasoDenominacionesRechazadas();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerMonedas(testMonedas));
            #region Comprobaciones Alcancía
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(0, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(12, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(0, testAlcancia.darSaldoMonedas());
            Assert.AreEqual(0, testAlcancia.darMonedas().Count);
            Assert.AreEqual(5, testAlcancia.darDenominacionesMonedas().Count);
            Assert.AreEqual(5, testAlcancia.darSaldoDenominacionesMonedas().Count);
            Assert.AreEqual(5, testAlcancia.darConteoDenominacionesMonedas().Count);
            foreach (clsMoneda testMoneda in testMonedas)
                Assert.AreEqual(null, testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(5, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
            }
        [TestMethod]
        public void testPonerMonedasIgualDivisaEnAlcanciaConMonedas()
        {
            #region Configurar
            poblarColeccionesEspejoIgualDivisaCasoOtrosDineros();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerMonedas(testMonedas2));
            #region Comprobaciones Alcancía
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(23550, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(10, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(5550, testAlcancia.darSaldoMonedas());
            CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas());
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas, testAlcancia.darConteoDenominacionesMonedas());
            foreach (clsMoneda testMoneda in testAlcancia.darMonedas())
                Assert.AreEqual(testAlcancia, testMoneda.darAlcancia());
            foreach (clsMoneda tesMoneda in testMonedas2)
                Assert.IsNull(testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(5, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
        }
        [TestMethod]
        public void testPonerMonedasDistintaDivisaEnAlcanciaConMonedas()
            {
            #region Configurar
            poblarColeccionesEspejoCasoDistintaDivisaOtrosDineros();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerMonedas(testMonedas2));
            #region Comprobaciones Alcancía
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(21500, testAlcancia.darSaldoTotal()); // Cambio: 3500 a 21500
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(12, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());
            CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas());
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas, testAlcancia.darConteoDenominacionesMonedas());
            foreach (clsMoneda testMoneda in testAlcancia.darMonedas())
                Assert.AreEqual(testAlcancia, testMoneda.darAlcancia());
            foreach (clsMoneda tesMoneda in testMonedas2)
                Assert.IsNull(testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(5, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
            }
        [TestMethod]
        public void testPonerMonedasDenominacionRechazadaEnAlcanciaConMonedas()
        {
            //POSIBLE ERROR = TURBIO
            #region Configurar
            poblarColeccionesEspejoCasoDenominacionesRechazadasOtrosDineros();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerMonedas(testMonedas2));
            #region Comprobaciones Alcancía
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(21500, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(10, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());
            CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas());
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas, testAlcancia.darConteoDenominacionesMonedas());
            foreach (clsMoneda testMoneda in testAlcancia.darMonedas())
                Assert.AreEqual(testAlcancia, testMoneda.darAlcancia());
            foreach (clsMoneda testMoneda in testMonedas2)
                Assert.IsNull(testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(10, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(4, testAlcancia.darBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
        }
        [TestMethod]
        public void testPonerMonedasRepetidasEnAlcanciaConMonedas()
            {
            #region Configurar
            poblarColeccionesEspejoCasoNormal();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerMonedas(testMonedas));
            #region Comprobaciones Alcancía
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(3500, testAlcancia.darSaldoTotal());
            #endregion
            #region Comprobaciones Monedas
            Assert.AreEqual(12, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());
            CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas());
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas, testAlcancia.darConteoDenominacionesMonedas());
            foreach (clsMoneda testMoneda in testAlcancia.darMonedas())
                Assert.AreEqual(testAlcancia, testMoneda.darAlcancia());
            foreach (clsMoneda tesMoneda in testMonedas2)
                Assert.IsNull(testMoneda.darAlcancia());
            #endregion
            #region Comprobaciones Billetes
            Assert.AreEqual(5, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(4, testAlcancia.darConteoDenominacionesBilletes().Count);
            #endregion
            #endregion
            }
        #endregion
        #region Poner Billetes
        #endregion
        #region Poner Capacidad Monedas y Billetes
        [TestMethod]
        public void uTestPonerCapacidadMonedasMayor()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerCapacidadMonedas(1000));
            Assert.AreEqual(1000, testAlcancia.darCapacidadMonedas());
            #endregion
            }
        [TestMethod]
        public void uTestPonerCapacidadMonedasMenor()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerCapacidadMonedas(5));
            Assert.AreEqual(10, testAlcancia.darCapacidadMonedas());
            #endregion
            }
        [TestMethod]
        public void uTestPonerCapacidadBilletesMayor()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerCapacidadBilletes(1000));
            Assert.AreEqual(1000, testAlcancia.darCapacidadBilletes());
            #endregion
            }
        [TestMethod]
        public void uTestPonerCapacidadBilletesMenor()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerCapacidadBilletes(3));
            Assert.AreEqual(10, testAlcancia.darCapacidadBilletes());
            #endregion
            }
        #endregion
        #region Poner Denominaciones
        [TestMethod]
        public void uTestPonerMasDenominacionesMonedasAlcanciaConDinero()
            {
            #region Configurar
            poblarColeccionesEspejoCasoMasDenominaciones();
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerDenominacionesMonedas(testDenominacionesMonedas2));
            CollectionAssert.AreEqual(testDenominacionesMonedas2, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas2, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas2, testAlcancia.darConteoDenominacionesMonedas());
            #endregion
            }
        [TestMethod]
        public void uTestPonerMenosDenominacionesMonedasAlcanciaConDinero()
            {
            #region Configurar
            poblarColeccionesEspejoCasoMenosDenominacionesConSaldos();
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testAlcancia.ponerDenominacionesMonedas(testDenominacionesMonedas2));
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoDenominacionesMonedas, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(testConteoDenominacionesMonedas, testAlcancia.darConteoDenominacionesMonedas());
            #endregion
            }
        #endregion
        #endregion
        #region Transacciones
        #region Ingreso Moneda
        [TestMethod]
        public void uTestIngresoMonedaConDenominacionNoAceptada()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse( testAlcancia.consignar(new clsMoneda("20", "COP", 1000, 2010)));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
            }
        [TestMethod]
        public void uTestIngresoMonedaConDenominacionAceptada()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue( testAlcancia.consignar(new clsMoneda("20", "COP", 200, 2010)));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 800, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 4, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4900, testAlcancia.darSaldoMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            Assert.AreEqual(22900, testAlcancia.darSaldoTotal());
            #endregion
            }
        [TestMethod]
        public void uTestIngresoMonedaConCapacidadAgotada()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            testAlcancia.ponerCapacidadMonedas(20);
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse( testAlcancia.consignar(new clsMoneda("20", "COP", 500, 2010)));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
            }
        #endregion
        #region Ingreso Billete
        [TestMethod]
        public void uTestIngresoBilleteConDenominacionAceptada()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue( testAlcancia.consignar(new clsBillete("ABC124", "COP", 1000, 2010, 12, 27)));
            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 4000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 4, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(19000, testAlcancia.darSaldoBilletes());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            Assert.AreEqual(23700, testAlcancia.darSaldoTotal());
            #endregion
            }
        [TestMethod]
        public void uTestIngresoBilleteConDenominacionNoAceptada()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse( testAlcancia.consignar(new clsBillete("ABC125", "COP", 20000, 2010, 12, 27)));
            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
            }
        [TestMethod]
        public void uTestIngresoBilleteConCapacidadAgotada()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            testAlcancia.ponerCapacidadBilletes(9);
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse( testAlcancia.consignar(new clsBillete("ABC126", "COP", 2000, 2010, 12, 27)));
            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
            }
        #endregion
        #region Retirar Moneda
        [TestMethod]
        public void uTestRetirarMonedaExistente()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            testMoneda = new clsMoneda("11", "COP", 200, 2010);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(0, testAlcancia.retirarMoneda("11").CompareTo(testMoneda));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 400, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 2, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4500, testAlcancia.darSaldoMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            Assert.AreEqual(22500, testAlcancia.darSaldoTotal());
            #endregion
            }
        [TestMethod]
        public void uTestRetirarMonedaNOExistente()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            testMoneda = null;
            #endregion
            #region Probar y Comprobar
            Assert.IsNull( testAlcancia.retirarMoneda("20"));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
            }
        #endregion
        #region Retirar Billete
        [TestMethod]
        public void uTestRetirarBilleteExistente()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            testBillete = new clsBillete("DEF789", "COP", 2000, 2009, 12, 27);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(0,testAlcancia.retirarBillete("DEF789").CompareTo(testBillete));

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 8000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 4, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(16000, testAlcancia.darSaldoBilletes());

            Assert.AreEqual(20700, testAlcancia.darSaldoTotal());
            #endregion
            }
        [TestMethod]
        public void uTestRetirarBilleteNOExistente()
            {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar2();
            testBillete = null;
            #endregion
            #region Probar y Comprobar
            Assert.IsNull( testAlcancia.retirarBillete("XXXXXX"));
            
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoDenominacionesMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoDenominacionesBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
            }
        #endregion
        #endregion
        }
    }
