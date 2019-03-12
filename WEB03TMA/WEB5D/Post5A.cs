using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WEB5D
{
    public class Post5A : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            Thread.Sleep(10000);
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            int x = Convert.ToInt32(req.Headers["X-Value-x"]);
            int y = Convert.ToInt32(req.Headers["X-Value-y"]);

            res.Headers.Add("X-Value-z", (x + y).ToString());
        }
    }
}