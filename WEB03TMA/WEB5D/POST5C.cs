using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WEB5D
{
    public class POST5C :IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            Thread.Sleep(1000);
            Random rand = new Random();
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            int n = Convert.ToInt32(req.Headers["X-Rand-N"]);
            int amount = rand.Next(5, 10);

            List<int> list = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                list.Add(rand.Next((-1) * n, n));
            }

            string result = "[ ";
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
                if (i != list.Count - 1)
                {
                    result += ", ";
                }
            }
            result += " ]";
            res.Headers.Add("qwe", result);
        }
    }
}