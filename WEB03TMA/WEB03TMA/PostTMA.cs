using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB03TMA
{
    public class PostTMA : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            int x = Convert.ToInt32(req.Headers["X-Value-x"]);
            int y = Convert.ToInt32(req.Headers["X-Value-y"]);

            res.Headers.Add("X-Value-z", (x + y).ToString());
        }
    }
}