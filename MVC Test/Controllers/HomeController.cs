using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.DAL;
using MVC_Test.Models;
namespace MVC_Test.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        public HomeController()
        {
            // Creating a context of the database
            // This context will be used to fetch data from the database
            // works as a path to database
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            // disposing the connection after this controller is disposed
            // When we move to another controller then this controller gets disposed
            // as its not required anymore
            // as a result we dont need the connection any more
            context.Dispose();
        }

        public ActionResult Index()
        {
            var post = context.Books.Where(p => p.PostTypeId == 1).ToList();
            
            Dictionary<Book , string> posts = new Dictionary<Book, string>();

            foreach (var p in post)
            {
                var authorName = context.UserDetails.SingleOrDefault(a => a.UserId == p.UserId);
                posts.Add(p , authorName.ToString());
            }

            return View(post);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}