﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdminSO
{
    public class UnesiKorisnika:SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save(entity);
        }

    }
}
