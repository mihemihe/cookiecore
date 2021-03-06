﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace cookie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ClaimsPrincipal a = new ClaimsPrincipal();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            //await HttpContext.Authentication.SignInAsync("MyCookieMiddlewareInstance", principal);

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
