using Microsoft.EntityFrameworkCore;
using Invoice_Generator.Controllers;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Domain.Interfaces;
using Infrastructure.Extensions;
using Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddInApplication(); // odpowiedzialny za dodanie mediatora do projektu


//void ConfigureServices(IServiceCollection services)
//{


//}

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();
app.Run();