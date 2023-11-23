using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
