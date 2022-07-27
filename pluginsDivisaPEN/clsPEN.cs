using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MKCommonAppAlcanciaX;

namespace pluginsDivisaPEN
{
    public class clsPEN : CInfoPlugIn, IDivisaPluging
    {
        float varTRM;
        public void setValores()
        {
            AtrDivisa = "PEN";
            AtrTRM = 1129;
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
