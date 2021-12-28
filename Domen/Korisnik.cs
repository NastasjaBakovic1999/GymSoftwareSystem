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

        public string TableAlias => "k";

        public string JoinTable => "";

        public string JoinCondition => "";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string WhereCondition => $"KorisnikId={KorisnikId}";

        public string InsertValues => $"'{JMBG}','{Ime}', '{Prezime}', '{DatumRodjenja.ToString("yyyyMMdd")}', '{Adresa}'";

        public string Uslov;
        public string GeneralCondition => $"{Uslov}";

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
