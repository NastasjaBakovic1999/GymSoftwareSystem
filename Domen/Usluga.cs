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
    public class Usluga : IEntity
    {
        public int UslugaId { get; set; }
        public string Naziv { get; set; }
        public Trener Trener { get; set; }

        [Browsable(false)]
        public string TableName => "Usluga";

        [Browsable(false)]
        public string TableAlias => "u";

        [Browsable(false)]
        public string JoinTable => "join Trener tren";

        [Browsable(false)]
        public string JoinCondition => "on u.TrenerId=tren.TrenerId";

        [Browsable(false)]
        public object SelectValues => "*";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string WhereCondition => $"UslugaId={UslugaId}";

        [Browsable(false)]
        public string InsertValues => $"'{Naziv}', {Trener.TrenerId}";

        [Browsable(false)]
        public string GeneralCondition => "";

        public override string ToString()
        {
            return $"{Naziv} - {Trener.Ime} {Trener.Prezime}";
        }
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
