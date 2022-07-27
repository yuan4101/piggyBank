using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKCommonAppAlcanciaX
{
    public interface IDivisaPluging
    {
        void setValores();
        float CalcularSaldoDivisaMonedas(int prmSaldoMonedas);
        float CalcularSaldoDivisaBilletes(int prmSaldoBilletes);
        float CalcularSaldoTotal(int prmSaldoTotal);
        string getDivisa();
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class CInfoPlugIn : System.Attribute
    {
        private string atrDivisa;
        private int atrTRM;

        public string AtrDivisa { get { return atrDivisa; } set { atrDivisa = value; } }
        public int AtrTRM { get { return atrTRM; } set { atrTRM = value; } }

        public string getDivisa()
        {
            return atrDivisa;
        }
    }
}