using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WEB04TMA
{
    public class GetPNG : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest req = context.Request;
            HttpResponse res = context.Response;

            string parm = req.Params.Get("cache-parm");

            switch (parm)
            {
                case "last-modified":   
                    res.Cache.SetLastModified(DateTime.MinValue);
                    break;
                case "etag":            
                    res.CacheControl = "public";
                    res.Cache.SetETag("maxik".GetHashCode().ToString());
                    break;
                case "expired":         
                    res.Cache.SetExpires(DateTime.Now.AddDays(10));
                    break;
                case "max-age":         
                    res.Cache.SetMaxAge(TimeSpan.FromSeconds(5));
                    break;
                case "no-store":        
                    res.Cache.SetNoStore();
                    break;
            }

            string path = "oracle.png";
            res.ContentType = "image/" + Path.GetExtension(path).ToLower();
            res.WriteFile(path);
        }
    }
}