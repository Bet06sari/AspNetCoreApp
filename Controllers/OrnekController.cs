using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.Web.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    };
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Asp.Net Core";
            //ViewBag.name = new List<string>() { "ahmet", "mehmet", "hasan" };
            ViewData["age"] = 30;
            ViewData["names"] = new List<string>() { "ahmet", "mehmet", "hasan" };

            ViewBag.person = new { Id = 1, Name = "ahmet", Age = 23 };

            // temp data sayesinde farklı actionların içerisine verilerimizi aktarabiliriz
            //örneğin index de tanımladığımız yildiz index 2 de görünecektir.
            TempData["surname"] = "yildiz";

            var productList = new List<Product>()
            {
                new(){ Id = 1, Name = "Kalem"},
                new(){ Id = 2, Name = "Defter"},
                new(){ Id = 3, Name = "Silgi"},
            };
            //return View();
            return View(productList);
        }

        public IActionResult Index2()
        {

            return View();
        }

        public IActionResult Index3()
        {
            // bu metot ile yönlendirme işlemi gerçekleştirebiliriz.
            // Örneğin /Ornek/index2 yazıldığında yine de Ornek/index e gidiyor.
            return RedirectToAction("Index", "Ornek");
        }

        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }


        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem 1", price = 1 });
        }

        // kendine döndürüp boş bir sayfa yapabiliriz
        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
