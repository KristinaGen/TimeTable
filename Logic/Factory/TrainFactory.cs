using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Lists;
using Data.Transports;

namespace Logic.Factory
{
   public class TrainFactory:IFactory
    {

        public List<Transport> CreateListRoute()
        {
            throw new NotImplementedException();
        }


        public List<string> CreateListCity()
        {
            return new List<string>();
        }
    }
}
