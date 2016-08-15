using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using LJsystem.Models;
using LJsystem.Common;
using System.Web.Security;

namespace LJsystem.Controllers
{
    
    public class AccountController : Controller
    {
        //
        // GET: /Login
       [HttpGet]
        public ActionResult Login()
        {
            UserTicket ut = new UserTicket();
           string name = ut.GetTicketUserName();
            string returnurl = Request.QueryString["redirectUrl"];
            ViewBag.url = returnurl;
            return View();
        }

        //
        // POST: /Login
        [HttpPost]
        
        public ActionResult Login(UserLogin login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                UserTicket ut = new UserTicket();
                 ut.CreateUserTicket("lirui",1);
                
                return Redirect(login.redirectUrl);
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
        public void CreateCookie()
        {
            HttpCookie UserName = new HttpCookie("name");
            
            UserName.Value = Request["userName"];
            System.Web.HttpContext.Current.Response.SetCookie(UserName);
            //cookie保存时间  
            UserName.Expires = DateTime.Now.AddHours(10);
        }
    }
}