using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Transports
{
    public class Train : Transport, IModel
    {
        public int NumberTrain { set; get; }
        public string TypeTrain { set; get; }
        public Train() { }

        public Train(String s, int i)
        {
            this.NumberTrain = i;
            this.TypeTrain = s;
        }

        public void Operation()
        {
            
        }
    }
}
