using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TypeScriptStarter.Controllers
{
    [Authorize]
    public class MealsController : Controller
    {
        // GET: Meals
        public ActionResult Index()
        {
            return View();
        }
    }
}