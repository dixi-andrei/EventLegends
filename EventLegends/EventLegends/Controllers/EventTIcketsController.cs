using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class EventTIcketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
