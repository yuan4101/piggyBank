using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsAlcancia
    {
        #region Atributos
        #region Propios
        public int atrCapacidadMonedas = -1;
        public int atrCapacidadBilletes = -1;
        public int atrCantidadDenominacionMonedas = -1;
        public int atrCantidadDenominacionBilletes = -1;
        #endregion
        #region Asociativos
        public List<clsBillete> atrBilletes = new List<clsBillete>();
        public List<clsPersona> atrAhorradores = new List<clsPersona>();
        public List<clsMoneda> atrMonedas = new List<clsMoneda>();
        public List<int> atrDenominacionesMoneda = new List<int>();
        public List<int> atrDenominacionesBillete = new List<int>();
        #endregion
        #endregion
        #region Metodos
        #region Utiliatario
        public void generar()
        {
            atrCapacidadMonedas = 20;
            atrCapacidadBilletes = 10;

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

            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona(1, "Fulanito"));
            atrAhorradores.Add(new clsPersona(2, "Menganito"));
            atrAhorradores.Add(new clsPersona(5, "Diana"));
        }
        #endregion
        #region Constructores
        public clsAlcancia() { }
        public clsAlcancia(int prmCapacidadMonedas, int prmCapacidadBilletes)
        {
            atrCapacidadMonedas = prmCapacidadMonedas;
            atrCapacidadBilletes = prmCapacidadBilletes;
        }
        #endregion
        #region Accesores
        public int darCapacidadMonedas()
        {
            return atrCapacidadMonedas;
        }
        public int darCapacidadBilletes()
        {
            return atrCapacidadBilletes;
        }
        public List<clsPersona> darAhorradores()
        {
            return atrAhorradores;
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
        #region Recuperadores
        public clsPersona recuperarAhorradorCon(int prmOID)
        {
            foreach (clsPersona varObjeto in atrAhorradores)
                if (varObjeto.darOID() == prmOID)
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
        public clsMoneda recuperarMonedaCon(int prmDenominacion)
        {
            foreach (clsMoneda varObjeto in atrMonedas)
                if (varObjeto.darDenominacion() == prmDenominacion)
                    return varObjeto;
            return null;
        }
        #endregion
        #region Asociadores
        public bool asociarMonedaCon(clsMoneda prmObjeto)
        {
            if (atrMonedas.Count >= atrCapacidadMonedas)
                return false;
            atrMonedas.Add(prmObjeto);
            return true;
        }
        public bool asociarBilleteCon(clsBillete prmObjeto)
        {
            if (atrBilletes.Count >= atrCapacidadBilletes)
                return false;
            atrBilletes.Add(prmObjeto);
            return true;
        }
        public bool asociarAhorradorCon(clsPersona prmObjeto)
        {
            if (recuperarAhorradorCon(prmObjeto.darOID()) != null)
                return false;
            atrAhorradores.Add(prmObjeto);
            return true;
        }
        #endregion
        #region Disociadores
        public clsPersona disociarAhorradorCon(int prmOID)
        {
            clsPersona auxObjAhorrador = recuperarAhorradorCon(prmOID);
            atrAhorradores.Remove(auxObjAhorrador);
            if (auxObjAhorrador != null)
                auxObjAhorrador.disociarAlcancia();
            return auxObjAhorrador;
        }
        public bool disociarAhorradorCon(clsPersona prmObjeto)
        {
            disociarMonedasDe(prmObjeto);
            disociarBilletesDe(prmObjeto);
            return atrAhorradores.Remove(prmObjeto);
        }
        public List<clsPersona> disociarAhorradores()
        {
            List<clsPersona> varAhorradoresDisociados = new List<clsPersona>();
            for (int varIndice = 0; varIndice < atrAhorradores.Count;)
            {
                varAhorradoresDisociados.Add(atrAhorradores[varIndice]);
                atrAhorradores[varIndice].disociarAlcancia();
            }
            return varAhorradoresDisociados;
        }
        public clsMoneda disociarMonedaCon(int prmDenominacion)
        {
            clsMoneda auxObjMoneda = recuperarMonedaCon(prmDenominacion);
            atrMonedas.Remove(auxObjMoneda);
            if (auxObjMoneda != null)
                auxObjMoneda.disociarAlcancia();
            return auxObjMoneda;
        }
        public bool disociarMonedaCon(clsMoneda prmObjeto)
        {
            return atrMonedas.Remove(prmObjeto);
        }
        public List<clsMoneda> disociarMonedasDe(clsPersona prmObjeto)
        {
            List<clsMoneda> varMonedasDevueltas = new List<clsMoneda>();
            for (int varIndice = 0; varIndice < atrMonedas.Count;)
            {
                if (atrMonedas[varIndice].darPropietario() == prmObjeto)
                {
                    varMonedasDevueltas.Add(atrMonedas[varIndice]);
                    atrMonedas[varIndice].disociarAlcancia();
                }
                else
                    varIndice++;
            }
            return varMonedasDevueltas;
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
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            clsBillete auxObjBillete = recuperarBilleteCon(prmDenominacion);
            atrBilletes.Remove(auxObjBillete);
            if (auxObjBillete != null)
                auxObjBillete.disociarAlcancia();
            return auxObjBillete;
        }
        public bool disociarBilleteCon(clsBillete prmObjeto)
        {
            return atrBilletes.Remove(prmObjeto);
        }
        public List<clsBillete> disociarBilletesDe(clsPersona prmObjeto)
        {
            List<clsBillete> varBilletesDevueltos = new List<clsBillete>();
            for (int varIndice = 0; varIndice < atrBilletes.Count;)
            {
                if (atrBilletes[varIndice].darPropietario() == prmObjeto)
                {
                    varBilletesDevueltos.Add(atrBilletes[varIndice]);
                    atrBilletes[varIndice].disociarAlcancia();
                }
                else
                    varIndice++;
            }
            return varBilletesDevueltos;
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
        public clsAlcancia destruir()
        {
            disociarAhorradores();
            disociarBilletes();
            disociarMonedas();
            return this;
        }
        #endregion
        #endregion
    }
}