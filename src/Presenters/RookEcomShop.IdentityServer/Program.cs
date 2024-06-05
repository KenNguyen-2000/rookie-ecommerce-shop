using RookEcomShop.IdentityServer.Configuration;
using RookEcomShop.IdentityServer.ConfigurationOptions;
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

    var appSettings = new AppSettings();
    builder.Configuration.Bind(appSettings);
    builder.Services.Configure<AppSettings>(builder.Configuration);

    builder.ConfigureIdentityServices(appSettings);

    builder.Services.AddRazorPages();
    builder.Services
        .AddPersistence(appSettings.ConnectionStrings.DefaultConnection);


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
    var seed = args.FirstOrDefault(arg => arg == "/seed") != null;
    if (seed)
    {
        args = args.Except(new[] { "/seed" }).ToArray();
    }

    if (seed)
    {
        Log.Information("Seeding database...");
        var config = builder.Configuration;

        SeedUsers.EnsureSeedData(appSettings.ConnectionStrings.IdentityConnection, appSettings.ConnectionStrings.DefaultConnection).Wait();
        Log.Information("Done seeding database.");
        return;
    }

    Log.Information("Starting host...");


    app.UseStaticFiles();

    app.UseRouting();

    app.UseIdentityServer();
    app.UseAuthentication();
    app.UseAuthorization();

    app.MapRazorPages();
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