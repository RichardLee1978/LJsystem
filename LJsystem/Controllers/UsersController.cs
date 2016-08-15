using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LJsystem.Models;

namespace LJsystem.Controllers
{
    [HandleError]
    public class UsersController : Controller
    {
        // GET: User
        public ActionResult Users(Users user)
        {
            user.bar = "user";
            return View(user);
        }
        public ActionResult UsersSearch()
        {
            return View();
        }
        public ActionResult UsersDetails(UsersDetails UsersDetails)
        {
            UsersDetails.bar = "user";
            return View(UsersDetails);
        }
        public ActionResult UsersProducts(UsersProducts Products)
        {
            Products.bar = "user";
            return View(Products);
        }
        public ActionResult UsersProductsDetails(UsersProductsDetails ProductsDetails)
        {
            ProductsDetails.bar = "user";
            return View(ProductsDetails);
        }
       
    }
}