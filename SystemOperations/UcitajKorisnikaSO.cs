using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajKorisnikaSO : SystemOperationBase
    {
        public Korisnik Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetSpecific(entity).Cast<Korisnik>().ToList()[0];
        }
    }
}
