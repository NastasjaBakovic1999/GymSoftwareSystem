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
