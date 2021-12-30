using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket osluskujuciSoket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();
        private BindingList<Administrator> administratori =new BindingList<Administrator>();

        public BindingList<Administrator> Administartori { get { return administratori; } }

        public Server()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            // HARDKODOVANO !!!!! TREBA ISPRAVITI
            // int.Parse(ConfigurationManager.AppSettings["port"])
            osluskujuciSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
        }

        public void Listen()
        {
            osluskujuciSoket.Listen(5);
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Socket klijentskiSoket = osluskujuciSoket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket, administratori);
                    klijenti.Add(handler);
                    Thread klijentskaNit = new Thread(handler.StartHandler);
                    klijentskaNit.IsBackground = true;
                    klijentskaNit.Start();
                }
                catch (SocketException)
                {
                    Console.WriteLine("Kraj rada");
                    kraj = true;
                }
            }
        }

        public void Stop()
        {
            osluskujuciSoket.Close();
            foreach(ClientHandler c in klijenti)
            {
                c.Stop();
            }
            klijenti.Clear();
        }

    }
}
