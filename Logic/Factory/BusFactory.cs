using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Lists;
using Data.Transports;
using Logic.Readers;

namespace Logic.Factory
{
    public class BusFactory:IFactory
    {
        public List<Transport> CreateListRoute()
        {
            IReader read = new ReaderFromXml();
            return read.GetListBus().ConvertAll(x => (Transport)x).ToList();
        }

        public List<string> CreateListCity()
        {
            return new List<string>();
        }
    }
}
