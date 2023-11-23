using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class EventCategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
