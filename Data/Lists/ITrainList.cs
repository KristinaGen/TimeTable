using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Data.Transports;

namespace Data.Lists
{
    public class ITrainList:ITransportList
    {
        public List<Train> Trains { set; get; }
    }
}
