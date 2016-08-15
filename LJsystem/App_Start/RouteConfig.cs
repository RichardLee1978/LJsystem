using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LJsystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                           name: "Normal",
                           url: "",
                           defaults: new { controller = "System", action = "Index" }
             );
            routes.MapRoute(
                          name: "Employee",
                          url: "System/Employee",
                          defaults: new { controller = "System", action = "Employee" }
            );
            routes.MapRoute(
                         name: "EmployeeSearch",
                         url: "System/EmployeeSearch",
                         defaults: new { controller = "System", action = "EmployeeSearch" }
           );
            routes.MapRoute(
                          name: "EmployeeAdd",
                          url: "System/Employee/Add",
                          defaults: new { controller = "System", action = "EmployeeAdd" }
            );
            routes.MapRoute(
                    name: "Department",
                    url: "System/Department",
                    defaults: new { controller = "System", action = "Department" }
                );
            routes.MapRoute(
                    name: "DepartmentAdd",
                    url: "System/Department/Add",
                    defaults: new { controller = "System", action = "DepartmentAdd" }
                );
          
            routes.MapRoute(
                    name:"Roles",
                    url:"System/Roles",
                    defaults:new { Controller = "System",action = "Roles"}
                
                );
            routes.MapRoute(
                    name: "RolesAdd",
                    url: "System/Roles/Add",
                    defaults: new { Controller = "System", action = "RolesAdd" }

                );
            routes.MapRoute(
                    name: "Assign",
                    url:"System/Assign",
                    defaults: new{ Controller = "System",action = "Assign" }
                );
            routes.MapRoute(
                    name: "AssignAdd",
                    url: "System/Assign/Add",
                    defaults: new { Controller = "System", action = "AssignAdd" }
                );
            routes.MapRoute(
                  name: "Users",
                  url: "Users/",
                  defaults: new { controller = "Users", action = "Users" }
              );
            routes.MapRoute(
                 name: "UsersDetails",
                 url: "Users/UsersDetails/{id}",
                 defaults: new { controller = "Users", action = "UsersDetails"}
             );
            routes.MapRoute(
                  name: "UsersProducts",
                  url: "Users/Products",
                  defaults: new { controller = "Users", action = "UsersProducts" }
              );
            routes.MapRoute(
                  name: "UsersProductsDetails",
                  url: "Users/UsersProductsDetails/{id}",
                  defaults: new { controller = "Users", action = "UsersProductsDetails" }
              );
            routes.MapRoute(
                  name: "Orders",
                  url: "Orders/",
                  defaults: new { controller = "Orders", action = "Orders" }
              );
            routes.MapRoute(
                 name: "OrdersSearch",
                 url: "Orders/Search",
                 defaults: new { controller = "Orders", action = "OrdersSearch" }
             );
            routes.MapRoute(
                name: "OrdersDetails",
                url: "Orders/OrdersDetails/{id}",
                defaults: new { controller = "Orders", action = "OrdersDetails" }
            );
            routes.MapRoute(
                name: "Products",
                url: "Products/",
                defaults: new { Controller = "Products",action = "Index" }
                );
            routes.MapRoute(
                      name: "Login",
                      url: "login/",
                      defaults: new { controller = "Account", action = "Login" }
            );
            routes.MapRoute(
                     name: "Logout",
                     url: "logout/",
                     defaults: new { controller = "Account", action = "Logout" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
