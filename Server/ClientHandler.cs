using Common;
using ControllerC;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijentskiSoket;
        private readonly BindingList<Administrator> admini;
        private Administrator ulogovaniAdmin;

        public ClientHandler(Socket klijentskiSoket, BindingList<Administrator> admini)
        {
            this.klijentskiSoket = klijentskiSoket;
            this.admini = admini;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(klijentskiSoket);
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
                        Debug.WriteLine(">>>" + ex.Message);
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
                admini.Remove(ulogovaniAdmin);
            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                admini.Remove(ulogovaniAdmin);

            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
                case Operation.ObrisiKorisnika:
                    Controller.Instance.ObrisiKorisnika((Korisnik)request.RequestObject);
                    break;
                case Operation.ObrisiRezervaciju:
                    Controller.Instance.ObrisiRezervaciju((Rezervacija)request.RequestObject);
                    break;
                case Operation.ObrisiTermin:
                    Controller.Instance.ObrisiTermin((Termin)request.RequestObject);
                    break;
                case Operation.ObrisiUslugu:
                    Controller.Instance.ObrisiUslugu((Usluga)request.RequestObject);
                    break;
                case Operation.PretraziKorisnike:
                    response.Result = Controller.Instance.PretraziKorisnike((Korisnik)request.RequestObject);
                    break;
                case Operation.UcitajKorisnika:
                    response.Result = Controller.Instance.UcitajKorisnika((Korisnik)request.RequestObject);
                    break;
                case Operation.UnesiKorisnika:
                    Controller.Instance.UnesiKorisnika((Korisnik)request.RequestObject);
                    break;
                case Operation.UnesiRezervacije:
                    Controller.Instance.UnesiRezervacije((List<Rezervacija>)request.RequestObject);
                    break;
                case Operation.UnesiTermine:
                    Controller.Instance.UnesiTermine((List<Termin>)request.RequestObject);
                    break;
                case Operation.UnesiUslugu:
                    Controller.Instance.UnesiUslugu((Usluga)request.RequestObject);
                    break;
                case Operation.UcitajKorisnike:
                   response.Result = Controller.Instance.UcitajKorisnike();
                    break;
                case Operation.UcitajRezervacije:
                    response.Result = Controller.Instance.UcitajRezervacije();
                    break;
                case Operation.UcitajSale:
                    response.Result = Controller.Instance.UcitajSale();
                    break;
                case Operation.UcitajTermine:
                    response.Result = Controller.Instance.UcitajTermine();
                    break;
                case Operation.UcitajTrenere:
                    response.Result = Controller.Instance.UcitajTrenere();
                    break;
                case Operation.UcitajUsluge:
                    response.Result = Controller.Instance.UcitajUsluge();
                    break;
                case Operation.Login:
                    Administrator a = Controller.Instance.Login((Administrator)request.RequestObject);
                    if(a!= null)
                    {
                        a.Ulogovan = admini.Any(adm => adm.KorisnickoIme == a.KorisnickoIme);
                        if (!a.Ulogovan)
                        {
                            ulogovaniAdmin = a;
                            admini.Add(ulogovaniAdmin);
                        }
                    }
                    response.Result = a;
                    break;
            }
            return response;
        }

        internal void Stop()
        {
            klijentskiSoket.Close();
        }
    }
}
