using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
