using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    public class SystemNotFoundException:Exception
    {
        public SystemNotFoundException() : base("Uneto korisničko ime ili šifra nisu ispravni ili je admin već ulogovan!")
        {

        }
        public SystemNotFoundException(string message) : base(message)
        {

        }
    }
}
