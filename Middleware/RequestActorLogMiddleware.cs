using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public class RequestActorsLogMiddleware
{
    private readonly RequestDelegate _next;

    public RequestActorsLogMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext, ILogger<RequestActorsLogMiddleware> logger)
    {
        if (httpContext.Request.Path.ToString().Contains("Actor"))
        {
            
            var sb = new StringBuilder();
            sb.Append($"Request: {httpContext.Request.Path}\n");
            sb.Append($"Method: {httpContext.Request.Method}\n");
            if (httpContext.Request.HasFormContentType)
            {
                sb.Append($"Params: \n");
                foreach (var a in httpContext.Request.Form)
                {
                    sb.Append($"['{a.Key}']: {a.Value}\n");
                }
            } 

            logger.LogTrace(sb.ToString());
        }
        await _next(httpContext);

    }
}