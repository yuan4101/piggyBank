namespace appAlcancia.Dominio
{
    public class clsBillete : clsMoneda
    {
        #region Atributos
        #region Propios
        private string atrSerial = "-1";
        private int atrMes = -1;
        private int atrDia = -1;
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        public new void generar()
        {
            atrAño = 1973;
            atrMes = 11;
            atrDia = 4;
            atrDenominacion = 5000;
            atrSerial = "QWERTY123";
        }
        #endregion
        #region Constructores
        public clsBillete() { }
        public clsBillete(string prmSerial, int prmDenominacion, int prmDia, int prmMes, int prmAño) : base(prmDenominacion, prmAño)
        {
            atrMes = prmMes;
            atrDia = prmDia;
            atrSerial = prmSerial;
        }
        #endregion
        #region Accesores
        public int darMes()
        {
            return atrMes;
        }
        public int darDia()
        {
            return atrDia;
        }
        public string darSerial()
        {
            return atrSerial;
        }
        #endregion
        #region Disociadores
        public new clsPersona disociarPropietario()
        {
            clsPersona auxObjPropietario = atrPropietario;
            if (atrPropietario == null)
                return atrPropietario;
            auxObjPropietario.disociarBilleteCon(this);
            atrPropietario = null;
            return auxObjPropietario;
        }
        public new clsAlcancia disociarAlcancia()
        {
            if (atrAlcancia == null)
                return atrAlcancia;
            clsAlcancia auxObjAlcancia = atrAlcancia;
            atrAlcancia.disociarBilleteCon(this);
            atrAlcancia = null;
            return auxObjAlcancia;
        }
        #endregion
        #region Destructor
        public new clsBillete destruir()
        {
            disociarAlcancia();
            disociarPropietario();
            return this;
        }
        #endregion
        #endregion
    }
}