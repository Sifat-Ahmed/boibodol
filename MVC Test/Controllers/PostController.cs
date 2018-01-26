using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVC_Test.DAL;

namespace MVC_Test.Controllers
{
    [HandleError]
    public class PostController : Controller
    {

        private ApplicationDbContext context;

        public PostController()
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


        //[Route("Post/Buy")]
        public ActionResult Index()
        {
            return Content("Hello World");
        }
        // attribute routing for post/review and show all the reviews
        [Route("post/review" , Name = "ReviewPage")]
        public ActionResult ReviewList()
        {
            return View();
        }
        // Shows a single review by fetching the ID of reviews
        [Route("post/review/{id}" , Name = "SingleReview")]
        public ActionResult SingleReview(int id)
        {
            var review = context.Books.Include(u => u.User).SingleOrDefault(p => p.Id == id);
            //var author = context.UserDetails.SingleOrDefault(a => a.UserId == review.UserId);

            //ViewBag.Author = author.Name;
            //ViewBag.Comments = context.Comments.Where(c => c.PostId == id).ToList();

            //var reviewTest = context.Books.Comments.In

            return View(review);
        }
        // Show a page with all the buy post
        [Route("post/buy" , Name = "BuyPage")] // This name will be used to find this route
        public ActionResult BuyList()
        {
            //ViewData["ID"] = id;
            return View();
        }

        [Route("post/buy/{id}", Name = "ProductDetails")] // This name will be used to find this route
        public ActionResult Product(int id)
        {
            ViewData["ID"] = id;
            return View();
        }
        /// boibodol.com/post/sell/id
        /// boibodol.com/post/review/edit/id

    }
}