using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Usluga : IEntity
    {
        public int UslugaId { get; set; }
        public string Naziv { get; set; }
        public Trener Trener { get; set; }

        public string TableName => "Usluga";

        public string TableAlias => "u";

        public string JoinTable => "join Trener tren";

        public string JoinCondition => "on u.TrenerId=tren.TrenerId";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string WhereCondition => $"UslugaId={UslugaId}";

        public string InsertValues => $"'{Naziv}', {Trener.TrenerId}";

        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();

            while (reader.Read())
            {
                result.Add(new Usluga
                {
                    UslugaId = (int)reader["UslugaId"],
                    Naziv=(string)reader["Naziv"],
                    Trener = new Trener
                    {
                        TrenerId = (int)reader["TrenerId"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"]
                    }
                });
            }
            return result;
        }
    }
}
