using Application;
using FluentValidation;
using Infrastructure;
using RookEcomShop.Api;
using RookEcomShop.Api.Extensions.Configurations;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Add services to the container.
builder.Configuration
            .AddJsonFile("appsettings.json", true, true)
            .AddUserSecrets<Program>()
            .AddEnvironmentVariables();

builder.Services
    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

builder.Services
    .AddPresentation()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfiguration();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();


app.UseIdentityServer();
app.UseAuthorization();


app.MapControllers();
app.Run();