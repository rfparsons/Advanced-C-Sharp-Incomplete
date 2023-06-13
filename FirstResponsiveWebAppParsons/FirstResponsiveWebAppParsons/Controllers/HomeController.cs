using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstResponsiveWebAppParsons.Models;

namespace FirstResponsiveWebAppParsons.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = "";
            ViewBag.Name = "";
            ViewBag.MsgClass = "invisible";
            return View();
        }

        [HttpPost]
        public IActionResult Index(BirthdayCalc bc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = bc.AgeThisYear().ToString();
                ViewBag.Name = bc.Name;
                ViewBag.MsgClass = "";
            }
            else
            {
                ViewBag.Age = "";
                ViewBag.Name = "";
                ViewBag.MsgClass = "invisible";
            }

            return View();
        }
    }
}
