using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            // bu metot ile yönlendirme işlemi gerçekleştirebiliriz.
            // Örneğin /Ornek/index2 yazıldığında yine de Ornek/index e gidiyor.
            return RedirectToAction("Index");
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem 1", price = 1 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
