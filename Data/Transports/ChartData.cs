using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Transports
{
    public class ChartData : IModel
    {
        public Dictionary<string, int> List = new Dictionary<string, int>();

        public void Prepare(List<Transport> list)
        {
            List = new Dictionary<string, int>();
            foreach (var item in list)
            {
                int value;
                if (List.TryGetValue(item.CityTo, out value))
                {
                    List[item.CityTo] += item.DaysOfWeek.Count;
                }
                else
                {
                    List[item.CityTo] = item.DaysOfWeek.Count;
                }
            }
        }

        public void Operation()
        {
            
        }
    }
}
