using System;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeTableBusTrain.Controllers
{
    public class TimeTableController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        
        public ActionResult Train()
        {

            IFactory factory = new TrainFactory();
            return View();
        }

        public ActionResult Bus()
        {
            IFactory factory = new BusFactory();
            return View();
        }
    }
}
