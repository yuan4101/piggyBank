using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using appAlcancia.Dominio;

namespace appAlcancia.Servicios.Pruebas
{
    [TestClass]
    public class uTestMoneda
    {
        private clsMoneda testMoneda;

        #region Test Accesores
        [TestMethod]
        public void uTestDarDenominacion()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1000, testMoneda.darDenominacion());
            #endregion
        }
        [TestMethod]
        public void uTestDarAño()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1993, testMoneda.darAño());
            #endregion
        }
        [TestMethod]
        public void uTestDarIDO()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("123", testMoneda.darIDO());
            #endregion
        }
        [TestMethod]
        public void uTestDarDivisa()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("COP", testMoneda.darDivisa());
            #endregion
        }
        [TestMethod]
        public void uTestDarAlcancia()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsNotNull(testMoneda.darAlcancia());
            Assert.AreEqual(typeof(clsAlcancia), testMoneda.darAlcancia().GetType());
            #endregion
        }
        #endregion
        #region Test Mutadores
        [TestMethod]
        public void uTestPonerAñoDentroDeAlcancia()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testMoneda.ponerAño(1990));
            Assert.AreEqual(1990, testMoneda.darAño());
            Assert.AreEqual("123", testMoneda.darIDO());
            Assert.AreEqual(1000, testMoneda.darDenominacion());
            Assert.AreEqual("COP", testMoneda.darDivisa());
            Assert.IsNotNull(testMoneda.darAlcancia());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionFueraDeAlcancia()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testMoneda.ponerDenominacion(500));
            Assert.AreEqual(0, testMoneda.darAño());
            Assert.IsNull(testMoneda.darIDO());
            Assert.AreEqual(500, testMoneda.darDenominacion());
            Assert.IsNull(testMoneda.darDivisa());
            Assert.IsNull(testMoneda.darAlcancia());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionDentroDeAlcancia()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testMoneda.ponerDenominacion(500));
            Assert.AreEqual(1993, testMoneda.darAño());
            Assert.AreEqual("123", testMoneda.darIDO());
            Assert.AreEqual(500, testMoneda.darDenominacion());
            Assert.AreEqual("COP", testMoneda.darDivisa());
            Assert.IsNotNull(testMoneda.darAlcancia());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDivisaFueraDeAlcancia()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testMoneda.ponerDivisa("USD"));
            Assert.AreEqual(0, testMoneda.darAño());
            Assert.IsNull(testMoneda.darIDO());
            Assert.AreEqual(0, testMoneda.darDenominacion());
            Assert.AreEqual("USD", testMoneda.darDivisa());
            Assert.IsNull(testMoneda.darAlcancia());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDivisaDentroDeAlcancia()
        {
            #region Configurar
            testMoneda = new clsMoneda();
            testMoneda.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testMoneda.ponerDivisa("USD"));
            Assert.AreEqual(1993, testMoneda.darAño());
            Assert.AreEqual("123", testMoneda.darIDO());
            Assert.AreEqual(1000, testMoneda.darDenominacion());
            Assert.AreEqual("USD", testMoneda.darDivisa());
            Assert.IsNotNull(testMoneda.darAlcancia());
            #endregion
        }
        #endregion
        #region Test Constructores
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testMoneda = new clsMoneda("123", "COP", 1000, 1993);
            Assert.AreEqual("123", testMoneda.darIDO());
            Assert.AreEqual("COP", testMoneda.darDivisa());
            Assert.AreEqual(1000, testMoneda.darDenominacion());
            Assert.AreEqual(1993, testMoneda.darAño());
            #endregion
        }
        #endregion
    }
}
