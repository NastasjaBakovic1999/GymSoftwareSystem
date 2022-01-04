using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Rezervacija : IEntity
    {
        public Korisnik Korisnik { get; set; }
        public Termin Termin { get; set; }

        [Browsable(false)]
        public string TableName => "Rezervacija";

        [Browsable(false)]
        public string TableAlias => "r";

        [Browsable(false)]
        public string JoinTable => "join Korisnik k";

        [Browsable(false)]
        public string JoinCondition => "on (r.KorisnikId=k.KorisnikId) join Termin t on (r.TerminId=t.TerminId) left join Usluga u on (t.UslugaId=u.UslugaId)";

        [Browsable(false)]
        public string WhereCondition => $"KorisnikId = {Korisnik.KorisnikId} and TerminId = {Termin.TerminId}";

        [Browsable(false)]
        public object SelectValues => "*";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string InsertValues => $"{Korisnik.KorisnikId}, {Termin.TerminId}";

        [Browsable(false)]
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
                        KorisnikId = (int)reader["KorisnikId"],
                        JMBG = (string)reader["JMBG"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                        Adresa = (string)reader["Adresa"],
                    },
                    Termin = new Termin
                    {
                        TerminId = (int)reader["TerminId"],
                        Datum = (DateTime)reader["Datum"],
                        Vreme = (TimeSpan)reader["Vreme"],
                        Kapacitet = (int)reader["Kapacitet"],
                        Usluga = new Usluga
                        {
                            UslugaId = (int)reader["UslugaId"],
                            Naziv = (string)reader["Naziv"]
                        }
                    }
                });
            }
            return result;
        }
    }
}
