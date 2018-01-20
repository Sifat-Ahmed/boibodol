using System.Web;
using System.Web.Optimization;

namespace MVC_Test
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           // bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //"~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //"~/Scripts/bootstrap.js",
            //"~/Scripts/respond.js"));


            // Here All the Custom JS files are added
            // Creating a ScriptBundle object with the name ""~/Content/js/appjs""
            // And provoking the include method to include JS files
            // For further use we need to call it by name as given in the constructor
            bundles.Add(new ScriptBundle("~/Content/js/appjs").Include(
                    "~/Content/js/bootstrap.min.js",
                    "~/Content/js/classie.js",
                    "~/Content/js/jquery-1.11.1.min.js",
                    "~/Content/js/jquery.chocolat.js",
                    "~/Content/js/modernizr.custom.js",
                    "~/Content/js/sell.js",
                    "~/Content/js/wow.min.js",
                    "~/Content/js/uiserach.js",
                    "~/Content/js/login.js"
            ));

            // Here All the Custom CSS files are added
            // Creating a ScriptBundle object with the name ""~/Content/css/appcss""
            // And provoking the include method to include JS files
            // For further use we need to call it by name as given in the constructor
            bundles.Add(new StyleBundle("~/Content/css/appcss").Include(
                    "~/Content/css/bootstrap.css",
                    "~/Content/css/Site.css",
                    "~/Content/css/animate.min.css",
                    "~/Content/css/bootstrap.min.css",
                    "~/Content/css/chocolat.css",
                    "~/Content/css/component.css",
                    "~/Content/css/sell.css",
                    "~/Content/css/style.css",
                    "~/Content/css/login.css",
                    "~/Content/css/error.css"
            ));
            
        }
    }
}
