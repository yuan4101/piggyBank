using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKCommonAppAlcanciaX
{
    public interface IDivisaPluging
    {
        int CalcularSaldoDivisaMonedas(int prmSaldoMonedas);
        int CalcularSaldoDivisaBilletes(int prmSaldoBilletes);
        int CalcularSaldoTotal(int prmSaldoTotal);
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CIngoPlugIn : System.Attribute
    {
        private string atrDivisa;
        private int atrTRM;

        public string darDivisa() 
        {
            return atrDivisa;
        }
        public int darTRM() 
        {
            return atrTRM;
        }
    }
}
