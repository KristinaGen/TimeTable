using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transports;
using System.Xml.Linq;

namespace Logic.Readers
{
    public class ReaderFromXml: IReader
    {
        public List<Transport> GetListTransport()
        {
            XDocument document = XDocument.Load(@"D:\project\TimeTable\Logic\TransportTimeTable.xml");

            return document.Element("transports").Elements().Select(x => x.Name == "bus" ? new Bus()
            {
                BusModel = x.Element("BusModel").Value,
                NumberRoute = Int32.Parse(x.Element("NumberRoute").Value),
                StartTime = x.Element("StartTime").Value,
                FinishTime = x.Element("FinishTime").Value,
                CityFrom = x.Element("CityFrom").Value,
                CityTo = x.Element("CityTo").Value,
                Platform = Int32.Parse(x.Element("Platform").Value),
                StationFrom = x.Element("StationFrom").Value,
                StationTo = x.Element("StationTo").Value,
                Cost = Int32.Parse(x.Element("Cost").Value),
                DaysOfWeek = x.Element("DaysOfWeek").Elements().Select(c => (string)c.Attribute("name").Value).ToList()
            } : (Transport) new Train()
            {
                TypeTrain = x.Element("TypeTrain").Value,
                NumberTrain = Int32.Parse(x.Element("NumberTrain").Value),
                StartTime = x.Element("StartTime").Value,
                FinishTime = x.Element("FinishTime").Value,
                CityFrom = x.Element("CityFrom").Value,
                CityTo = x.Element("CityTo").Value,
                Platform = Int32.Parse(x.Element("Platform").Value),
                StationFrom = x.Element("StationFrom").Value,
                StationTo = x.Element("StationTo").Value,
                Cost = Int32.Parse(x.Element("Cost").Value),
                DaysOfWeek = x.Element("DaysOfWeek").Elements().Select(c => (string)c.Attribute("name").Value).ToList()
            }).ToList();
        }
    }
}
