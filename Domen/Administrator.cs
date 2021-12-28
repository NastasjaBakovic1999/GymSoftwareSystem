using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Administrator : IEntity
    {
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public bool Ulogovan { get; set; }
        public string TableName =>  "Administrator";

        public string TableAlias => "a";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string WhereCondition => "";

        public string GeneralCondition => "";

        public object SelectValues => "*";

        public string UpdateValues => "";

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
