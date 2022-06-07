using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public static class clsParametrizador
    {
        private static List<int> atrRangoAño = new List<int>() { 1990, 2022 };
        private static List<int> atrRangoMes = new List<int>() { 1, 12 };
        private static List<int> atrRangoDia = new List<int>() { 1, 31 };
        private static List<int> atrRangoDenominacion = new List<int>() { 1, 1000000 };
        private static List<int> atrRangoCapMonedas = new List<int>() { 1, 1000000 };
        private static List<int> atrRangoCapBillete = new List<int>() { 1, 1000000 };

        public static bool esValidoMes(int prmValor) 
        {
            if (prmValor >= atrRangoMes[0] && prmValor <= atrRangoMes[1])
                return true;
            return false;
        }
        public static bool esValidoDia(int prmValor)
        {
            if (prmValor >= atrRangoDia[0] && prmValor <= atrRangoDia[1])
                return true;
            return false;
        }
        public static bool esValidoAno(int prmValor)
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
