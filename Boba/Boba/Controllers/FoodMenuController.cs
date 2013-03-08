using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BobaBusinessLayer;

namespace Boba.Controllers
{
    public class FoodMenuController : Controller
    {
  
        public ActionResult Index()
        {
            return View();
        }

    }
}
