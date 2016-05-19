using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Http2ImageDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string image)
        {
            base.HttpContext.Response.PushPromise("/Content/Site.css");

            ViewBag.Image = image;
            ViewBag.Sheme = base.HttpContext.Request.Url.Scheme;
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }
    }
}