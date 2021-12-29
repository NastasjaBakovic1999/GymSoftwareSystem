using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    public class ServerException:Exception
    {
        public ServerException():base("Serverska greska")
        {

        }

        public ServerException(string message):base(message)
        {

        }
    }
}
