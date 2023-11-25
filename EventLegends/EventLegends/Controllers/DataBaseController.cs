using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class DataBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
