using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Sala : IEntity
    {
        public int SalaId { get; set; }
        public string BrojSale { get; set; }
        public string TableName => "Sala";

        public string TableAlias => "s";

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
                result.Add(new Sala
                {
                    SalaId=(int)reader["SalaId"],
                    BrojSale=(string)reader["BrojSale"]
                });
            }
            return result;
        }
    }
}
