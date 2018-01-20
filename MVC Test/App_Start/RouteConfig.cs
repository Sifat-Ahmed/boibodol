using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Test
{
    public class RouteConfig
    {
        // This method Registers all the routes that we are using in the web app
        // Each route need to be registered here if not used as Mapped Route
        // Mapped Route is a custom route that has different url path
    
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Ignore any route that tries to access a file from server directly
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Enabling the Custom routing system
            routes.MapMvcAttributeRoutes();
            
            // Default route for the web app. 
            // This Default route redirects to Home Controller and executes Index() action.
            routes.MapRoute(
                name: "Default",
                // url eg: boibodol.com/home/index
                url: "{controller}/{action}/{id}",
                // for default this would take you to boibodol.com 
                // Id param is optional.
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // This route Redirects to the Post Controller
            // Post controller handle everything regarding posts
            // Post View, Post Edit etc
            // This route also includes all type of posts.
            routes.MapRoute(
                name: "Post",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Post", action = "Index", id = UrlParameter.Optional }
            );

            // This User route will be hanf=dling all user related requests
            // From Login to Registration also user profile and user settings
            routes.MapRoute(
                name: "User",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
