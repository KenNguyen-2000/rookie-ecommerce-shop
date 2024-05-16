using Infrastructure;
using RookEcomShop.Api;
using RookEcomShop.Api.Extensions.Configurations;
using RookEcomShop.Application;
using RookEcomShop.Infrastructure.Extensions.GlobalExceptonHandler;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration
            .AddJsonFile("appsettings.json", true, true)
            .AddUserSecrets<Program>()
            .AddEnvironmentVariables();

builder.Services
    .AddPresentation()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfiguration();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

//app.UseIdentityServer();
app.UseAuthorization();

app.UseGlobalExceptionHandler();

app.MapControllers();
app.Run();