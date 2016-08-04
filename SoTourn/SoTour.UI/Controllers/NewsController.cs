﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoTour.Core;
using SoTour.DataAccess;


namespace SoTour.UI.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            var datasource = new ModelSoTour();
            IEnumerable<News> data = datasource.GetNews();
            return View(data);
        }
    }
}