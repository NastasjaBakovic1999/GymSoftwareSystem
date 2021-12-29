using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace View.CommunicationF
{
    public class Communication
    {
        #region singlton
        private static Communication instance;
        private Communication() { }
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        #endregion

        private Socket soket;
        private CommunicationClient klijent;

        public void Connect()
        {
            if(soket!=null && soket.Connected)
            {
                return;
            }
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Connect("127.0.0.1", 9999);
            klijent = new CommunicationClient(soket);
        }

        internal void Disconnect()
        {
            soket.Close();
            soket = null;
        }

        internal Administrator Login(Administrator admin)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new Administrator { KorisnickoIme=admin.KorisnickoIme, Sifra=admin.Sifra}
            };
            klijent.SendRequest(request);
            return (Administrator)klijent.GetResponseResult();
        }

        internal void ObrisiKorisnika(Korisnik k)
        {
            Request request = new Request
            {
                Operation = Operation.ObrisiKorisnika,
                RequestObject = k
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal void ObrisiReervaciju(Rezervacija r)
        {
            Request request = new Request
            {
                Operation = Operation.ObrisiRezervaciju,
                RequestObject = r
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal void ObrisiTermin(Termin t)
        {
            Request request = new Request
            {
                Operation = Operation.ObrisiTermin,
                RequestObject = t
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal void ObrisiUslugu(Usluga u)
        {
            Request request = new Request
            {
                Operation = Operation.ObrisiUslugu,
                RequestObject = u
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal List<Korisnik> PretraziKorisnike(Korisnik k)
        {
            Request request = new Request
            {
                Operation = Operation.PretraziKorisnike,
                RequestObject = k
            };
            klijent.SendRequest(request);
            return (List<Korisnik>)klijent.GetResponseResult();
        } 

        internal void UnesiKorisnika(Korisnik k)
        {
            Request request = new Request
            {
                Operation = Operation.UnesiKorisnika,
                RequestObject = k
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal void UnesiRezervacije(List<Rezervacija> rezervacije)
        {
            Request request = new Request
            {
                Operation = Operation.UnesiRezervacije,
                RequestObject = rezervacije
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal void UnesiTermine(List<Termin> termini)
        {
            Request request = new Request
            {
                Operation = Operation.UnesiTermine,
                RequestObject = termini
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal void UnesiUslugu(Usluga u)
        {
            Request request = new Request
            {
                Operation = Operation.UnesiUslugu,
                RequestObject = u
            };
            klijent.SendRequest(request);
            klijent.GetResponseResult();
        }

        internal List<Korisnik> UcitajKorisnike()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajKorisnike
            };
            klijent.SendRequest(request);
            return (List<Korisnik>)klijent.GetResponseResult();
        }

        internal Korisnik UcitajKorisnika(Korisnik k)
        {
            Request request = new Request
            {
                Operation = Operation.UcitajKorisnika,
                RequestObject = k
            };
            klijent.SendRequest(request);
            return (Korisnik) klijent.GetResponseResult();
        }

        internal List<Rezervacija> UcitajRezervacije()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajRezervacije
            };
            klijent.SendRequest(request);
            return (List<Rezervacija>)klijent.GetResponseResult();
        }

        internal List<Sala> UcitajSale()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajSale
            };
            klijent.SendRequest(request);
            return (List<Sala>)klijent.GetResponseResult();
        }

        internal List<Termin> UcitajTermine()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajTermine
            };
            klijent.SendRequest(request);
            return (List<Termin>)klijent.GetResponseResult();
        }

        internal List<Trener> UcitajTrenere()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajTrenere
            };
            klijent.SendRequest(request);
            return (List<Trener>)klijent.GetResponseResult();
        }

        internal List<Usluga> UcitajUsluge()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajUsluge
            };
            klijent.SendRequest(request);
            return (List<Usluga>)klijent.GetResponseResult();
        }
    }
}
