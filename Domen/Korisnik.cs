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
    public class Korisnik : IEntity
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }

        [Browsable(false)]
        public string TableName => "Korisnik";

        [Browsable(false)]
        public string TableAlias => "k";

        [Browsable(false)]
        public string JoinTable => "";

        [Browsable(false)]
        public string JoinCondition => "";

        [Browsable(false)]
        public object SelectValues => "*";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string WhereCondition => $"KorisnikId={KorisnikId}";

        [Browsable(false)]
        public string InsertValues => $"'{JMBG}','{Ime}', '{Prezime}', '{DatumRodjenja.ToString("yyyyMMdd")}', '{Adresa}'";

        [Browsable(false)]
        public string Uslov;

        [Browsable(false)]
        public string GeneralCondition => $"{Uslov}";

        //public override string ToString()
        //{
        //    return ;
        //}
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();

            while (reader.Read())
            {
                result.Add(new Korisnik
                {
                    KorisnikId = (int)reader["KorisnikId"],
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
