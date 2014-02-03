using Data;
using Data.Transports;

namespace Data.Transports 
{
    public class Bus: Transport
    {
        public int NumberRoute { set; get; }
        public string BusModel { set; get; }
    }
}
