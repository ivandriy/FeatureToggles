using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FeatureTogglesExample.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using FeatureTogglesExample.Models;

namespace FeatureTogglesExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureToggle _feature;

        public HomeController(IFeatureToggle feature)
        {
            _feature = feature;
        }
        public IActionResult Index()
        {
            if (_feature.IsFeatureEnabled("Welcome"))
            {
                ViewData["Message"] = "Welcome to feature toggle";
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
