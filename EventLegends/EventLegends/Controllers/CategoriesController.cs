using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
