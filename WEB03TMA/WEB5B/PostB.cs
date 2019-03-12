using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB5B
{
    public class PostB : IHttpHandler
    {
        public bool IsReusable => false;
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;
            Random random = new Random();

            int n = Convert.ToInt32(req.Headers["X-Rand-N"]);
            int amount = random.Next(5, 10);
            List<Int32> list = new List<Int32>();
            for(Int32 i = 0; i <amount; i++)
            {
                list.Add(random.Next((-1)*n, n));
            }

            string result = "";
            result += "<?xml version='1.0'?><numbers>";
            for(int i = 0; i < list.Count; i++)
            {
                result += "<number>";
                result += list[i];
                result += "</number>";
            }
            result += "</numbers>";
            res.Headers.Add("qwe", result);
        }
    }
}