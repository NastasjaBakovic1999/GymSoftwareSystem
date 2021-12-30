using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdminSO
{
    public class LoginSO : SystemOperationBase
    {   
        public Administrator Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Administrator admin = (Administrator)entity;

            foreach (Administrator a in repository.GetAll(new Administrator()))
            {
                if(a.KorisnickoIme==admin.KorisnickoIme && a.Sifra == admin.Sifra)
                {
                    Result = admin;
                }
            }
        }
    }
}
