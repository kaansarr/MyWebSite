﻿using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
