using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Lists;
using Data.Transports;

namespace Logic.Factory
{
   public  interface IFactory
    {
       List<Transport> CreateListRoute();
        List<string> CreateListCity();
    }
}
