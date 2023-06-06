using AspNetCoreCourse.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCourse.Controllers
{
    public class ProductController : Controller
    {
        readonly ILog _log;
        public ProductController(ILog log)
        {
            _log = log;
        }
        public IActionResult GetProducts()
        {
            _log.Log();
            return View();
        }
        

    }
}
