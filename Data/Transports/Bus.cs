using System;
using Data;
using Data.Transports;

namespace Data.Transports 
{
    public class Bus: Transport, IModel
    {
        public int NumberRoute { set; get; }
        public string BusModel { set; get; }

        public Bus(String s, int i)
        {
            this.BusModel = s;
            this.NumberRoute = i;
        }

        public void Operation()
        {
        
        }
    }
}
