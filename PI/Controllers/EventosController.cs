﻿using Microsoft.AspNetCore.Mvc;

namespace PI.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirmacao()
        {
            return View();
        }
    }
}
