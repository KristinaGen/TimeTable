using System;
using System.Linq.Expressions;
using System.Reflection;
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

            //IFactory factory = new TrainFactory();
            //Creator creator = new Creator(factory);
            TrainTimeTableModel model = new TrainTimeTableModel
            {
                Trains = new List<Train>()
                {
                    new Train("qwe", 1),
                    new Train("asd", 2),
                    new Train("zxc", 3)
                }
            };
            
            return View(model);
        }

        public ActionResult Bus()
        {
            IFactory factory = new BusFactory();
            Creator creator = new Creator(factory);

            PageModel busList = new PageModel();
            busList.List.AddRange(creator.GetTransportList());

            SityList sl = new SityList();
            sl.List.AddRange(creator.GetCitiesToList());

            PageModel model = new PageModel();
            model.Add(busList);
            model.Add(sl);
            return View(model);
        }
    }
}
