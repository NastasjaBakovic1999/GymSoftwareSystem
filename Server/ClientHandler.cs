using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijent;
        private readonly BindingList<Administrator> admini;
        private Administrator ulogovaniAdmin;

        public ClientHandler(Socket client, System.ComponentModel.BindingList<Administrator> admini)
        {
            this.klijent = client;
            this.admini = admini;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(klijent);
                BinaryFormatter formater = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formater.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formater.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
               //
            }
            return response;
        }

        internal void Stop()
        {
            klijent.Close();
        }
    }
}
