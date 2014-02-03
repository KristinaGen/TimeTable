﻿using System;
using Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Lists;

namespace Logic
{
   public class TrainFactory:IFactory
    {

        public ITransportList CreateListRoute()
        {
            throw new NotImplementedException();
        }


        public List<string> CreateListCity()
        {
            return new List<string>();
        }
    }
}
