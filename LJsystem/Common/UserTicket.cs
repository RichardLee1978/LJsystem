using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LJsystem.Common
{
    public class UserTicket
    {
        /// <summary>
        /// 根据给定的用户名创建一个用户票据，写入cookie，并输出响应头
        /// </summary>
        /// <param name="UserName">账号名</param>
        public void CreateUserTicket(string UserName,int UserId)
        {


            //生成票据实例
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, UserName, DateTime.Now, DateTime.Now.AddMinutes(20), false, UserId.ToString());
            //将票据加密
            // string authTicket=FormsAuthentication.Encrypt(ticket); 
            //创建加密后的cookie票据
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
            cookie.Expires = DateTime.Now.AddMinutes(20);
            cookie.HttpOnly = true;
            //cookie.Secure = FormsAuthentication.RequireSSL;
            cookie.Domain = FormsAuthentication.CookieDomain;
            FormsAuthentication.SetAuthCookie(UserName, true, FormsAuthentication.FormsCookiePath);
            HttpContext.Current.Response.Cookies.Add(cookie);
            
        }
        /// <summary>
        /// 从用户票据中取出用户名
        /// </summary>
        /// <returns>结果值string=>用户名 </returns>
        public  String GetTicketUserName()
        {
            string s = null;
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                FormsIdentity identity = (FormsIdentity)HttpContext.Current.User.Identity;
                FormsAuthenticationTicket ticket = identity.Ticket;
                s = ticket.Name;
            }
           
            return s;
        }
        /// <summary>
        /// 从用户票据中取出用户ip
        /// </summary>
        /// <returns>结果值string=>用户id </returns>
        public  String GetTicketUserID()
        {
            string s = null;
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                FormsIdentity identity = (FormsIdentity)HttpContext.Current.User.Identity;
                FormsAuthenticationTicket ticket = identity.Ticket;
                s = ticket.UserData;
            }
       
            return s;
        }
    }
}
