using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajKorisnikeSO : SystemOperationBase
    {
        public List<Korisnik> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Korisnik()).Cast<Korisnik>().ToList();
        }
    }
}
