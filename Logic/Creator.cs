using Data.Lists;
using Logic.Factory;
using System.Collections.Generic;

namespace Logic
{
   public class Creator
    {
       
       private readonly IFactory _factory;

       public Creator(IFactory factory)
       {
           _factory = factory;
       }
       public List<Transport> GetTransportList()
       {
           return _factory.CreateListRoute();
       }
       public List<string> GetCitiesList()
       {
           return _factory.CreateListCity();
       }
    }
       
}
