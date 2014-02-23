using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transports;
using Logic.Readers;

namespace Logic.Factory
{
    public class BusFactory:IFactory
    {

        public List<Transport> CreateListRoute()
        {
            return FromFile.GetInstance().Transports.Where(x => x is Bus).ToList();
        }

        public List<string> CreateListCityTo()
        {
            return FromFile.GetInstance().Transports.Where(x => x is Bus).Select(x => x.CityTo).Distinct().ToList();
        }

        public List<string> CreateListCityFrom()
        {
            return FromFile.GetInstance().Transports.Where(x => x is Bus).Select(x => x.CityFrom).Distinct().ToList();
        }
    }
}
