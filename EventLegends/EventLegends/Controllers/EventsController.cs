using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
