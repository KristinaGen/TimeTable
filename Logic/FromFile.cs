using System.Collections.Generic;
using Data.Transports;
using Logic.Readers;

namespace Logic
{
    public class FromFile
    {
        public List<Transport> Transports { set; get; }

        private static FromFile _instance;

        private FromFile()
        {
            IReader reader = new ReaderFromXml();
            Transports = reader.GetListTransport();
        }

        public static FromFile GetInstance()
        {
            return _instance ?? (_instance = new FromFile());
        }
    }
}
