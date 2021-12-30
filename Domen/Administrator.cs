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
    public class Administrator : IEntity
    {
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public bool Ulogovan { get; set; }

        [Browsable(false)]
        public string TableName => "Administrator";

        [Browsable(false)]
        public string TableAlias => "a";

        [Browsable(false)]
        public string JoinTable => "";

        [Browsable(false)]
        public string JoinCondition => "";

        [Browsable(false)]
        public string WhereCondition => "";

        [Browsable(false)]
        public string GeneralCondition => "";

        [Browsable(false)]
        public object SelectValues => "*";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string InsertValues => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Administrator
                {
                    KorisnickoIme = (string)reader["KorisnickoIme"],
                    Sifra = (string)reader["Sifra"],
                });
            }
            return result;
        }
    }
}
