using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TypeScriptStarter.Models;

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

        Meal[] products = new Meal[]
        {
            new Meal { Id = 0, Name = "Standard (sandwich)", Price = 0 },
            new Meal { Id = 1, Name = "Premium (lobster)", Price = 34.95M },
            new Meal { Id = 2, Name = "Ultimate (whole zebra)", Price = 290M }
        };

        public JsonResult GetAllMeals()
        {
            var username = User.Identity.Name;
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMeal(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return Json(null);
            }
            return Json(product, JsonRequestBehavior.AllowGet);
        }
    }
}
