﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMentor.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.page = "Events";
            return View();
        }
    }
}
