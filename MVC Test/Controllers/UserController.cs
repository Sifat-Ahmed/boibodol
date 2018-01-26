using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.DAL;

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

        [Route("user/login", Name = "loginValidation")]
        [HttpPost]
        public ActionResult Login(User loginData)
        {
            if (ModelState.IsValid)
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var user = context.Users.FirstOrDefault( u => u.Email == loginData.Email && u.Password == loginData.Password);
                    if (user != null)
                    {
                        var userDetail = context.UserDetails.FirstOrDefault(u => u.UserId == user.Id);
                        Session["UserId"] = user.Id;
                        Session["UserName"] = userDetail.Name;
                        Session["UserEmail"] = user.Email;
                        return RedirectToAction("Index", "Home");
                    }
                    else ModelState.AddModelError("" , "Invalid Email or Password");
                }
            }
            return View();
        }

        [Route("user/register", Name = "register")]
        public ActionResult Register()
        {
            return View();
        }

        [Route("user/register/success", Name = "registerValidation")]
        public ActionResult Register(User user)
        {

            return Content("");
        }



        [Route("user/logout", Name = "logout")]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }




        // boibodol.com/user/login
        // boibodol.com/user/register
        // boibodol.com/user/profile
    }
}