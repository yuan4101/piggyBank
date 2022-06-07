using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using appAlcancia.Dominio;

namespace appAlcancia.Servicios.Pruebas
{
    [TestClass]
    public class uTestBillete
    {
        private clsBillete testBillete;

        #region Test Accesores
        #endregion
        #region Test Mutadores
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
        #endregion
        #region Test Constructores

        #endregion
    }
}
