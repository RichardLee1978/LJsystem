using System;
using System.Web;
using System.Collections;
using LJsystem.Common;
namespace LJsystem.Models
{
   public  class Slide
    {
        public  string bar { get; set; }
       
        public  Hashtable GetMenuAndUserName()
        {
            UserTicket _userT = new UserTicket();
            string CurrentUserName = _userT.GetTicketUserName();
            
            Hashtable menu = new Hashtable();
            menu.Add("CurrentUserName", CurrentUserName);
            return menu;
        }
    }
}
