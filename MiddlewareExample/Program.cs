using MiddlewareExample.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<CustomConventionalMiddlewareClassCoreMVC6>();
var app = builder.Build();



//middlware 1
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("From Midleware 1\n");
    await next(context);
});

//middleware 2
//app.UseMiddleware<CustomConventionalMiddlewareClassCoreMVC6>();
//app.UseMyCustomMiddleware();
app.UseHelloCustomMiddleware();

//middleware 3
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("From Middleware 3\n");
});


app.Run();
