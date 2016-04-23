﻿using aBlog.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aBlog.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin")]
    [SelectedTabAttribute("posts")]
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        public ActionResult Index()
        {
            return View();
        }
    }
}