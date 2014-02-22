using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Transports
{
    public abstract class Transport
    {
        public DateTime StartTime { set; get; }
        public DateTime FinishTime { set; get; }
        public string CityFrom { set; get; }
        public string CityTo { set; get; }
        public int Platform { set; get; }
        public string StationFrom { set; get; }
        public string StationTo { set; get; }
        public int Cost { set; get; }
        public List<string> daysOfWeek { set; get; }


         

    }
}
