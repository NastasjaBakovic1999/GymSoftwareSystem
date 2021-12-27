using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajUslugeSO : SystemOperationBase
    {
        public List<Usluga> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Usluga()).Cast<Usluga>().ToList();   
        }
    }
}
