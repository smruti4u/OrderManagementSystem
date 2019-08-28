using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagementSystem.Middlewire
{
    public class ErrorHandlingMiddleWire
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleWire(RequestDelegate _next)
        {
            this._next = _next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                //log
            }

        }


    }

    public static class ErrorhandlingMiddlewireExtensionMethods
    {
        public static IApplicationBuilder UseErrorHandliing(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ErrorHandlingMiddleWire>();
        }
    }
}
