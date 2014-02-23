using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transports;

namespace Logic.Factory
{
   public class TrainFactory:IFactory
   {
       public List<Transport> CreateListRoute()
       {
           return FromFile.GetInstance().Transports.Where(x => x is Train).ToList();
       }

        public List<string> CreateListCityTo()
        {
            return FromFile.GetInstance().Transports.Where(x => x is Train).Select(x => x.CityTo).ToList();
        }

       public List<string> CreateListCityFrom()
        {
            return FromFile.GetInstance().Transports.Where(x => x is Train).Select(x => x.CityFrom).ToList();
       }
   }
}
