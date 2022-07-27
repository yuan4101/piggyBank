﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MKCommonAppAlcanciaX;

namespace pluginsDivisaPEN
{
    public class clsPEN : CInfoPlugIn, IDivisaPluging
    {
        public void setValues()
        {
            setDivisa("PEN");
            setTRM(1129);
        }
        public void setValues(string prmDivisa, int prmTRM)
        {
            setDivisa(prmDivisa);
            setTRM(prmTRM);
        }
        public int CalcularSaldoDivisaBilletes(int prmSaldoBilletes)
        {
            setValues();
            return prmSaldoBilletes / getTRM();
        }
        public int CalcularSaldoDivisaMonedas(int prmSaldoMonedas)
        {
            setValues();
            return prmSaldoMonedas / getTRM();
        }
        public int CalcularSaldoTotal(int prmSaldoTotal)
        {
            setValues();
            return prmSaldoTotal / getTRM();
        }
    }
}