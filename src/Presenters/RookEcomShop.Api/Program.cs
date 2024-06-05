using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using RookEcomShop.Api;
using RookEcomShop.Api.Middlewares;
using RookEcomShop.Application;
using RookEcomShop.Infrastructure;
using RookEcomShop.Infrastructure.ConfigurationOptions;
using RookEcomShop.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();

// Add services to the container.
builder.Configuration
            .AddJsonFile("appsettings.json", true, true)
            .AddUserSecrets<Program>()
            .AddEnvironmentVariables();

var appSettings = new AppSettings();
builder.Configuration.Bind(appSettings);
builder.Services.Configure<AppSettings>(builder.Configuration);

builder.Services
    .AddPresentation()
    .AddApplication()
    .AddPersistence(appSettings.ConnectionStrings.DefaultConnection)
    .AddInfrastructure(builder.Configuration, appSettings);


builder.Services
    .AddDirectoryBrowser();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

        options.OAuthClientId("rookEcomShop.client");
        options.OAuthClientSecret("secret");
        options.OAuthAppName("Swagger UI for RookEcomShop");
        options.OAuthUsePkce();

    });
}

app.UseHttpsRedirection();

// Set up custom content types - associating file extension to MIME type
var provider = new FileExtensionContentTypeProvider();
// Add new mappings
provider.Mappings[".myapp"] = "application/x-msdownload";
provider.Mappings[".htm3"] = "text/html";
provider.Mappings[".image"] = "image/png";
// Replace an existing mapping
provider.Mappings[".rtf"] = "application/x-msdownload";
// Remove MP4 videos.
provider.Mappings.Remove(".mp4");

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads")),
    RequestPath = "/wwwroot",
    ContentTypeProvider = provider
});

app.UseRouting();
app.UseCors("RookEcomShop");


app.UseAuthentication();

app.UseMiddleware<UserContextBuilderMiddleware>();

app.UseAuthorization();

app.UseGlobalExceptionHandler();

app.MapControllers();
app.Run();