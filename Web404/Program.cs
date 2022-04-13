using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.Use((context, next) =>
//{
//    var res = next(context);
//    if (context.Response.StatusCode == 404)
//    {
//        context.Response.StatusCode = 200;
//        context.Response.Body.Write(Encoding.UTF8.GetBytes("404 from Middleware"));
//    }

//    return res;
//});

app.UseStatusCodePagesWithReExecute("/error/{0}");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapFallback(async (ctx) =>
//{
//    ctx.Response.Body.Write(Encoding.UTF8.GetBytes("404 from Fallback"));
//});

app.Run();
