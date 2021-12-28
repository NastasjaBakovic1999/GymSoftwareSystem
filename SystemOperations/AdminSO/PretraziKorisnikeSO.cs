using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdminSO
{
    public class PretraziKorisnikeSO : SystemOperationBase
    {
        public List<Korisnik> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Korisnik>().ToList();
        }
    }
}
