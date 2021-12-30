using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Response
    {
        public bool IsSuccessful { get; set; }
        public object Result { get; set; }
        public string Error { get; set; }
    }
}
