using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsSistema
    {
        #region Atributos
        #region Singleton
        private static clsSistema atrInstancia;
        #endregion
        #region Asociativos
        private List<clsAlcancia> atrAlcancias = new List<clsAlcancia>();
        private List<clsUsuario> atrUsuarios = new List<clsUsuario>();
        private List<clsMoneda> atrMonedas = new List<clsMoneda>();
        private List<clsBillete> atrBilletes = new List<clsBillete>();
        #endregion
        #endregion
        #region Operaciones
        #region Singleton
        public static clsSistema darInstancia()
        {
            if (atrInstancia == null)
                return atrInstancia = new clsSistema();
            return atrInstancia;
        }
        #endregion
        #region Accesores
        public List<clsAlcancia> darAlcancias() 
        {
            return atrAlcancias;
        }
        #endregion
        #region CRUDS
        #region Registrador
        public bool registrarUsuario(string prmIDO, string prmNombre, string prmUsuario, string prmContraseña)
        {
            atrUsuarios.Add(new clsUsuario(prmIDO, prmNombre, prmUsuario, prmContraseña));
            return true;
        }
        public bool registrarAlcancia(string prmIDO, string prmDivisa, int prmCapMonedas, int prmCapBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            atrAlcancias.Add(new clsAlcancia(prmIDO, prmDivisa, prmCapMonedas, prmCapBilletes, prmDenMonedas, prmDenBilletes));
            return true;
        }
        public bool registrarMoneda(clsUsuario prmOwner, string prmIDO, string prmDivisa, int prmDenominacion, int prmAño)
        {
            clsMoneda varMoneda = new clsMoneda(prmOwner, prmIDO, prmDivisa, prmDenominacion, prmAño);
            if (prmOwner != null)
                prmOwner.agregarMoneda(varMoneda);
            atrMonedas.Add(varMoneda);
            return true;
        }
        public bool registrarBillete(clsUsuario prmOwner, string prmSerial, string prmDivisa, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            clsBillete varBillete = new clsBillete(prmOwner, prmSerial, prmDivisa, prmDenominacion, prmAño, prmMes, prmDia);
            if (prmOwner != null)
                prmOwner.agregarBillete(varBillete);
            atrBilletes.Add(varBillete);
            return true;
        }
        #endregion
        #region Actualizador
        public bool actualizarAlcancia(string prmDivisa, int prmCapMonedas, int prmCapBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            throw new NotImplementedException();
        }
        public bool actualizarMoneda(string prmIDO, int prmDenominacion, int prmAño)
        {
            throw new NotImplementedException();
        }
        public bool actualizarBillete(string prmSerial, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Eliminador
        public bool eliminarAlcancia()
        {
            throw new NotImplementedException();
        }
        public bool eliminarMoneda(string prmIDO)
        {
            throw new NotImplementedException();
        }
        public bool eliminarBillete(string prmSerial)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
        #region Transacciones
        public bool consignarMoneda(string prmIDO)
        {
            throw new NotImplementedException();
        }
        public bool consignarBillete(string prmSerial)
        {
            throw new NotImplementedException();
        }
        public bool retirarMoneda(string prmIDO)
        {
            throw new NotImplementedException();
        }
        public bool retirarBillete(string prmSerial)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Validaciones
        public clsUsuario login(string prmUsuario, string prmContraseña)
        {
            foreach (clsUsuario varUsuario in atrUsuarios)
            {
                if (varUsuario.validarCredenciales(prmUsuario, prmContraseña))
                    return varUsuario;
            }
            return null;
        }
        public clsAlcancia buscarAlcancia(string prmIDO)
        {
            foreach (clsAlcancia varAlcancia in atrAlcancias)
            {
                if (varAlcancia.darIDO() == prmIDO)
                    return varAlcancia;
            }
            return null;
        }
        public clsMoneda buscarMoneda(string prmIDO)
        {
            foreach (clsMoneda varMoneda in atrMonedas)
            {
                if (varMoneda.darIDO() == prmIDO)
                    return varMoneda;
            }
            return null;
        }
        public clsBillete buscarBillete(string prmSerial)
        {
            foreach (clsBillete varBillete in atrBilletes)
            {
                if (varBillete.darIDO() == prmSerial)
                    return varBillete;
            }
            return null;
        }
        #endregion
        #region Testing
        public void generar()
        {
            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda(null, "0", "COP", 100, 1992));
            atrMonedas.Add(new clsMoneda(null, "1", "COP", 500, 1998));
            atrMonedas.Add(new clsMoneda(null, "5", "COP", 200, 1984));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete(null, "ABC123", "COP", 1000, 1992, 2, 20));
            atrBilletes.Add(new clsBillete(null, "CDF456", "COP", 500, 1992, 2, 20));
            atrBilletes.Add(new clsBillete(null, "ABC789", "COP", 100000, 2020, 3, 13));

            atrAlcancias = new List<clsAlcancia>();
            atrAlcancias.Add(new clsAlcancia("1", "COP", 10, 12, new List<int> { 100, 500 }, new List<int> { 500, 1000 }));

            atrAlcancias[0].darMonedas().Add(atrMonedas[0]);
            atrAlcancias[0].darMonedas().Add(atrMonedas[1]);
            atrAlcancias[0].darBilletes().Add(atrBilletes[0]);
            atrAlcancias[0].darBilletes().Add(atrBilletes[1]);

            atrAlcancias[0].calcularEstadoCuenta();
        }
        #endregion
        #endregion
    }
}