using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BulbPuzzleModel m)
        {
            Debug.WriteLine("People: {0}; Bulbs {1}", m.NumberOfPeople, m.NumberOfBulbs);
            m.Run();
            return View(m);
        }

    }
}
