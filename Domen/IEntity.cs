using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IEntity
    {
        string TableName { get; }
        string TableAlias { get; }  
        string JoinTable { get; }
        string JoinCondition { get; }   
        string WhereCondition { get; }
        string GeneralCondition { get; }
        object SelectValues { get; }    
        string UpdateValues { get; }
        string InsertValues { get; }
        List<IEntity> GetEntities(SqlDataReader reader);
    }
}
