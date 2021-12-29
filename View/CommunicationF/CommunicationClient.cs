using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using View.Exceptions;
using ServerException = View.Exceptions.ServerException;

namespace View.CommunicationF
{
    internal class CommunicationClient
    {
        private Receiver receiver;
        private Sender sender;

        public CommunicationClient(Socket soket)
        {
            receiver = new Receiver(soket);
            sender = new Sender(soket);
        }

        public void SendRequest(Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch(IOException ex)
            {
                throw new ServerException(ex.Message);
            }
            catch(SocketException ex)
            {
                throw new ServerException(ex.Message);
            }
        }

        public object GetResponseResult()
        {
            Response response = (Response)receiver.Receive();
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Error);
            }
        }
    }
}
