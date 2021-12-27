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
        public string TableName => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public object SelectValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

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
