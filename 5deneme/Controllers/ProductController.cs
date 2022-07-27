using _5deneme.Models;
using Microsoft.AspNetCore.Mvc;

namespace _5deneme.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        #region JsonResult

        //Oluşturduğum veriyi JSON turune dönüştürüp döndüren bir action tipidir

        //public JsonResult GetProduct()
        //{
        //    JsonResult result = Json(new product

        //    {
        //        Id = 3,
        //        ProductName = "samsung a71",
        //        ProductPrice = 1000


        //    });
        //    return result;
        //}
        #endregion

        #region ContentResult
        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("Herkese Merhaba ama hasana yok");
        //    return result; 
        //}
        #endregion

        #region IActionResault
        public IActionResult Deneme()
        {
            if(true)
            {
                return Content("İşlem Başarılı");
            }
            else if (false)
            {
                return Json(new object());
            }
        }
        #endregion
    }
}
