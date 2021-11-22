using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Web.api.Extensions
{
    public static class StringExtensions
    {
        public static string ToMD5(this string pwd)
        {
            var md5 = new MD5CryptoServiceProvider();

            byte[] ba = Encoding.UTF8.GetBytes(pwd);
            ba = md5.ComputeHash(ba);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in ba)
            {
                sb.Append(b.ToString("x2").ToLower());
            }

            return sb.ToString();
        }
    }
}
