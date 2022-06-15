using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server_AppAlcancia
{
    class clsServer
    {
        IPHostEntry atrHost;
        IPAddress atrIpAdrres;
        IPEndPoint atrEndPoint;

        Socket atrSocket_Server;
        Socket atrSocket_Client;

        public clsServer(string prmIp, int prmPort)
        {
            atrHost = Dns.GetHostEntry(prmIp);
            atrIpAdrres = atrHost.AddressList[0];
            atrEndPoint = new IPEndPoint(atrIpAdrres, prmPort);
        
            atrSocket_Server = new Socket(atrIpAdrres.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            atrSocket_Server.Bind(atrEndPoint);
            atrSocket_Server.Listen(10);
        }

        public void Start() 
        {
            byte[] varBuffer;

            string varUser;
            string varPassword;

            Console.WriteLine("Esperando conexion... ");
            atrSocket_Client = atrSocket_Server.Accept();

            try
            {
                while (true)
                {
                    varBuffer = new byte[1024];
                    atrSocket_Client.Receive(varBuffer);
                    varUser = byteToString(varBuffer);

                    varBuffer = new byte[1024];
                    atrSocket_Client.Receive(varBuffer);
                    varPassword = byteToString(varBuffer);

                    if (varUser == "admin" && varPassword == "admin")
                    {
                        byte[] varLoginResponse = Encoding.ASCII.GetBytes("1,Conexion establecida con exito.");
                        atrSocket_Client.Send(varLoginResponse);
                    }
                    else
                    {
                        byte[] varLoginResponse = Encoding.ASCII.GetBytes("0,La conexion fallo.");
                        atrSocket_Client.Send(varLoginResponse);
                    }
                    Console.WriteLine("Se ha conectado un usuario. \n");
                }
            }
            catch (SocketException SocketE)
            {
                Console.WriteLine("Se ha desconectado el cliente: " + SocketE.Message);
            }
        }

        public string byteToString(byte[] prmBuffer) 
        {
            string varMensaje;
            int varEndIndex;

            varMensaje = Encoding.ASCII.GetString(prmBuffer);
            varEndIndex = varMensaje.IndexOf('\0');
            if (varEndIndex > 0)
                varMensaje = varMensaje.Substring(0, varEndIndex);
            
            return varMensaje;
        } 
    }
}
