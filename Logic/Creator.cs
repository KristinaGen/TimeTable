
using Data.Transports;
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
       public List<string> GetCitiesToList()
       {
           return _factory.CreateListCityTo();
       }
       public List<string> GetCitiesFromList()
       {
           return _factory.CreateListCityFrom();
       }
    }
       
}
