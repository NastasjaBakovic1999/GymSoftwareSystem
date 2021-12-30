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
    public class Sala : IEntity
    {
        public int SalaId { get; set; }
        public string BrojSale { get; set; }

        [Browsable(false)]
        public string TableName => "Sala";

        [Browsable(false)]
        public string TableAlias => "s";

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
