using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.api.Extensions
{
    public class FormAuthHelper
    {
        public static string DoAuth(Account account, bool remember)
        {
            var expiration = DateTime.Now.AddMinutes(60);
            if (remember)
            {
                expiration = DateTime.Now.AddDays(15);
            }


            var ticket = new FormsAuthenticationTicket(1,
                account.AccountId.ToString(),
                DateTime.Now,
                expiration,
                false,
                "user",
                "/");


            var hashCookies = FormsAuthentication.Encrypt(ticket);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashCookies) { };


            if (remember)
            {
                cookie.Expires = expiration;
            }

            cookie.Domain = FormsAuthentication.CookieDomain;

            HttpContext.Current.Response.Cookies.Add(cookie);
            return hashCookies;
        }
    }
}
