using System;
using appAlcanciaX.Server;

namespace appAlcanciaX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting server...");
            clsServer atrServer = new clsServer("localhost", 6400);
            atrServer.Start();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
