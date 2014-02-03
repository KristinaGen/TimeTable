using System;
using System.Text;
using Data.Transports;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic.Factory;
using TimeTableBusTrain.Models;
using System.Collections.Generic;

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
            Model model = new Model(factory);
            BusTimeTableModel m = new BusTimeTableModel();
            m.Buses = model.GetTransportList().Transports.ConvertAll(o => (Bus)o);
            m.Sities = model.GetCitiesList();
            return View(m);
        }

        public ActionResult Bus()
        {
            IFactory factory = new BusFactory();
            return View();
        }
    }
}
