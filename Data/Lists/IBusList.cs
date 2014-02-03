using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transports;

namespace Data.Lists
{
    public class IBusList:ITransportList
    {
        public List<Bus> Busses { set; get; }
    }
}
