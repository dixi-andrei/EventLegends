using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class OrganizersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
