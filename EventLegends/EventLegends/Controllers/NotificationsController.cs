﻿using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}