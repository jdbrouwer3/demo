using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TravelPractice.Client.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Location1()
        {
            return View();
        }

        public IActionResult Location2()
        {
            return View();
        }
    }
}