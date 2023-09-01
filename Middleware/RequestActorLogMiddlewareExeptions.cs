using Microsoft.AspNetCore.Builder;

public static class RequestActorsLogMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestActorsLog(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestActorsLogMiddleware>();
    }
}