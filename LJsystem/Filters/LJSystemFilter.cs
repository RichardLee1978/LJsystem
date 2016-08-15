using System;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Web.Security;
using System.Text;
using System.IO;
using System.IO.Compression;
namespace LJsystem.Filters
{
    public class UserAccessFilter : ActionFilterAttribute
    {
        /// <summary>  
        /// OnActionExecuting是Action执行前的操作  
        /// </summary>  
        /// <param name="filterContext"></param>  
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            //判断Cookie用户名密码是否存在 
            string RedirectUrl = "?redirectUrl=" + filterContext.HttpContext.Request.Url.ToString();
            HttpCookie cookieName = System.Web.HttpContext.Current.Request.Cookies.Get("guest");
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                //filterContext.Result = new RedirectResult("/Login");
                //FormsAuthentication.SetAuthCookie(Encrypt("guest"), true);
                filterContext.Result = new RedirectResult("/Login" + RedirectUrl);
            }
        }
       
            
        
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
    public class CompressFilter: ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var encodingsAccepted = filterContext.HttpContext.Request.Headers["Accept-Encoding"];
            if (string.IsNullOrEmpty(encodingsAccepted)) return;

            encodingsAccepted = encodingsAccepted.ToLowerInvariant();
            var response = filterContext.HttpContext.Response;

            if (encodingsAccepted.Contains("deflate"))
            {
                response.AppendHeader("Content-encoding", "deflate");
                response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
            }
            else if (encodingsAccepted.Contains("gzip"))
            {
                response.AppendHeader("Content-encoding", "gzip");
                response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
            }
        }
    }
}
