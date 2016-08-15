using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LJsystem.Filters;
using System.Web.Security;
using LJsystem.Models;
using LJsystem.Common;

namespace LJsystem.Controllers
{
    [UserAccessFilter]
    [CompressFilter]
    public class SystemController : Controller
    {
       
        public ActionResult Index(SystemIndex  home)
        {

            home.bar = "sys";
            return View(home);
        }

        public ActionResult Employee(SystemEmployee emp)
        {

            emp.bar = "sys";
            return View(emp);
        }
        public ActionResult EmployeeSearch(SystemEmployeeSearch emp)
        {

            emp.bar = "sys";
            return View(emp);
        }
        public ActionResult EmployeeAdd()
        {
            

            return View();
        }
       public ActionResult Department(SystemDepartment dep)
        {
            dep.bar = "sys";
            return View(dep);
        }
        public ActionResult DepartmentAdd()
        {
            return View();
        }
        public ActionResult Roles(SystemRoles rol)
        {
            rol.bar = "sys";
            return View(rol);
        }
        public ActionResult RolesAdd()
        {
            return View();
        }
        public ActionResult Assign(SystemAssign Assign)
        {
            return View();
        }
        public ActionResult AssignAdd()
        {
            return View();
        }
    }
}