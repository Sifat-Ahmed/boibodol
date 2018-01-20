using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Controllers
{
    [HandleError]
    public class UserController : Controller
    {
        // GET: User
        
        public ActionResult Index()
        {
            return Content("User");
        }

        [Route("user/login", Name = "login")]
        public ActionResult Login()
        {
            return View();
        }

        [Route("user/register", Name = "register")]
        public ActionResult Register()
        {
            return View();
        }


        // boibodol.com/user/login
        // boibodol.com/user/register
        // boibodol.com/user/profile
    }
}