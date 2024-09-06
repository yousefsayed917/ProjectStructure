using Microsoft.AspNetCore.Mvc;

namespace ProjectStructure.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();// helper method هنا كدا هو مستخدم ال 
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View(); 
        }
        public IActionResult Privacy()
        {
            return View(); 
        }
    }
}
