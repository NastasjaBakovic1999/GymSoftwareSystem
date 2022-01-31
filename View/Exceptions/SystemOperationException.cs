using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    internal class SystemOperationException: Exception
    {
        public SystemOperationException() : base("Sistem ne može da izvrši operaciju.")
        {

        }

        public SystemOperationException(string message) : base(message)
        {

        }
    }
}
