using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Test.Controllers
{
    [HandleError]
    public class PostController : Controller
    {
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
            ViewData["ID"] = id;
            return View();
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