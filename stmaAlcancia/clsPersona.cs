using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsPersona
    {
        #region Atributos
        #region Propios
        private int atrOID = -1;
        private string atrNombre = "n.n";
        #endregion
        #region Asociativos
        public List<clsMoneda> atrMonedas = new List<clsMoneda>();
        public List<clsBillete> atrBilletes = new List<clsBillete>();
        public clsAlcancia atrAlcancia = null;
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        public void generar()
        {
            atrNombre = "Jorge Jair";
            atrOID = 901908;
            atrAlcancia = new clsAlcancia();

            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda(50, 1990));
            atrMonedas.Add(new clsMoneda(100, 1995));
            atrMonedas.Add(new clsMoneda(500, 2000));
            atrMonedas.Add(new clsMoneda(100, 2000));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete("5", 5000, 1, 12, 1996));
            atrBilletes.Add(new clsBillete("7", 5000, 1, 12, 1996));
            atrBilletes.Add(new clsBillete("4", 10000, 1, 12, 2000));
            atrBilletes.Add(new clsBillete("1", 20000, 6, 5, 2007));
        }
        #endregion
        #region Constructores
        public clsPersona() { }
        public clsPersona(int prmOID, string prmNombre)
        {
            atrOID = prmOID;
            atrNombre = prmNombre;
        }
        #endregion
        #region Accesores
        public int darOID()
        {
            return atrOID;
        }
        public string darNombre()
        {
            return atrNombre;
        }
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
        }
        public List<clsMoneda> darMonedas()
        {
            return atrMonedas;
        }
        public List<clsBillete> darBilletes()
        {
            return atrBilletes;
        }
        #endregion
        #region Mutadores
        public bool ponerNombre(string prmValor)
        {
            atrNombre = prmValor;
            return true;
        }
        #endregion
        #region Recuperadores
        public clsMoneda recuperarMonedaCon(int prmDenominacion)
        {
            foreach (clsMoneda varObjeto in atrMonedas)
                if (varObjeto.darDenominacion() == prmDenominacion)
                    return varObjeto;
            return null;
        }
        public clsBillete recuperarBilleteCon(int prmDenominacion)
        {
            foreach (clsBillete varObjeto in atrBilletes)
                if (varObjeto.darDenominacion() == prmDenominacion)
                    return varObjeto;
            return null;
        }
        #endregion
        #region Asociadores
        public bool asociarAlcanciaCon(clsAlcancia prmObjeto)
        {
            if (atrAlcancia != null)
                return false;
            atrAlcancia = prmObjeto;
            return true;
        }
        public bool asociarMonedaCon(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        public bool asociarBilleteCon(clsBillete prmObjeto)
        {
            atrBilletes.Add(prmObjeto);
            return true;
        }
        #endregion
        #region Disociadores
        public clsAlcancia disociarAlcancia()
        {
            if (atrAlcancia == null)
                return atrAlcancia;
            clsAlcancia auxObjAlcancia = atrAlcancia;
            atrAlcancia.disociarAhorradorCon(this);
            atrAlcancia = null;
            return auxObjAlcancia;
        }
        public clsMoneda disociarMonedaCon(int prmDenominacion)
        {
            clsMoneda auxObjMoneda = recuperarMonedaCon(prmDenominacion);
            if (auxObjMoneda != null)
                auxObjMoneda.disociarPropietario();
            return auxObjMoneda;
        }
        public bool disociarMonedaCon(clsMoneda prmObjeto)
        {
            return atrMonedas.Remove(prmObjeto);
        }
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            clsBillete auxObjBillete = recuperarBilleteCon(prmDenominacion);
            if (auxObjBillete != null)
                auxObjBillete.disociarPropietario();
            return auxObjBillete;
        }
        public bool disociarBilleteCon(clsBillete prmObjeto)
        {
            return atrBilletes.Remove(prmObjeto);
        }
        public List<clsMoneda> disociarMonedas()
        {
            List<clsMoneda> varMonedasDevueltas = new List<clsMoneda>();
            for (int varIndice = 0; varIndice < atrMonedas.Count;)
            {
                varMonedasDevueltas.Add(atrMonedas[varIndice]);
                if (atrMonedas[varIndice].darPropietario() == null)
                    atrMonedas.Remove(atrMonedas[varIndice]);
                atrMonedas[varIndice].disociarPropietario();
            }
            return varMonedasDevueltas;
        }
        public List<clsBillete> disociarBilletes()
        {
            List<clsBillete> varBilletesDevueltos = new List<clsBillete>();
            for (int varIndice = 0; varIndice < atrBilletes.Count;)
            {
                varBilletesDevueltos.Add(atrBilletes[varIndice]);
                if (atrBilletes[varIndice].darPropietario() == null)
                    atrBilletes.Remove(atrBilletes[varIndice]);
                atrBilletes[varIndice].disociarPropietario();
            }
            return varBilletesDevueltos;
        }
        #endregion
        #region Destructor
        public clsPersona destruir()
        {
            disociarAlcancia();
            disociarMonedas();
            disociarBilletes();
            return this;
        }
        #endregion
        #endregion
    }
}