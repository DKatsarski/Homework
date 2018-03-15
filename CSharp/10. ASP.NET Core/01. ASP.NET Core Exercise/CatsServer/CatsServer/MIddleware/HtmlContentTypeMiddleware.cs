using CatsServer.Infrastructure;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsServer.MIddleware
{
    public class HtmlContentTypeMiddleware
    {
        private readonly RequestDelegate next;

        public HtmlContentTypeMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.Headers.Add(HttpHeader.ContetnType, "text/html");

            return this.next(context);
        }
    }
}
