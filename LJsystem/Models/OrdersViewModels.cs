using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using LJsystem.Models;
namespace LJsystem.Models
{
    public class Orders : Slide
    {
       public string tab { get; set; }
    }
    public class OrdersDetails : Slide
    {
        public string tab { get; set; }
    }
}
