using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LJsystem.Models;

namespace LJsystem.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(Products Products)
        {
            Products.bar = "products";
            return View(Products);
        }
    }
}