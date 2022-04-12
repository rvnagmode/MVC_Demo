using Microsoft.AspNetCore.Mvc;
using MVC_Demoo.Models;
using System.Diagnostics;

namespace MVC_Demoo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult FirstPage()
        {
            ViewData["message"] = "First MVC Application";
            List<string> colors = new List<string>() { "orange","yellow" ,"blue","purple","voilet","red","brown", "black" };
            ViewData["colorsList"] = colors;
            ViewBag.Colors = colors;
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}