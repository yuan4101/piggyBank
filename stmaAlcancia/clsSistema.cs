using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsSistema
    {
        #region Atributos
        #region Asociativos
        public clsAlcancia atrAlcancia = null;
        public List<clsPersona> atrAhorradores = new List<clsPersona>();
        public List<clsMoneda> atrMonedas = new List<clsMoneda>();
        public List<clsBillete> atrBilletes = new List<clsBillete>();
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        /*
        public void generar()
        {
            atrAlcancia = new clsAlcancia(10, 10);

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

            //atrAhorradores[2].darBilletes().Add(atrBilletes[0]);
            //atrAhorradores[2].darBilletes().Add(atrBilletes[1]);

            atrAhorradores[2].asociarAlcanciaCon(atrAlcancia);
            atrAlcancia.asociarAhorradorCon(atrAhorradores[2]);

            atrAhorradores[2].asociarMonedaCon(atrMonedas[0]);
            atrAhorradores[2].asociarMonedaCon(atrMonedas[3]);
            atrAhorradores[2].asociarBilleteCon(atrBilletes[0]);
            atrAhorradores[2].asociarBilleteCon(atrBilletes[2]);

            atrMonedas[0].asociarPropietarioCon(atrAhorradores[2]);
            atrMonedas[3].asociarPropietarioCon(atrAhorradores[2]);
            atrBilletes[0].asociarPropietarioCon(atrAhorradores[2]);
            atrBilletes[2].asociarPropietarioCon(atrAhorradores[2]);

            atrAlcancia.asociarMonedaCon(atrMonedas[0]);
            atrAlcancia.asociarMonedaCon(atrMonedas[3]);
            atrAlcancia.asociarBilleteCon(atrBilletes[0]);
            atrAlcancia.asociarBilleteCon(atrBilletes[2]);

            atrMonedas[0].asociarAlcanciaCon(atrAlcancia);
            atrMonedas[3].asociarAlcanciaCon(atrAlcancia);
            atrBilletes[0].asociarAlcanciaCon(atrAlcancia);
            atrBilletes[2].asociarAlcanciaCon(atrAlcancia);
        }*/
        #endregion
        #region Patron Singleton
        private static clsSistema Instancia;
        private clsSistema() { }
        public static clsSistema getInstancia()
        {
            if (Instancia == null)
                Instancia = new clsSistema();
            return Instancia;
        }
        #endregion
        #region Accesores
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
        }
        public List<clsMoneda> darMonedas()
        {
            return atrMonedas;
        }
        public List<clsPersona> darAhorradores()
        {
            return atrAhorradores;
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
        public clsBillete recuperarBilleteCon(string prmSerial)
        {
            foreach (clsBillete varObjeto in atrBilletes)
                if (varObjeto.darSerial() == prmSerial)
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
        public bool asociarAhorradorCon(clsPersona prmObjeto)
        {
            if (recuperarAhorradorCon(prmObjeto.darOID()) != null)
                return false;
            atrAhorradores.Add(prmObjeto);
            return true;
        }
        public bool asociarMonedaCon(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        public bool asociarBilleteCon(clsBillete prmObjeto)
        {
            if (recuperarBilleteCon(prmObjeto.darSerial()) != null)
                return false;
            atrBilletes.Add(prmObjeto);
            return true;
        }
        #endregion
        #region Disociadores
        public clsPersona disociarAhorradorCon(int prmOID)
        {
            clsPersona auxObjAhorrador = recuperarAhorradorCon(prmOID);
            if (auxObjAhorrador == null)
                return auxObjAhorrador;
            atrAhorradores.Remove(auxObjAhorrador);
            return auxObjAhorrador;
        }
        public clsAlcancia disociarAlcancia()
        {
            clsAlcancia auxObjAlcancia = atrAlcancia;
            atrAlcancia = null;
            return auxObjAlcancia;
        }
        public clsMoneda disociarMonedaCon(int prmDenominacion)
        {
            clsMoneda auxObjMoneda = recuperarMonedaCon(prmDenominacion);
            atrMonedas.Remove(auxObjMoneda);
            return auxObjMoneda;
        }
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            clsBillete auxObjBillete = recuperarBilleteCon(prmDenominacion);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }
        public clsBillete disociarBilleteCon(string prmSerial)
        {
            clsBillete auxObjBillete = recuperarBilleteCon(prmSerial);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }
        #endregion
        #region CRUD
        #region Registradores
        public bool registrarAlcanciaCon(int prmCapacidadMonedas, int prmCapacidadBilletes)
        {
            return asociarAlcanciaCon(new clsAlcancia(prmCapacidadMonedas, prmCapacidadBilletes));
        }
        public bool registrarAhorradorCon(int prmOID, string prmNombre)
        {
            return asociarAhorradorCon(new clsPersona(prmOID, prmNombre));
        }
        public bool registrarMonedaCon(int prmDenominacion, int prmAño)
        {
            return asociarMonedaCon(new clsMoneda(prmDenominacion, prmAño));
        }
        public bool registrarBilleteCon(string prmSerial, int prmDenominacion, int prmDia, int prmMes, int prmAño)
        {
            return asociarBilleteCon(new clsBillete(prmSerial, prmDenominacion, prmDia, prmMes, prmAño));
        }
        #endregion
        #region Actualizadores
        public bool actualizarAhorradorCon(int prmOID, string prmNombre)
        {
            return recuperarAhorradorCon(prmOID).ponerNombre(prmNombre);
        }
        #endregion
        #region Eliminadores
        public clsAlcancia eliminarAlcancia()
        {
            clsAlcancia auxObjAlcancia = disociarAlcancia();
            if (auxObjAlcancia != null)
                return auxObjAlcancia.destruir(); 
            return null;
        }
        public clsPersona eliminarAhorradorCon(int prmOID)
        {
            clsPersona auxObjAhorrador = disociarAhorradorCon(prmOID);
            if (auxObjAhorrador != null)
                return auxObjAhorrador.destruir();
            return null;
        }
        public clsMoneda eliminarMonedaCon(int prmDenominacion)
        {
            clsMoneda auxObjMoneda = disociarMonedaCon(prmDenominacion);
            if (auxObjMoneda != null)
                return auxObjMoneda.destruir();
            return null;
        }
        public clsBillete eliminarBilleteCon(string prmSerial)
        {
            clsBillete auxObjBillete = disociarBilleteCon(prmSerial);
            if (auxObjBillete != null)
                return auxObjBillete.destruir();
            return null;
        }
        #endregion
        #endregion
        #endregion
    }
}