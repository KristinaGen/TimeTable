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
   public class Model
    {
       
       private IFactory factory;

       public Model(IFactory factory)
       {
           this.factory = factory;
       }
       public ITransportList GetTransportList()
       {
           return factory.CreateListRoute();
       }
       public List<string> GetCitiesList()
       {
           return factory.CreateListCity();
       }
    }
       
}
