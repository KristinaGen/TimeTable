using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Bus:ITransport
    {
        public int NumberRoute { set; get; }
        public string BusModel { set; get; }
    }
}
