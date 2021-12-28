using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Rezervacija : IEntity
    {
        public Korisnik Korisnik { get; set; }
        public Termin Termin { get; set; }

        public string TableName => "Rezervacija";

        public string TableAlias => "r";

        public string JoinTable => "join Korisnik k";

        public string JoinCondition => "on (r.KorisnikId=k.KorisnikId) join Termin t on (r.TerminId=t.TerminId)";

        public string WhereCondition => $"KorisnikId = {Korisnik.KorisnikId} and TerminId = {Termin.TerminId}";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"{Korisnik.KorisnikId}, {Termin.TerminId}";

        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();

            while (reader.Read())
            {
                result.Add(new Rezervacija
                {
                    Korisnik = new Korisnik
                    {
                        KorisnikId = (int)reader["KorisniId"],
                        JMBG = (string)reader["JMBG"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                        Adresa = (string)reader["Adresa"],
                    },
                    Termin = new Termin
                    {
                        TerminId = (int)reader["TerminId"],
                        DatumVreme = (DateTime)reader["DatumVreme"],
                        Kapacitet = (int)reader["Kapacitet"],
                        Usluga = new Usluga
                        {
                            UslugaId = (int)reader["UslugaId"],
                            Naziv = (string)reader["Naziv"],
                            Trener = new Trener
                            {
                                TrenerId = (int)reader["TrenerId"],
                                Ime = (string)reader["Ime"],
                                Prezime = (string)reader["Prezime"]
                            }
                        },
                        Sala = new Sala
                        {
                            SalaId = (int)reader["SalaId"],
                            BrojSale = (string)reader["BrojSale"],
                        }
                    }
                });
            }
            return result;
        }
    }
}
