namespace MiddlewareExample.CustomMiddleware
{
    public class CustomConventionalMiddlewareClassCoreMVC6 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My Custom Middleware - Starts\n");
            await next(context);
            await context.Response.WriteAsync("My Custom Middleware - Ends\n");
        }
    }

    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomConventionalMiddlewareClassCoreMVC6>();
        }
    }

}
