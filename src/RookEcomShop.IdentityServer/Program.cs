
using RookEcomShop.IndentityServer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

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

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();

app.Run();
