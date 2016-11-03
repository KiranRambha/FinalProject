﻿using LETS.Helpers;
using LETS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LETS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public LETSContext Context = new LETSContext();

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ComponentsGuide()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ComponentsGuide(RegisterUserViewModel registerUser)
        {
            if (registerUser != null && ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}