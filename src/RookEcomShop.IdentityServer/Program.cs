
using RookEcomShop.IndentityServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services
    .AddConfigIdentityServices(builder.Configuration);

//builder.Services.AddAuthentication()
//    .AddGoogle(options =>
//    {
//        options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

//        // register your IdentityServer with Google at https://console.developers.google.com
//        // enable the Google+ API
//        // set the redirect URI to https://localhost:5001/signin-google
//        options.ClientId = "copy client ID from Google here";
//        options.ClientSecret = "copy client secret from Google here";
//    });
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
else
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthorization();

app.MapRazorPages()
    .RequireAuthorization();

app.Run();
