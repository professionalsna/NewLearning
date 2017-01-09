using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NewLearning
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



            routes.MapRoute(name: "Prod", url: "Products", defaults: "~/ProductList.aspx");
            //routes.MapPageRoute("Products", "Products", "~/ProductList.aspx");

            //routes.MapPageRoute(
            //    "ProductsByCategoryRoute",
            //    "Category/{categoryName}",
            //    "~/ProductList.aspx"
            //);
            routes.MapPageRoute(
                "ProductByNameRoute",
                "Product/{productName}",
                "~/ProductDetails.aspx"
            );
        }
    }
}
