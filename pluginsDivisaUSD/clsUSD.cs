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
        float varTRM;
        public void setValores()
        {
            AtrDivisa = "USD";
            AtrTRM = 4429;
            varTRM = AtrTRM;
        }
        public float CalcularSaldoDivisaBilletes(int prmSaldoBilletes)
        {
            return prmSaldoBilletes / varTRM;
        }
        public float CalcularSaldoDivisaMonedas(int prmSaldoMonedas)
        {
            return prmSaldoMonedas / varTRM;
        }
        public float CalcularSaldoTotal(int prmSaldoTotal)
        {
            return prmSaldoTotal / varTRM;
        }
    }
}
