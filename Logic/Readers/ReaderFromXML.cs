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
        public List<Bus> GetListBus()
        {
            XDocument document = XDocument.Load("BusTimeTable.xml");
            return (from item in document.Element("buses").Elements()
                    select new Bus()
                    {
                        
                        StartTime = DateTime.Parse(item.Element("StartTime").Value),
                        FinishTime = DateTime.Parse(item.Element("FinishTime").Value),
                        CityFrom = item.Element("CityFrom").Value,
                        CityTo=item.Element("CityTo").Value,
                        Platform=Int32.Parse(item.Element("Platform").Value),
                        StationFrom=item.Element("StationFrom").Value,
                        StationTo=item.Element("StationTo").Value,
                        Cost=Int32.Parse(item.Element("Cost").Value),
                        daysOfWeek =item.Element("daysOfWeek").Elements().Select(c => (string)c).ToList()
                    }).ToList();  

        }

        public List<Train> GetListTrain()
        {
            XDocument document = XDocument.Load("BusTimeTable.xml");
            return (from item in document.Element("buses").Elements()
                    select new Train()
                    {

                        StartTime = DateTime.Parse(item.Element("StartTime").Value),
                        FinishTime = DateTime.Parse(item.Element("FinishTime").Value),
                        CityFrom = item.Element("CityFrom").Value,
                        CityTo = item.Element("CityTo").Value,
                        Platform = Int32.Parse(item.Element("Platform").Value),
                        StationFrom = item.Element("StationFrom").Value,
                        StationTo = item.Element("StationTo").Value,
                        Cost = Int32.Parse(item.Element("Cost").Value),
                        daysOfWeek = item.Element("daysOfWeek").Elements().Select(c => (string)c).ToList()
                    }).ToList();
        }
    }
}
