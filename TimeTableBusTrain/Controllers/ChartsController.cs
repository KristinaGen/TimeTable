using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using Logic.Factory;

namespace TimeTableBusTrain.Controllers
{
    public class ChartsController : Controller
    {
        //
        // GET: /Charts/

        public ActionResult Index()
        {
            var creator = new Creator(new BusFactory());
            var list = creator.GetTransportList();
            var model = new Dictionary<string, int>();    
            foreach (var item in list)
            {
                int value;
                if (model.TryGetValue(item.CityTo, out value))
                {
                    model[item.CityTo] += item.DaysOfWeek.Count;
                }
                else
                {
                    model[item.CityTo] = item.DaysOfWeek.Count;
                }
            }
            return View(model);
        }

    }
}
