using System;
using System.Collections;
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

        [HttpGet]
        public ActionResult Bus()
        {
            IFactory factory = new BusFactory();
            var creator = new Creator(factory);

            var busList = new PageModel();
            busList.List.AddRange(creator.GetTransportList());
            if (Request.Params.Get("CityTo") != null && !Request.Params.Get("CityTo").Equals(""))
            {
                busList.List = busList.List.Where(x => ((Transport)x).CityTo.Equals(Request.Params.Get("CityTo"))).ToList();
            }
            if (Request.Params.Get("CityFrom") != null && !Request.Params.Get("CityFrom").Equals(""))
            {
                busList.List = busList.List.Where(x => ((Transport)x).CityFrom.Equals(Request.Params.Get("CityFrom"))).ToList();
            }
            if (Request.Params.Get("OnlyHolidays") != null && !Request.Params.Get("OnlyHolidays").Equals(""))
            {
                busList.List = busList.List.Where(x => ((Transport)x).DaysOfWeek.Contains("saturday") || ((Transport)x).DaysOfWeek.Contains("sunday")).ToList();
            }
            if (Request.Params.Get("selected[]") != null && !Request.Params.Get("selected[]").Equals(""))
            {
                var selected = Request.Params.Get("selected[]").Split(',');
                busList.List = busList.List.Where(x => selected.Contains(((Bus)x).NumberRoute.ToString())).ToList();
            }
            var clt = new CityList();
            clt.List.AddRange(creator.GetCitiesToList());
            var clf = new CityList();
            clf.List.AddRange(creator.GetCitiesFromList());

            var data = new ChartData();
            data.Prepare(busList.List.Select(x => (Transport) x).ToList());

            var model = new PageModel();
            model.Add(busList);
            model.Add(clt);
            model.Add(data);
            model.Add(clf);
            return View(model);
        }
    }
}
