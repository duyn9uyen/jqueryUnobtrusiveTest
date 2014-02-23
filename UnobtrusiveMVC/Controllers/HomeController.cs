using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnobtrusiveMVC.Models;

namespace UnobtrusiveMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Boat b = new Boat();
            b.BoatName = "Titanic";
            b.CaptainName = "Leo Decaf";
            b.CaptainSaltinessPercent = 55;
            return View(b);
        }

    }
}
