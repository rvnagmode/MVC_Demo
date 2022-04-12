using Microsoft.AspNetCore.Mvc;
using MVC_Demoo.Models;

namespace MVC_Demoo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product> {
            new Product {Id =1,Name="Hp laptop",Price=35000},
            new Product {Id =2,Name="Dell laptop",Price=45000},
            new Product {Id =3,Name="Asus laptop",Price=55000}

            };
            ViewBag.Productlist = plist;

            return View();
        }
        public IActionResult AddNewItem()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
