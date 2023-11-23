using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
