using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Data.Transports;

namespace Logic.Readers
{
    public class ReaderFromCsv: IReader
    {
        public List<Transport> GetListTransport()
        {
            return File.ReadAllLines("D:\\Projects\\TimeTable\\Logic\\TransportTimeTable.csv").Skip(1).Select(x => x.Split(';')).Select(x => x[0].Equals("bus") ? (Transport)new Bus()
            {
                StartTime = x[1],
                FinishTime = x[2],
                CityFrom = x[3],
                CityTo = x[4],
                Platform = Int32.Parse(x[5]),
                StationFrom = x[6],
                StationTo = x[7],
                Cost = Int32.Parse(x[8]),
                DaysOfWeek = x[9].Split('|').ToList(),
                BusModel = x[10],
                NumberRoute = Int32.Parse(x[11])
            }: (Transport) new Train()
            {
                StartTime = x[1],
                FinishTime = x[2],
                CityFrom = x[3],
                CityTo = x[4],
                Platform = Int32.Parse(x[5]),
                StationFrom = x[6],
                StationTo = x[7],
                Cost = Int32.Parse(x[8]),
                DaysOfWeek = x[9].Split('|').ToList(),
                TypeTrain = x[10],
                NumberTrain = Int32.Parse(x[11]),
            }).ToList();
        }
    }
}
