﻿using Microsoft.AspNetCore.Mvc;

namespace TourManagementSystem.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
