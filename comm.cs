using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
namespace MyMiddleWarw.MiddleWare
{
    public class comm
    {
    }


    public class BaseResponseResult
    {
        public string Code { get; set; }

        public string Message { get; set; }
    }

    public class RequestInfo
    {
        public string ApplicationId { get; set; }
        public string Timestamp { get; set; }
        public string Nonce { get; set; }
        public string Sinature { get; set; }
        public string ApplicationPassword { get; set; }
    }

    public class ApplicationInfo
    {
        public string ApplicationId { get; set; }

        public string ApplicationName { get; set; }

        public string ApplicationPassword { get; set; }
    }

    public class CommonResult<T> : BaseResponseResult where T : class
    {
        public T Data { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }


    public class HMACMD5Helper
    {
        /// <summary>
        /// HMACMD5 encrypt
        /// </summary>
        /// <param name="data">the date to encrypt</param>
        /// <param name="key">the key used in HMACMD5</param>
        /// <returns></returns>
        public static string GetEncryptResult(string data, string key)
        {
            HMACMD5 source = new HMACMD5(Encoding.UTF8.GetBytes(key));
            byte[] buff = source.ComputeHash(Encoding.UTF8.GetBytes(data));
            string result = string.Empty;
            for (int i = 0; i < buff.Length; i++)
            {
                result += buff[i].ToString("X2"); // hex format
            }
            return result;
        }
    }


   
}
