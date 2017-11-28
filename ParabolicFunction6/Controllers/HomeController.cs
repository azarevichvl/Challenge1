using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParabolicFunction6.Models;
using ParabolicFunction6.Services;

namespace ParabolicFunction6.Controllers
{
    public class HomeController : Controller
    {
        FunctCalc calculation = new FunctCalc();
        
        public ActionResult Index(FormModel fm)
        {
            calculation.GeneratePoints(fm);
            return View(fm);
        }

        public JsonResult GetPointsJson()
        {
            return Json(calculation.getPoints(), JsonRequestBehavior.AllowGet);
        }

    }
}