using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB02TMA
{
    public class PostTMA : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            response.Write("radio=" + request.Params["radio"] + "<br>" +
                "check=" + request.Params["check"] + "<br>" +
                "text=" + request.Params["text"] + "<br>" +
                "but2=" + request.Params["but2"] + "<br>" +
                "button=" + request.Params["button"] + "<br>" + "<br>");

            string[] keys = request.Headers.AllKeys;

            response.Write("<h1> Headers </h1> </br>");
            foreach(var key in keys)
            {
                response.Write(key + " = " + request.Headers[key] + "<br>");
            }

            string[] parmKeys = request.Params.AllKeys;
            response.Write("<h1> PARAMS </h1> <br>");

            foreach(var key in parmKeys)
            {
                response.Write(key + " = " + request.Params[key] + "<br>");
            }
        }
    }
}