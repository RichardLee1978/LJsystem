using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LJsystem.Models;
namespace LJsystem.Controllers
{
    [HandleError]
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Orders(Orders order)
        {
            order.bar = "order";
            return View(order);
        }
        public ActionResult OrdersSearch()
        {
            return View();
        }
        public ActionResult OrdersDetails (OrdersDetails OrderDetails)
        {
            OrderDetails.bar = "order";
            return View("~/Views/Orders/OrdersDetails.cshtml",OrderDetails);
        }
    }
}