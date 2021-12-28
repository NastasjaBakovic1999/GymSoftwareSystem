using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Termin : IEntity
    {
        public int TerminId { get; set; }
        public DateTime DatumVreme { get; set; }
        public int Kapacitet { get; set; }
        public Usluga Usluga { get; set; }
        public Sala Sala { get; set; }
        public string TableName => "Termin";

        public string TableAlias => "t";

        public string JoinTable => "join Usluga u";

        public string JoinCondition => $"on (t.UslugaId=u.UslugaId) join Sala s on (t.SalaId=s.SalaId)";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string WhereCondition => $"TerminId={TerminId}";

        public string InsertValues => $"'{DatumVreme.ToString("yyyyMMdd")}', {Kapacitet}, {Usluga.UslugaId}, {Sala.SalaId}";

        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Termin
                {
                    TerminId = (int)reader["TerminId"],
                    DatumVreme = (DateTime)reader["DatumVreme"],
                    Kapacitet = (int)reader["Kapacitet"],
                    Usluga = new Usluga
                    {
                        UslugaId = (int)reader["UslugaId"],
                        Naziv = (string)reader["Naziv"],
                        Trener = new Trener
                        {
                            TrenerId=(int)reader["TrenerId"],
                            Ime=(string)reader["Ime"],
                            Prezime=(string)reader["Prezime"]
                        }
                    },
                    Sala = new Sala
                    {
                        SalaId = (int)reader["SalaId"],
                        BrojSale = (string)reader["BrojSale"],
                    }
                });
            }
            return result;
        }
    }
}
