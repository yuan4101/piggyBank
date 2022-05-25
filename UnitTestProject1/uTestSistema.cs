using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using appAlcancia.Dominio;
namespace appAlcancia.Servicios.Pruebas
{
    [TestClass]
    public class uTestSistema
    {
        private clsSistema testSistema = clsSistema.darInstancia();
        #region Singleton
        [TestMethod]
        public void testDarInstancia()
        {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            Assert.IsNotNull(clsSistema.darInstancia());
            Assert.AreEqual(typeof(clsSistema), clsSistema.darInstancia().GetType());
            #endregion
        }
        #endregion
        #region Test Accesores
        [TestMethod]
        public void testDarAlcancia()
        {
            #region Configurar
            testSistema = clsSistema.darInstancia();
            testSistema.generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, clsSistema.darInstancia());
            Assert.AreEqual(typeof(clsSistema), clsSistema.darInstancia().GetType());
            Assert.AreEqual(typeof(clsAlcancia), testSistema.darAlcancia().GetType());
            #endregion
        }
        #endregion
        /*
        [TestMethod]
        public void testRegistrarAlcancia()
        {
            #region Configurar

            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, clsSistema.darInstancia());
            Assert.AreEqual(typeof(clsSistema), clsSistema.darInstancia().GetType());

            #endregion

        }
        */
    }
}