using Entitys;
using Handle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TSTTHandle h = new TSTTHandle();

            TSTT tSTT = new TSTT();
            tSTT.ID = 1;
            tSTT.Name = "zhonglunpan";

            var count = h.add(tSTT);
            return View();
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}