using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Transports
{
    public class CityList:IModel
    {
        public List<String> List { set; get; }

        public CityList()
        {
            List = new List<string>();
        }

        public void Operation()
        {
        }
    }
}
