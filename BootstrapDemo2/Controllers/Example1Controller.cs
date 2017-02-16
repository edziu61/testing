using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo2.Views
{
    public class Example1Controller : Controller
    {
        // GET: Example1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CodeView()
        {
            return View();
        }
    }
}