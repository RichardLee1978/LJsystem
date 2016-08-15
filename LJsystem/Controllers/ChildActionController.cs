using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LJsystem.Models;

namespace LJsystem.Controllers
{
    public class ChildActionController : Controller
    {
        // GET: ChildAction
        [ChildActionOnly]
        //[OutputCache(Duration = 3600)]
        public PartialViewResult Slide(Slide s)
        {
            
            ViewBag.userName = s.GetMenuAndUserName()["CurrentUserName"];
            return PartialView("~/Views/Partial/_Slide.cshtml",s);
        }
    }
}