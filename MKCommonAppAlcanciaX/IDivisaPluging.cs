using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKCommonAppAlcanciaX
{
    public interface IDivisaPluging
    {
        void setValues();
        void setValues(string prmDivisa, int prmTRM);
        int CalcularSaldoDivisaMonedas(int prmSaldoMonedas);
        int CalcularSaldoDivisaBilletes(int prmSaldoBilletes);
        int CalcularSaldoTotal(int prmSaldoTotal);
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class CInfoPlugIn : System.Attribute
    {
        private string atrDivisa;
        private int atrTRM;

        public void setDivisa(string prmDivisa)
        {
            atrDivisa = prmDivisa;
        }
        public void setTRM(int prmTRM)
        {
            atrTRM = prmTRM;
        }
        public string getDivisa() 
        {
            return atrDivisa;
        }
        public int getTRM() 
        {
            return atrTRM;
        }
    }
}
