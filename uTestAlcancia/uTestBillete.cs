using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;


namespace appAlcancia.Servicios.Pruebas
    {
    [TestClass]
    public class uTestBillete
        {
        private clsBillete testBillete;
        #region Test Accesores
        [TestMethod]
        public void uTestDarMes()
            {
            #region Configurar
            testBillete = new clsBillete();
            testBillete.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(11, testBillete.darMes());
            #endregion
            }
        [TestMethod]
        public void uTestDarDia()
            {
            #region Configurar
            testBillete = new clsBillete();
            testBillete.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(4, testBillete.darDia());
            #endregion
            }
        [TestMethod]
        public void uTestDarSerial()
            {
            #region Configurar
            testBillete = new clsBillete();
            testBillete.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("123", testBillete.darSerial());
            #endregion
            }
        #endregion
        #region Test Mutadores
        [TestMethod]
        public void uTestPonerMesValido()
            {
            #region Configurar
            testBillete = new clsBillete();
            testBillete.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testBillete.ponerMes(12));
            Assert.AreEqual(4, testBillete.darDia());
            Assert.AreEqual(12, testBillete.darMes());
            Assert.AreEqual(1990, testBillete.darAño());
            Assert.AreEqual("123", testBillete.darIDO());
            Assert.AreEqual(1000, testBillete.darDenominacion());
            Assert.AreEqual("COP", testBillete.darDivisa());
            Assert.IsNotNull(testBillete.darAlcancia());
            #endregion
            }
        [TestMethod]
        public void uTestPonerMesMenorQue1()
            {
            #region Configurar
            testBillete = new clsBillete();
            testBillete.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testBillete.ponerMes(-1));
            Assert.AreEqual(4, testBillete.darDia());
            Assert.AreEqual(11, testBillete.darMes());
            Assert.AreEqual(1990, testBillete.darAño());
            Assert.AreEqual("123", testBillete.darIDO());
            Assert.AreEqual(1000, testBillete.darDenominacion());
            Assert.AreEqual("COP", testBillete.darDivisa());
            Assert.IsNotNull(testBillete.darAlcancia());
            #endregion
            }
        [TestMethod]
        public void uTestPonerMesMayor12()
            {
            #region Configurar
            testBillete = new clsBillete();
            testBillete.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsFalse(testBillete.ponerMes(13));
            Assert.AreEqual(4, testBillete.darDia());
            Assert.AreEqual(11, testBillete.darMes());
            Assert.AreEqual(1990, testBillete.darAño());
            Assert.AreEqual("123", testBillete.darIDO());
            Assert.AreEqual(1000, testBillete.darDenominacion());
            Assert.AreEqual("COP", testBillete.darDivisa());
            Assert.IsNotNull(testBillete.darAlcancia());
            #endregion
            }
        [TestMethod]
        public void uTestPonerDia()
            {
            #region Configurar
            testBillete = new clsBillete();
            testBillete.generar();
            #endregion
            #region Probar y Comprobar
            Assert.IsTrue(testBillete.ponerDia(5));
            Assert.AreEqual(5, testBillete.darDia());
            Assert.AreEqual(11, testBillete.darMes());
            Assert.AreEqual(1990, testBillete.darAño());
            Assert.AreEqual("123", testBillete.darIDO());
            Assert.AreEqual(1000, testBillete.darDenominacion());
            Assert.AreEqual("COP", testBillete.darDivisa());
            Assert.IsNotNull(testBillete.darAlcancia());
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
            testBillete = new clsBillete("123", "COP",1000, 1993,11,4);
            Assert.AreEqual("123", testBillete.darIDO());
            Assert.AreEqual("COP", testBillete.darDivisa());
            Assert.AreEqual(1000, testBillete.darDenominacion());
            Assert.AreEqual(1993, testBillete.darAño());
            Assert.AreEqual(11, testBillete.darMes());
            Assert.AreEqual(4, testBillete.darDia());
            #endregion
            }
        #endregion
        }
    }
