using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB04TMA.App_Code
{
    public class GetJS : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            //res.Cache.SetLastModified(DateTime.MaxValue);
            res.Cache.SetMaxAge(TimeSpan.Parse("5"));


            string path = "app.js";
            res.ContentType = "application/javascript";
            res.WriteFile(path);
        }
    }
}