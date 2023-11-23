using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class VenuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
