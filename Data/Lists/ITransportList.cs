using System;
using Data.Transports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Lists
{
    public abstract class ITransportList
    {
        public List<Transport> Transports { set; get; }

    }
}
