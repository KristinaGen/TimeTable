using System;
using Data.Transports;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTableBusTrain.Models
{
    public class BusTimeTable
    {
        public List<String> Sities { set; get; }
        public List<Bus> Buses { set; get; }
    }
}