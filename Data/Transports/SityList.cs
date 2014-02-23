using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Transports
{
    public class SityList:IModel
    {
        public List<String> List { set; get; }

        public SityList()
        {
            List = new List<string>();
        }

        public void Operation()
        {
        }
    }
}
