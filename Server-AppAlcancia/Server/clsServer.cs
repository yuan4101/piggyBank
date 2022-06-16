using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using appAlcanciaX.Dominio;

namespace appAlcanciaX.Server
{
    class clsServer
    {
        IPHostEntry atrHost;
        IPAddress atrIpAddress;
        IPEndPoint atrEndPoint;
        Socket atrSocketServer;
        Socket atrSocketClient;

        bool flagConexion = false;
        bool flagServidor = true;
        clsUsuario varUsuario = null;

        public clsServer(string prmIp, int prmPort)
        {
            atrHost = Dns.GetHostEntry(prmIp);
            atrIpAddress = atrHost.AddressList[1];
            atrEndPoint = new IPEndPoint(atrIpAddress, prmPort);
            atrSocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            atrSocketServer.Bind(atrEndPoint);
            atrSocketServer.Listen(10);
        }
        public void Start() 
        {
            clsSistema.darInstancia().registrarUsuario("1", "Administrador", "admin", "password");
            while (flagServidor)
            {
                if (flagConexion)
                {
                    byte[] varDataReceived = new byte[1024];
                    string varData;
                    int varArraySize = atrSocketClient.Receive(varDataReceived, 0, varDataReceived.Length, 0);
                    Array.Resize(ref varDataReceived, varArraySize);
                    varData = toString(varDataReceived);

                    if (varData == "")
                    {
                        varUsuario = null;
                        flagConexion = false;
                        continue;
                    }

                    Console.WriteLine("Data: " + varData);
                    string[] varValues = varData.Split(',');

                    if (varValues[0] == "login")
                    {
                        if (varUsuario != null)
                        {
                            atrSocketClient.Send(toByte("0,The " + varUsuario.darNombre() + "'s session is active."));
                            Console.WriteLine("The " + varUsuario.darNombre() + "'s session is active.\n");
                        }
                        else
                        {
                            varUsuario = clsSistema.darInstancia().login(varValues[1], varValues[2]);
                            if (varUsuario != null)
                            {
                                atrSocketClient.Send(toByte("1,Hi " + varUsuario.darNombre() + " welcome."));
                                Console.WriteLine("Hi " + varUsuario.darNombre() + " welcome.\n");
                            }
                            else
                            {
                                atrSocketClient.Send(toByte("0,Wrong user or password."));
                                Console.WriteLine("Wrong user or password.\n");
                            } 
                        }
                    }

                    if (varValues[0] == "regAlcancia")
                    {
                        List<int> listMonedas = new List<int>();
                        List<int> listBilletes = new List<int>();
                        foreach (string varItem in varValues[5].Split('.'))
                        {
                            listMonedas.Add(int.Parse(varItem));
                        }
                        foreach (string varItem in varValues[6].Split('.'))
                        {
                            listBilletes.Add(int.Parse(varItem));
                        }
                        if (clsSistema.darInstancia().registrarAlcancia(varValues[1], varValues[2], int.Parse(varValues[3]), int.Parse(varValues[4]), listMonedas, listBilletes))
                        {
                            atrSocketClient.Send(toByte("1, Register complete"));
                            Console.WriteLine("Register complete.\n");
                        }
                        else
                        {
                            atrSocketClient.Send(toByte("0, Register failed"));
                            Console.WriteLine("Register failed.\n");
                        }
                    }

                    if (varValues[0] == "regMoneda")
                    {
                        clsUsuario varUsuario = clsSistema.darInstancia().buscarUsuario(varValues[1]);
                        if (clsSistema.darInstancia().registrarMoneda(varUsuario, varValues[2], varValues[3], int.Parse(varValues[4]), int.Parse(varValues[5])))
                        {
                            atrSocketClient.Send(toByte("1, Register complete"));
                            Console.WriteLine("Register complete.\n");
                        }
                        else
                        {
                            atrSocketClient.Send(toByte("0, Register failed"));
                            Console.WriteLine("Register failed.\n");
                        }
                    }

                    if (varValues[0] == "regBillete")
                    {
                        clsUsuario varUsuario = clsSistema.darInstancia().buscarUsuario(varValues[1]);
                        if (clsSistema.darInstancia().registrarBillete(varUsuario, varValues[2], varValues[3], int.Parse(varValues[4]), int.Parse(varValues[5]), int.Parse(varValues[6]), int.Parse(varValues[7])))
                        {
                            atrSocketClient.Send(toByte("1, Register complete"));
                            Console.WriteLine("Register complete.\n");
                        }
                        else
                        {
                            atrSocketClient.Send(toByte("0, Register failed"));
                            Console.WriteLine("Register failed.\n");
                        }
                    }

                    if (varValues[0] == "close server")
                        flagServidor = false;
                }
                else
                {
                    Console.WriteLine("Waiting connection...\n");
                    atrSocketClient = atrSocketServer.Accept();
                    Console.WriteLine("Approved connection.\n");
                    flagConexion = true;
                }
            }
            Console.WriteLine("Exiting...\n");
            Console.ReadKey();
        }
        public byte[] toByte(string prmString)
        {
            return Encoding.Default.GetBytes(prmString);
        }
        public string toString(byte[] prmArray)
        {
            return Encoding.Default.GetString(prmArray);
        }
    }
}
