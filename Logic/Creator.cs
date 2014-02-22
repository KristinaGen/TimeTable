using System;
using Data.Transports;
using Data.Lists;
using Logic.Factory;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class Creator
    {
       
       private IFactory factory;

       public Creator(IFactory factory)
       {
           this.factory = factory;
       }
       public List<Transport> GetTransportList()
       {
           return factory.CreateListRoute();
       }
       public List<string> GetCitiesList()
       {
           return factory.CreateListCity();
       }
    }
       
}
