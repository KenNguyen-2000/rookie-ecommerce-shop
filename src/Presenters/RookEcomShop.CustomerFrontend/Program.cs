
using Microsoft.Extensions.FileProviders;
using RookEcomShop.CustomerFrontend;
using RookEcomShop.CustomerFrontend.Extensions;
using RookEcomShop.CustomerFrontend.Middlewares;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddAuthenticationConfiguration()
    .AddHttpContextAccessor()
    .AddApiClientConfiguration(builder.Configuration);

SerilogConfiguration.ConfigureSerilog();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseStatusCodePagesWithReExecute("/Error/{0}");

app.UseMiddleware<UnauthorizedRedirectMiddleware>();
app.UseMiddleware<GlobalExceptionMiddlerware>();

app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "productDetails",
    pattern: "Products/{productId}",
    defaults: new { controller = "Products", action = "Details" });

app.Run();
