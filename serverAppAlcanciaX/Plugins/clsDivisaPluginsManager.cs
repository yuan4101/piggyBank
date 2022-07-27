using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MKCommonAppAlcanciaX;

namespace appAlcanciaX.Server.Plugins
{
    public static class clsDivisaPluginsManager
    {
        public static List<IDivisaPluging> leerExtensiones() 
        {
            var ListPlugins = new List<IDivisaPluging>();
            //Lee el DLL del directorio
            var varFiles = Directory.GetFiles("Extensiones", "*.dll");
            // Lee el DLL
            foreach (var varFile in varFiles)
            {
                var varAssembly = Assembly.LoadFile(Path.Combine(Directory.GetCurrentDirectory(), varFile));
                // Extrae todos los tipos de  que implementa IDivisaPluging
                var varDivisaPlugingType = varAssembly.GetTypes().Where(type => typeof(IDivisaPluging).IsAssignableFrom(type) && !type.IsInterface).ToArray();

                foreach (var varPluginType in varDivisaPlugingType)
                {
                    // Crea una intacia del tipo extraido
                    var varPluginIntance = Activator.CreateInstance(varPluginType) as IDivisaPluging;
                    ListPlugins.Add(varPluginIntance);
                }
            }
            return ListPlugins;
        }
    }
}
