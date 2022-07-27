using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MKCommonAppAlcanciaX;

namespace pluginsDivisaUSD
{
    public class clsUSD : CInfoPlugIn, IDivisaPluging
    {
        public void setValues()
        {
            setDivisa("USD");
            setTRM(4429);
        }
        public void setValues(string prmDivisa, int prmTRM)
        {
            setDivisa(prmDivisa);
            setTRM(prmTRM);
        }
        public int CalcularSaldoDivisaBilletes(int prmSaldoBilletes)
        {
            return prmSaldoBilletes / getTRM();
        }
        public int CalcularSaldoDivisaMonedas(int prmSaldoMonedas)
        {
            return prmSaldoMonedas / getTRM();
        }
        public int CalcularSaldoTotal(int prmSaldoTotal)
        {
            return prmSaldoTotal / getTRM();
        }
    }
}
