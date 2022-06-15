using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_AppAlcancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciado servidor...");
            clsServer atrServer = new clsServer("localhost", 4404);
            atrServer.Start();
            Console.ReadKey();
        }
    }
}
