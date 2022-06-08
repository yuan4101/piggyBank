using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Servicios
{
    public static class clsParametrizador
    {
        private static List<int> atrRangoAño = new List<int>() { 1980, 2022 };
        private static List<int> atrRangoDenominacion = new List<int>() { 1, 100000 };
        private static List<int> atrRangoCapMonedas = new List<int>() { 1, 1000000 };
        private static List<int> atrRangoCapBillete = new List<int>() { 1, 1000000 };

        public static bool esValidoMes(int prmMes, int prmDia) 
        {
            if (prmMes >= 1 && prmMes <= 12)
            {
                if (prmDia >= 1 && prmDia <= 30)
                {
                    if (prmMes == 4 && prmMes == 6 && prmMes == 9 && prmMes == 11)
                        return true;
                    return false;
                }
                if (prmDia >= 1 && prmDia <= 28)
                {
                    if (prmMes == 2)
                        return true;
                    return false;
                }
                if (prmMes == 1 && prmMes == 3 && prmMes == 5 && prmMes == 7 && prmMes == 8 && prmMes == 10 && prmMes == 12)
                {
                    if (prmMes == 2)
                        return true;
                    return false;
                }
            }
            
            return false;
        }
        public static bool esValidoDia(int prmDia, int prmMes)
        {
            if (prmMes == 1 && prmMes == 3 && prmMes == 5 && prmMes == 7 && prmMes == 8 && prmMes == 10 && prmMes == 12)
            {
                if (prmDia >= 1 && prmDia <= 31)
                    return true;
                return false;
            }
            if (prmMes == 2)
            {
                if (prmDia >= 1 && prmDia <= 28)
                    return true;
                return false;
            }
            if (prmMes == 4 && prmMes == 6 && prmMes == 9 && prmMes == 11)
            {
                if (prmDia >= 1 && prmDia <= 30)
                    return true;
                return false;
            }
            return false;
        }
        public static bool esValidoAño(int prmValor)
        {
            if (prmValor >= atrRangoAño[0] && prmValor <= atrRangoAño[1])
                return true;
            return false;
        }
        public static bool esValidoRangoDenominacion(int prmValor)
        {
            if (prmValor >= atrRangoDenominacion[0] && prmValor <= atrRangoDenominacion[1])
                return true;
            return false;
        }
        public static bool esValidoRangoCapMonedas(int prmValor)
        {
            if (prmValor >= atrRangoCapMonedas[0] && prmValor <= atrRangoCapMonedas[1])
                return true;
            return false;
        }
        public static bool esValidoRangoCapBilletes(int prmValor)
        {
            if (prmValor >= atrRangoCapBillete[0] && prmValor <= atrRangoCapBillete[1])
                return true;
            return false;
        }
    }
}
