using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace winAlcanciaX.Client
{
    class clsClient
    {
        IPHostEntry atrHost;
        IPAddress atrIpAdrres;
        IPEndPoint atrEndPoint;

        Socket atrSocket_Client;

        public clsClient(string prmIp, int prmPort)
        {
            atrHost = Dns.GetHostEntry(prmIp);
            atrIpAdrres = atrHost.AddressList[0];
            atrEndPoint = new IPEndPoint(atrIpAdrres, prmPort);

            atrSocket_Client = new Socket(atrIpAdrres.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            atrSocket_Client.Connect(atrEndPoint);
        }

        //Envia mensaje al servidor
        public void Send(String prmMensaje) 
        {
            byte[] varByteMensaje = Encoding.ASCII.GetBytes(prmMensaje);
            atrSocket_Client.Send(varByteMensaje);
        }

        public string Receive() 
        {
            byte[] varBuffer = new byte[1024];
            atrSocket_Client.Receive(varBuffer);
            return byteToString(varBuffer);
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
