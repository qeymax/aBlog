﻿using aBlog.Areas.Admin.ViewModels;
using aBlog.Infrastructure;
using aBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTabAttribute("users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {

 
                return View(new UserContext());
        }
    }
}