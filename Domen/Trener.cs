using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Trener : IEntity
    {
        public int TrenerId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string TableName => "Trener";

        public string TableAlias => "tren";

        public string JoinTable => "";

        public string JoinCondition => "";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string WhereCondition => "";

        public string InsertValues => "";

        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();

            while (reader.Read())
            {
                result.Add(new Trener
                {
                   TrenerId=(int)reader["TrenerId"],
                   Ime=(string)reader["Ime"],
                   Prezime=(string)reader["Prezime"]
                });
            }
            return result;
        }
    }
}
