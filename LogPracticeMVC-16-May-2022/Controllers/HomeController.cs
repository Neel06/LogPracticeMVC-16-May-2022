﻿using LogPracticeMVC_16_May_2022.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LogPracticeMVC_16_May_2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("--------Info Msg--------");
            _logger.LogWarning("--------Warning Msg--------");
            _logger.LogError("--------Error Msg--------");
            return View();
        }

        public IActionResult Privacy()
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