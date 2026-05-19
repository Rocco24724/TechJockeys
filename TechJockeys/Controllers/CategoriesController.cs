using Microsoft.AspNetCore.Mvc;
using TechJockeys.Models;

namespace TechJockeys.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
