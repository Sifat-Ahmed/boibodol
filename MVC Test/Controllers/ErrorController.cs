using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return Content("<center><h1>Not Found - 404</h1></center>");
        }

        public ActionResult PageNotFound()
        {
            return View();
        }


    }
}