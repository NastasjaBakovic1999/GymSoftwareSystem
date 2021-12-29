using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    public class SystemNotFoundException:Exception
    {
        public SystemNotFoundException() : base("Uneto korisnicko ime ne postoji i/ili ste uneli pogresnu sifru")
        {

        }
        public SystemNotFoundException(string message) : base(message)
        {

        }
    }
}
