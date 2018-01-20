using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.Models;
namespace MVC_Test.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Post ps = new Post()
            {
                Id = 1,
                Title = "এটা একটা ডেমো পোস্ট করা হল!",
                Author = "Sifat Ahmed",
                Content = "এই পোস্টটি মডেল থেকে করা হয়েছে টেস্ট করার জন্য। এটা লুপ দিয়ে ইমপ্লিমেন্ট করা। " +
                          "কিন্তু এর সাথে ডাটাবেইজ এর কোনো কানেকশন নাই। আমি দেখতে চাচ্ছি লুপ ঘুরিয়ে " +
                          "প্রথম পেইজে ১০ টাই পোস্ট দেখানো যায় কিনা আর সেগুলা আবার রিভিউ কন্ট্রোলার এর মধ্যে দিয়ে " +
                          "রিভিউ পেইজে নেয়া যায় কিনা। ধন্যবাদ! আবার আসবেন।",
                Date = DateTime.Today.Date.ToString()
            };

            return View(ps);
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