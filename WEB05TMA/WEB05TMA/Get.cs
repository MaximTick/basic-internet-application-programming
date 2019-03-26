using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB05TMA
{
    public class Get : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;
            res.StatusCode = 401;
            res.AddHeader("WWW-Authenticate", "Basic");
            res.End();
        }
    }
}