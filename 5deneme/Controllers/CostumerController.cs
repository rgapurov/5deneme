using _5deneme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _5deneme.Controllers
{
    public class CostumerController : Controller
    {
        public IActionResult Index()
        {
            var costumers = new List<costumer>
            {
                new costumer { CostumerId=1, CostumerName="Hasan Tayip", CostumerAge =24},
                new costumer { CostumerId=2, CostumerName="Rustam Gapurov", CostumerAge =68},
                new costumer { CostumerId=3, CostumerName="Hasan Demirtaş", CostumerAge =76}
            };


            ViewBag.costumers = costumers;
            return View();


            
        }

        

        //public JsonResult GetCostumer()
        //{
        //    JsonResult result = Json(new costumer
        //    {
        //        CostumerId = 1,
        //        CostumerName = "Hasan TAYIP",
        //        CostumerAge = 55,
        //    });
        //        return result;
        //}

        public IActionResult MusteriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MusteriEkle(costumer costumers)
        {
            return View();
        }

        [HttpPost]
        public IActionResult MusteriEkleyiverGari(IFormCollection deger)
        {
            var deg1 = deger["Değer1"].ToString();
            var deg2 = deger["Değer1"].ToString();
            return View();
        }
        public IActionResult MusteriEkleyiverGari()
        {
            return View();
        }

    }
}
