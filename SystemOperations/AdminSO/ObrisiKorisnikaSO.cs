using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdminSO
{
    public class ObrisiKorisnikaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Delete(entity);
        }
    }
}
