using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TypeScriptStarter.Models;

namespace TypeScriptStarter.Controllers
{
    [Authorize]
    public class MealsDataController : ApiController
    {
        Meal[] products = new Meal[]
        {
            new Meal { Id = 0, Name = "Standard (sandwich)", Price = 0 },
            new Meal { Id = 1, Name = "Premium (lobster)", Price = 34.95M },
            new Meal { Id = 2, Name = "Ultimate (whole zebra)", Price = 290M }
        };

        public IHttpActionResult GetAllMeals()
        {
            var username = User.Identity.Name;
            return Json(products);
        }

        [HttpPost]
        public IHttpActionResult GetMeal(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return Json(string.Empty);
            }
            return Json(product);
        }
    }
}
