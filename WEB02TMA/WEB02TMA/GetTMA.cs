using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB02TMA
{
    public class GetTMA : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            response.AddHeader("X-TMA", "Tikhonovish Maxim");
            response.WriteFile("response_page.html");
            response.Write("<h1>" + request.Params["getTMAparam"] + "</h1>");
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}