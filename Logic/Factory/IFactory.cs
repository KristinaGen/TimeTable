using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Lists;

namespace Logic.Factory
{
   public  interface IFactory
    {
        ITransportList CreateListRoute();
        List<string> CreateListCity();
    }
}
