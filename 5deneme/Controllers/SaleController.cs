using _5deneme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _5deneme.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            var Sales = new List<Sale>
            {
                new Sale { SaleId=1, ProductName="Luppo", Amount =15},
                new Sale { SaleId=2, ProductName="Jelibon", Amount =6000000},
                new Sale { SaleId=3, ProductName="Waffle", Amount =12},

            };


            
            return View(Sales);

        }
    }
}
