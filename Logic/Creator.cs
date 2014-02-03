using System;
using Data.Transports;
using Data.Lists;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class Model
    {
       private IFactory f;
       Model(IFactory factory) { f = factory; }
       public ITransportList GetTransportList()
       {
           return f.CreateListRoute();
       }
       public List<string> GetCitiesList()
       {
           return f.CreateListCity();
       }
    }
       
}
