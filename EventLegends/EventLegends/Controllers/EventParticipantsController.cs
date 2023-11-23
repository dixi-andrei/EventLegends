using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class EventParticipantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
