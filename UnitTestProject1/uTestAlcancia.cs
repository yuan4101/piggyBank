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

        public void poblarColeccionesEspejo() 
        {
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
        }

        #region Test Accesores
        #endregion
        #region Test Mutadores
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
            Assert.IsTrue(testMonedas.Equals(testAlcancia.darMonedas()));
            //CollectionAssert.AreEqual(testMonedas, testAlcancia.darMonedas().);
            #endregion
        }
        #endregion
        #region Test Constructores

        #endregion
    }
}
