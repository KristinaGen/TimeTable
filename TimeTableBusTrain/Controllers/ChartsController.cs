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
            var list = creator.GetCitiesToList();
            var model = new Dictionary<string, int>();    
            foreach (var item in list)
            {
                int value;
                if (model.TryGetValue(item, out value))
                {
                    model[item]++;
                }
                else
                {
                    model[item] = 1;
                }
            }
            return View(model);
        }

    }
}
