using System.Web.Mvc;
using System.Web.Routing;

namespace vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //How to use attribute routes for custom routing!!
            routes.MapMvcAttributeRoutes();
            //Place route above actionResult Method in Controller-see Controller

            // creating custom routes(old way of routing** attribute routing **shown above is the preferred method)

            //routes.MapRoute(
            //    "MovieByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { Controller = "Movies", action = "ByReleaseDate" },
            //    // sets the year to 4 digits and the month to two digits
            //    // old way of routing** should use attribute routing if possible
            //    new { year = @"\d{4}", month = @"\d{2}" });
            // set constraints to year 2015 and 2016
            //    new { year = @"2015|2016", month = @"\d{2}" });

            //routes.MapRoute(
            //    name: "Customers",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new {controller = "Customers", action = "Index", id = UrlParameter.Optional});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
