using System;
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
            return View();
        }

        public ActionResult Bus()
        {
            return View();
        }
    }
}
