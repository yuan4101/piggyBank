using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace winAlcanciaX.Client
{
    public class clsClient
    {
        IPHostEntry atrHost;
        IPAddress atrIpAddress;
        IPEndPoint atrEndPoint;
        Socket atrSocketServer = null;
        private static clsClient atrClient = null;
        public static clsClient darInstancia()
        {
            if (atrClient == null)
                return atrClient = new clsClient("localhost", 6400);
            return atrClient;
        }
        public clsClient(string prmIp, int prmPort)
        {
            atrHost = Dns.GetHostEntry(prmIp);
            atrIpAddress = atrHost.AddressList[1];
            atrEndPoint = new IPEndPoint(atrIpAddress, prmPort);
        }
        public void connect()
        {
            if (atrSocketServer == null)
                atrSocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                atrSocketServer.Connect(atrEndPoint);
                Console.WriteLine("Successfully connected.\n");
            }
            catch (Exception)
            {
                Console.WriteLine("You're already connected.\n");
            }
        }
        public void disconnect()
        {
            try
            {
                atrSocketServer.Disconnect(false);
                atrSocketServer = null;
                Console.WriteLine("Successfully disconnected.\n");
            }
            catch (Exception)
            {
                Console.WriteLine("You're already disconnected.\n");
            }
        }
        public void Send(string prmData) 
        {
            if (atrSocketServer == null)
                return;
            byte[] varSendData = new byte[1024];
            varSendData = Encoding.Default.GetBytes(prmData);
            atrSocketServer.Send(varSendData);
            Console.WriteLine("Data sent.\n");
        }
        public string Receive() 
        {
            byte[] varDataReceived = new byte[1024];
            int varArraySize;
            varArraySize = atrSocketServer.Receive(varDataReceived, 0, varDataReceived.Length, 0);
            Array.Resize(ref varDataReceived, varArraySize);
            return Encoding.Default.GetString(varDataReceived);
        }
    }
}
