using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reggaemoji.Models;

namespace Reggaemoji.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Support(SupportModel support)
        {
            Context ctx = new Context();
            ctx.support.Add(support);
            return RedirectToAction("Index");
        }
    }
}