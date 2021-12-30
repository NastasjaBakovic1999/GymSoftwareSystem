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
    public class Trener : IEntity
    {
        public int TrenerId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        [Browsable(false)]
        public string TableName => "Trener";

        [Browsable(false)]
        public string TableAlias => "tren";

        [Browsable(false)]
        public string JoinTable => "";

        [Browsable(false)]
        public string JoinCondition => "";

        [Browsable(false)]
        public object SelectValues => "*";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string WhereCondition => "";

        [Browsable(false)]
        public string InsertValues => "";

        [Browsable(false)]
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
