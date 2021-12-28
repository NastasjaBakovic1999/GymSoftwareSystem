using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdminSO
{
    public class UnesiTermineSO : SystemOperationBase
    {
        public List<Termin> termini { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            foreach(Termin t in termini)
            {
                repository.Save(t);
            }
        }
    }
}
