﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return new RedirectResult("/");
            }
            return Content("Hello from the comic books controller");
            //return new ContentResult()
            //{
            //    Content = ""
            //};
        }
    }
}