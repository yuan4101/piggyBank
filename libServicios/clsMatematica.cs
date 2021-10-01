using System;

namespace libServices
{
    public class clsMatematica : clsMensajero
    {
        public static Tipo ConvertirATipo<Tipo>(object prmDato)
        {
            try { return (Tipo)Convert.ChangeType(prmDato, typeof(Tipo)); }
            catch (Exception e)
            {
                atrMensaje = "ERROR: No fue posible la conversion debido a: " + e.Message;
                return default(Tipo);
            }
        }
        public static Tipo Sumar<Tipo>(Tipo prmOperando1, Tipo prmOperando2)
        {
            atrMensaje = null;
            if (typeof(byte).Equals(typeof(Tipo)))
                if ((ConvertirATipo<double>(prmOperando1) + ConvertirATipo<double>(prmOperando2)) > byte.MaxValue)
                {
                    atrMensaje = "ERROR: El resultado esta fuera del limite";
                    clsConsola.EscribirEncabezado(atrMensaje);
                    return default(Tipo);
                }
            return ConvertirATipo<Tipo>(ConvertirATipo<double>(prmOperando1) + ConvertirATipo<double>(prmOperando2));
        }
        public static Tipo Restar<Tipo>(Tipo prmOperando1, Tipo prmOperando2)
        {
            atrMensaje = null;
            if (typeof(byte).Equals(typeof(Tipo)))
                if ((ConvertirATipo<double>(prmOperando1) - ConvertirATipo<double>(prmOperando2)) < byte.MinValue)
                {
                    atrMensaje = "ERROR: El resultado esta fuera del limite";
                    clsConsola.EscribirEncabezado(atrMensaje);
                    return default(Tipo);
                }
            return ConvertirATipo<Tipo>(ConvertirATipo<double>(prmOperando1) - ConvertirATipo<double>(prmOperando2));
        }
        public static Tipo Multiplicar<Tipo>(Tipo prmOperando1, Tipo prmOperando2)
        {
            atrMensaje = null;
            if (typeof(byte).Equals(typeof(Tipo)))
                if ((ConvertirATipo<double>(prmOperando1) * ConvertirATipo<double>(prmOperando2)) > byte.MaxValue)
                {
                    atrMensaje = "ERROR: El resultado esta fuera del limite";
                    clsConsola.EscribirEncabezado(atrMensaje);
                    return default(Tipo);
                }
            return ConvertirATipo<Tipo>(ConvertirATipo<double>(prmOperando1) * ConvertirATipo<double>(prmOperando2));
        }
        public static Tipo Dividir<Tipo>(Tipo prmOperando1, Tipo prmOperando2) 
        {
            atrMensaje = null;
            if (ConvertirATipo<double>(prmOperando2) != 0)
                return ConvertirATipo<Tipo>(ConvertirATipo<double>(prmOperando1) / ConvertirATipo<double>(prmOperando2));
            atrMensaje = "El resultado de la division es indeterminado";
            clsConsola.EscribirEncabezado(atrMensaje);
            return default(Tipo);
        }
    }
}