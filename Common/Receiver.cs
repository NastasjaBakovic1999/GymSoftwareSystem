using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Receiver
    {
        private readonly Socket soket;
        private NetworkStream tok;
        private BinaryFormatter formater;

        public Receiver(Socket soket)
        {
            this.soket = soket;
            tok = new NetworkStream(soket);
            formater = new BinaryFormatter();
        }

        public void Receive()
        {
            formater.Deserialize(tok);
        }
    }
}
