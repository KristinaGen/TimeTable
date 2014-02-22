using System;
using Data.Transports;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTableBusTrain.Models
{
    public class TrainTimeTableModel
    {
        public IEnumerable<String> Sities { set; get; }
        public IEnumerable<Train> Trains { set; get; }

        public TrainTimeTableModel(){}

    }
}