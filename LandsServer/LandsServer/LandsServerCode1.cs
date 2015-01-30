using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LandsServer
{
    class LandsServerCode1 // This proc will open and prepare socket for receive
    {
        public static Thread ReceiveDataThread = null;
        public static bool ServerCanWork = false;
        public static IPAddress ServerIPAddress = null;
        public static int ServerPort = 8482;
        public static UdpClient UdpConn;
        static void OpenServerSocket()
        {
            ServerCanWork = false;
            UdpConn = new UdpClient(ServerPort);
            if (UdpConn != null)
            {
                Console.WriteLine("UDPCONN opened");
                ServerCanWork = true;
                

            }
            else
            {
                Console.WriteLine("UDPCONN FAILED.");
            }
        }

        public static void ReceiveDataFmSocket() 
            // This proc will receive data,unpack and push it onto executebuffer (other class)
            // should be threaded.
        {
            while (true)
            { // here is receiving and processing code
               
            }
            
            

        }



        static void Main(string[] args)
        {
            OpenServerSocket();
            if (ServerCanWork == true) 
            {
                ReceiveDataThread = new Thread(new ThreadStart (ReceiveDataFmSocket));
                ReceiveDataThread.Start();
                while (true)
                { // here is general code for server
                    
                }

            
            };
            Console.ReadLine();

        }
    }
}
