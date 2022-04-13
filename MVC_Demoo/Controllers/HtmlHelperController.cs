using Microsoft.AspNetCore.Mvc;

namespace MVC_Demoo.Controllers
{
    public class HtmlHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
