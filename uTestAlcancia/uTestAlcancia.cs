using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using appAlcancia.Dominio;

namespace appAlcancia.Servicios.Pruebas
{
    [TestClass]
    public class uTestAlcancia
    {
        private clsAlcancia testAlcancia;
        private List<clsMoneda> testMonedas;
        private List<clsBillete> testBilletes;
        private List<int> testDenominacionesMonedas;
        private List<int> testSaldoDenominacionesMonedas;
        private List<int> testConteoDenominacionesMonedas;
        private List<int> testDenominacionesBilletes;
        private List<int> testSaldoDenominacionesBilletes;
        private List<int> testConteoDenominacionesBilletes;

        public void poblarColeccionesEspejo()
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

            foreach (clsMoneda varObjeto in testMonedas)
                varObjeto.ponerAlcancia(testAlcancia);

            testDenominacionesMonedas = new List<int> { 1000, 500, 200, 100, 50 };
            testSaldoDenominacionesMonedas = new List<int> { 2000, 1000, 400, 100, 0 };
            testConteoDenominacionesMonedas = new List<int> { 2, 2, 2, 1, 0 };
            #endregion
            #region Billetes
            testBilletes = new List<clsBillete>();
            testBilletes.Add(new clsBillete("ABC123", "COP", 1000, 1990, 11, 5));
            testBilletes.Add(new clsBillete("QWE789", "COP", 2000, 1992, 7, 18));
            testBilletes.Add(new clsBillete("CDE456", "COP", 5000, 1990, 4, 16));
            testBilletes.Add(new clsBillete("YUI900", "COP", 10000, 1988, 12, 27));

            foreach (clsBillete varObjeto in testBilletes)
                varObjeto.ponerAlcancia(testAlcancia);

            testDenominacionesBilletes = new List<int> { 1000, 2000, 5000, 10000 };
            testSaldoDenominacionesBilletes = new List<int> { 1000, 2000, 5000, 10000 };
            testConteoDenominacionesMonedas = new List<int> { 1, 1, 1, 1 };

            #endregion
        }

        #region Test Accesores TO DO
        [TestMethod]
        public void uTestDarMoneda()
        {
            #region Configurar
            testAlcancia = new clsAlcancia();
            testAlcancia.generar();
            poblarColeccionesEspejo();
            #endregion
            #region Probar y Comprobar
            Assert.IsNotNull(testAlcancia.darMonedas());
            Assert.AreEqual(7, testAlcancia.darMonedas().Count);
            //TO DO
            //Assert.IsTrue(testMonedas.Equals(testAlcancia.darMonedas()));
            //CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas().);
            #endregion
        }
        #endregion
        #region Test Mutadores
        [TestMethod]
        public void testPonerMonedasConAlcanciaVacia()
        {
            #region Configurar
            testAlcancia = new clsAlcancia();
            poblarColeccionesEspejo();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerMonedas(testMonedas));
            Assert.AreEqual(testMonedas.Count, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(3500, testAlcancia.darSaldoTotal());
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());

            for (int varIterador = 0; varIterador < testMonedas.Count; varIterador++)
                Assert.AreEqual(0, testMonedas[varIterador].CompareTo(testAlcancia.darMonedas()[varIterador]));

            for (int varIterador = 0; varIterador < testDenominacionesMonedas.Count; varIterador++)
                Assert.AreEqual(0, testDenominacionesMonedas[varIterador].CompareTo(testAlcancia.darDenominacionesMonedas()[varIterador]));
            
            for (int varIterador = 0; varIterador < testSaldoDenominacionesMonedas.Count; varIterador++)
                Assert.AreEqual(0, testSaldoDenominacionesMonedas[varIterador].CompareTo(testAlcancia.darSaldoDenominacionesMonedas()[varIterador]));
            
            for (int varIterador = 0; varIterador < testConteoDenominacionesMonedas.Count; varIterador++)
                Assert.AreEqual(0, testConteoDenominacionesMonedas[varIterador].CompareTo(testAlcancia.darConteoDenominacionesMonedas()[varIterador]));

            for (int varIterador = 0; varIterador < testAlcancia.darMonedas().Count; varIterador++)
                Assert.AreEqual(testAlcancia, testAlcancia.darMonedas()[varIterador].darAlcancia());

            Assert.AreEqual(0, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darConteoDenominacionesBilletes().Count);

            #endregion
        }
        [TestMethod]
        public void testPonerMonedasConAlcanciaVaciaConfigurada()
        {
            #region Configurar
            poblarColeccionesEspejo();
            testAlcancia = new clsAlcancia("COP", 12, 5, testDenominacionesMonedas, testDenominacionesBilletes);
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testAlcancia.ponerMonedas(testMonedas));
            Assert.AreEqual(testMonedas.Count, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual("COP", testAlcancia.darDivisa());
            Assert.AreEqual(3500, testAlcancia.darSaldoTotal());
            Assert.AreEqual(3500, testAlcancia.darSaldoMonedas());

            for (int varIterador = 0; varIterador < testMonedas.Count; varIterador++)
                Assert.AreEqual(0, testMonedas[varIterador].CompareTo(testAlcancia.darMonedas()[varIterador]));

            for (int varIterador = 0; varIterador < testDenominacionesMonedas.Count; varIterador++)
                Assert.AreEqual(0, testDenominacionesMonedas[varIterador].CompareTo(testAlcancia.darDenominacionesMonedas()[varIterador]));

            for (int varIterador = 0; varIterador < testSaldoDenominacionesMonedas.Count; varIterador++)
                Assert.AreEqual(0, testSaldoDenominacionesMonedas[varIterador].CompareTo(testAlcancia.darSaldoDenominacionesMonedas()[varIterador]));

            for (int varIterador = 0; varIterador < testConteoDenominacionesMonedas.Count; varIterador++)
                Assert.AreEqual(0, testConteoDenominacionesMonedas[varIterador].CompareTo(testAlcancia.darConteoDenominacionesMonedas()[varIterador]));

            for (int varIterador = 0; varIterador < testAlcancia.darMonedas().Count; varIterador++)
                Assert.AreEqual(testAlcancia, testAlcancia.darMonedas()[varIterador].darAlcancia());

            Assert.AreEqual(0, testAlcancia.darCapacidadBilletes());
            Assert.AreEqual(0, testAlcancia.darSaldoBilletes());
            Assert.AreEqual(0, testAlcancia.darBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darSaldoDenominacionesBilletes().Count);
            Assert.AreEqual(0, testAlcancia.darConteoDenominacionesBilletes().Count);

            #endregion
        }
        #endregion
        #region Test Constructores

        #endregion
    }
}
