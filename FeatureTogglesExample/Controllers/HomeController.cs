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
        private readonly IFeatureDecisions _decisions;

        public HomeController(IFeatureDecisions decisions)
        {
            _decisions = decisions;
        }
        public IActionResult Index()
        {
            if (_decisions.IsFeatureEnabled("Welcome"))
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
