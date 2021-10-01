namespace appAlcancia.Dominio
{
    public class clsMoneda
    {
        #region Atributos
        #region Propios
        protected int atrDenominacion = -1;
        protected int atrAño = -1;
        #endregion
        #region Asociativos
        protected clsPersona atrPropietario = null;
        protected clsAlcancia atrAlcancia = null;
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        public void generar()
        {
            atrDenominacion = 500;
            atrAño = 1984;
            atrAlcancia = new clsAlcancia();
            atrPropietario = new clsPersona();
        }
        #endregion
        #region Constructores
        public clsMoneda() { }
        public clsMoneda(int prmDenominacion, int prmAño)
        {
            atrDenominacion = prmDenominacion;
            atrAño = prmAño;
        }
        #endregion
        #region Accesores
        public int darDenominacion()
        {
            return atrDenominacion;
        }
        public int darAño()
        {
            return atrAño;
        }
        public clsPersona darPropietario()
        {
            return atrPropietario;
        }
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
        }
        #endregion
        #region Asociadores
        public bool asociarPropietarioCon(clsPersona prmObjeto)
        {
            if (atrPropietario != null)
                return false;
            atrPropietario = prmObjeto;
            return true;
        }
        public bool asociarAlcanciaCon(clsAlcancia prmObjeto)
        {
            if (atrAlcancia != null)
                return false;
            atrAlcancia = prmObjeto;
            return true;
        }
        #endregion
        #region Disociadores
        public clsPersona disociarPropietario()
        {
            if (atrPropietario == null)
                return atrPropietario;
            clsPersona auxObjPropietario = atrPropietario;
            auxObjPropietario.disociarMonedaCon(this);
            atrPropietario = null;
            return auxObjPropietario;
        }
        public clsAlcancia disociarAlcancia()
        {
            if (atrAlcancia == null)
                return atrAlcancia;
            clsAlcancia auxObjAlcancia = atrAlcancia;
            atrAlcancia.disociarMonedaCon(this);
            atrAlcancia = null;
            return auxObjAlcancia;
        }
        #endregion
        #region Destructor
        public clsMoneda destruir()
        {
            disociarAlcancia();
            disociarPropietario();
            return this;
        }
        #endregion
        #endregion
    }
}