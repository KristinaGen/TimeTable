using System;
using Data.Transports;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTableBusTrain.Models
{
    public class TrainTimeTableModel
    {
        public List<String> Sities { set; get; }
        public List<Train> Trains { set; get; }
    }
}