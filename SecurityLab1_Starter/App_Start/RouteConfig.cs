using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
          name: "Default",
          url: "",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );

            routes.MapRoute(
          name: "Home",
          url: "Home/{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
          constraints: new { action = "Index|Contact|About|GenError" }
      );

            routes.MapRoute(
          name: "Inventory",
          url: "Inventory/{action}/{id}",
          defaults: new { controller = "Inventory", action = "Index", id = UrlParameter.Optional }
      );
            routes.MapRoute(
        name: "Login",
        url: "Account/Login",
        defaults: new { controller = "Account", action = "Login" }
    );
            routes.MapRoute(
       name: "Logout",
       url: "Account/LogOut",
       defaults: new { controller = "Account", action = "LogOut" }
   );

            routes.MapRoute(
        name: "ServerError",
        url: "Error/ServerError",
        defaults: new { controller = "Error", action = "ServerError" }
        );

            routes.MapRoute(
           "NotFound",
           "{*url}",
           new { controller = "Error", action = "NotFound" }
   );
           
        }
    }
}
