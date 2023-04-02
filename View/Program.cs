using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderProcessingApplication.Domain.Repositories.Abstractions;
using OrderProcessingApplication.Domain.Repositories.Implementations;
using OrderProcessingApplication.Domain.Services;
using OrderProcessingApplication.DTO.Entities;
using static OrderProcessingApplication.DTO.Constants.ViewConstantStorage;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddCors();
services.AddRazorPages();
services.AddServerSideBlazor();

var confBuilder = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile(ConfigurationFileName);
var configuration = confBuilder.Build();

services.AddSingleton(c => configuration);
services.AddSingleton<ConfigurationService>();

services.AddDbContext<PostgresOrderContext>();

services.AddScoped<IGenericRepository<Order>, OrderRepository<Order, PostgresOrderContext>>();
services.AddScoped<IGenericRepository<OrderItem>, OrderRepository<OrderItem, PostgresOrderContext>>();
services.AddScoped<IGenericRepository<Provider>, OrderRepository<Provider, PostgresOrderContext>>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
