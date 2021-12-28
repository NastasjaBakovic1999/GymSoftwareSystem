using Common;
using ControllerC;
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

        public ClientHandler(Socket klijent, BindingList<Administrator> admini)
        {
            this.klijent = klijent;
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
                case Operation.ObrisiKorisnika:
                    break;
                case Operation.ObrisiRezervaciju:
                    break;
                case Operation.ObrisiTermin:
                    break;
                case Operation.ObrisiUslugu:
                    break;
                case Operation.PretraziKorisnike:
                    break;
                case Operation.UcitajKorisnika:
                    break;
                case Operation.UnesiKorisnika:
                    break;
                case Operation.UnesiRezervacije:
                    break;
                case Operation.UnesiTermine:
                    break;
                case Operation.UnesiUslugu:
                    break;
                case Operation.UcitajKorisnike:
                    break;
                case Operation.UcitajRezervacije:
                    break;
                case Operation.UcitajSale:
                    break;
                case Operation.UcitajTermine:
                    break;
                case Operation.UcitajTrenere:
                    break;
                case Operation.UcitajUsluge:
                    break;
                case Operation.Login:
                    Administrator a = Controller.Instance.Login((Administrator)request.RequestObject);
                    if(a!= null)
                    {
                        a.Ulogovan = admini.Any(adm => adm.KorisnickoIme == a.KorisnickoIme); // vaj dis vi du aj dont anderstend
                        ulogovaniAdmin = a;
                        admini.Add(ulogovaniAdmin);
                    }
                    response.Result = a;
                    break;
            }
            return response;
        }

        internal void Stop()
        {
            klijent.Close();
        }
    }
}
