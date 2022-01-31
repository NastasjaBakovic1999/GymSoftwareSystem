using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdminSO
{
    public class UnesiRezervacijeSO : SystemOperationBase
    {
        public List<Rezervacija> Rezervacije { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            foreach (Rezervacija r in Rezervacije)
            {
                repository.Save(r);
            }
        }
    }
}
