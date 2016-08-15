using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LJsystem.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "请输入用户名")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "请输入密码")]
        public string PassWord { get; set; }
        //[Required(ErrorMessage = "请输入验证码")]
        //public string ValidateCode { get; set; }
        public string redirectUrl { get; set; }
    }
}
