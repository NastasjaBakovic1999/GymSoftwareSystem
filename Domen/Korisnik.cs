using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Korisnik : IEntity
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }

        public string TableName => "Korisnik";

        public string TableAlias => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public object SelectValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string GeneralCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();

            while (reader.Read())
            {
                result.Add(new Korisnik
                {
                    KorisnikId = (int)reader["KorisniId"],
                    JMBG = (string)reader["JMBG"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                    Adresa = (string)reader["Adresa"],
                });
            }
            return result;
        }
    }
}
