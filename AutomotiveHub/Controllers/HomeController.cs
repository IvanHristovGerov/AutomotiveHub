﻿using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static AutomotiveHub.Areas.Constants.UserConstants;

namespace AutomotiveHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarService carService;
        public HomeController(ILogger<HomeController> logger, ICarService _carService)
        {
            _logger = logger;
            carService = _carService;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole(AdminRole))
            {
                return RedirectToAction("Index", "Home", new { area = "Administrator" });
            }
            var model = await carService.AllCarsAsync();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
