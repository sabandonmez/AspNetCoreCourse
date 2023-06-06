using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCourse.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }

    }
}
