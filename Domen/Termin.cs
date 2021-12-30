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
    public class Termin : IEntity
    {
        public int TerminId { get; set; }
        public DateTime Datum{ get; set; }
        public DateTime Vreme { get; set; }
        public int Kapacitet { get; set; }
        public Usluga Usluga { get; set; }
        public Sala Sala { get; set; }

        [Browsable(false)]
        public string TableName => "Termin";

        [Browsable(false)]
        public string TableAlias => "t";

        [Browsable(false)]
        public string JoinTable => "join Usluga u";

        [Browsable(false)]
        public string JoinCondition => $"on (t.UslugaId=u.UslugaId) join Sala s on (t.SalaId=s.SalaId)";

        [Browsable(false)]
        public object SelectValues => "*";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string WhereCondition => $"TerminId={TerminId}";

        [Browsable(false)]
        public string InsertValues => $"'{Datum.ToShortDateString()}', '{Vreme.ToShortTimeString()}', {Kapacitet}, {Usluga.UslugaId}, {Sala.SalaId}";

        [Browsable(false)]
        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Termin
                {
                    TerminId = (int)reader["TerminId"],
                    Datum = (DateTime)reader["Datum"],
                    Vreme=(DateTime)reader["Vreme"],
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
