using AspNetCoreCourse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreCourse.Controllers
{

    [Route("ana")]
    public class HomeController : Controller
    {
        [Route("in/{id:int?}")]
        public IActionResult Index(int? id)
        {  
            return View();
        }
        [Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }
 
    }
}