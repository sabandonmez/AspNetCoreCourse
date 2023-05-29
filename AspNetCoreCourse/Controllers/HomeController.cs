using AspNetCoreCourse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreCourse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Image =new List<string> { "img1","img2","img3" };

            object o = new object();
            return View(o);
        }

        public IActionResult Privacy()
        {
            return View();
        }
 
    }
}