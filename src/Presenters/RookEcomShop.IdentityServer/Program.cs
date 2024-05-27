
using RookEcomShop.IdentityServer;
using RookEcomShop.Infrastructure;
using RookEcomShop.Infrastructure.IdentityServer;
using RookEcomShop.Persistence;
using Serilog;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Configuration
                .AddJsonFile("appsettings.json", true, true)
                .AddUserSecrets<Program>()
                .AddEnvironmentVariables();
    builder.Services.AddPersistence(builder.Configuration);
    builder.AddIdentityServicesConfiguration();

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
    Console.WriteLine(args);
    var seed = args.Contains("/seed");
    if (seed)
    {
        args = args.Except(new[] { "/seed" }).ToArray();
    }

    if (seed)
    {
        Log.Information("Seeding database...");
        var config = builder.Configuration;
        var connectionString = config.GetConnectionString("DefaultConnection");
        SeedUsers.EnsureSeedData(connectionString);
        Log.Information("Done seeding database.");
        return;
    }

    Log.Information("Starting host...");


    app.UseStaticFiles();

    app.UseRouting();

    app.UseIdentityServer();
    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    app.Run();

}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly.");
    return;
}
finally
{
    Log.CloseAndFlush();
}