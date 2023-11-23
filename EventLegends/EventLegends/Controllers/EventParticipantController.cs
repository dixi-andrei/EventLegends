using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class EventParticipantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
