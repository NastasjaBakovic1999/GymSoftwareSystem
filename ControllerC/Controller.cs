using Domen;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using SystemOperations.AdminSO;

namespace ControllerC
{
    public class Controller
    {
        private IGenericRepository repository;

        #region singlton
        private static Controller instance;
        private static object _lock = new object();
        private Controller()
        {
            repository=new GenericRepository();
        }
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion

        public Administrator Login(Administrator admin)
        {
            PrijaviAdministratora so = new PrijaviAdministratora();
            so.ExecuteTemplate(admin);
            return so.Result;
        } 

        public void ObrisiKorisnika(Korisnik korisnik)
        {
            ObrisiKorisnikaSO so = new ObrisiKorisnikaSO();
            so.ExecuteTemplate(korisnik);
        }

        public void ObrisiRezervaciju(Rezervacija rezervacija)
        {
            ObrisiRezervacijuSO so = new ObrisiRezervacijuSO();
            so.ExecuteTemplate(rezervacija);
        }

        public void ObrisiTermin(Termin termin)
        {
            ObrisiTerminSO so = new ObrisiTerminSO();
            so.ExecuteTemplate(termin);
        }

        public void ObrisiUslugu(Usluga usluga)
        {
            ObrisiUsluguSO so = new ObrisiUsluguSO();
            so.ExecuteTemplate(usluga);
        }

        public object PretraziKorisnike(Korisnik korisnik)
        {
            PretraziKorisnikeSO so = new PretraziKorisnikeSO();
            so.ExecuteTemplate(korisnik);
            return so.Result;
        }

        public void UnesiKorisnika(Korisnik korisnik)
        {
            UnesiKorisnikaSO so = new UnesiKorisnikaSO();
            so.ExecuteTemplate(korisnik);
        }

        public void UnesiRezervacije(List<Rezervacija> rezervacije)
        {
            UnesiRezervacijeSO so = new UnesiRezervacijeSO
            {
                Rezervacije = rezervacije
            };
            so.ExecuteTemplate(new Rezervacija());
        }

        public void UnesiTermine(List<Termin> termini)
        {
            UnesiTermineSO so = new UnesiTermineSO
            {
                termini = termini
            };
            so.ExecuteTemplate(new Termin());
        }

        public void UnesiUslugu(Usluga usluga)
        {
            UnesiUsluguSO so = new UnesiUsluguSO();
            so.ExecuteTemplate(usluga);
        }

        public object UcitajKorisnika(Korisnik korisnik)
        {
            UcitajKorisnikaSO so = new UcitajKorisnikaSO();
            so.ExecuteTemplate(korisnik);
            return so.Result;
        }

        public object UcitajKorisnike()
        {
            UcitajKorisnikeSO so = new UcitajKorisnikeSO();
            so.ExecuteTemplate(new Korisnik());
            return so.Result;
        }

        public object UcitajRezervacije()
        {
            UcitajRezervacijeSO so = new UcitajRezervacijeSO();
            so.ExecuteTemplate(new Rezervacija());
            return so.Result;
        }

        public object UcitajSale()
        {
            UcitajSaleSO so = new UcitajSaleSO();
            so.ExecuteTemplate(new Sala());
            return so.Result;
        }

        public object UcitajTermine()
        {
            UcitajTermineSO so = new UcitajTermineSO();
            so.ExecuteTemplate(new Termin());
            return so.Result;
        }

        public object UcitajTrenere()
        {
            UcitajTrenereSO so = new UcitajTrenereSO();
            so.ExecuteTemplate(new Trener());
            return so.Result;
        }

        public object UcitajUsluge()
        {
            UcitajUslugeSO so = new UcitajUslugeSO();
            so.ExecuteTemplate(new Usluga());
            return so.Result;
        }
    }
}
